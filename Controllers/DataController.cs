using GCS_Phoenix.Models;
using ScottPlot.Plottables;

namespace GCS_Phoenix.Controllers
{
    public class DataController
    {
        public Form1 form;

        public List<DataPoint> _altitude = new List<DataPoint>();                  //List that contains altitude data
        public List<DataPoint> _accX = new List<DataPoint>();                      //List that contains acceleration in X data
        public List<DataPoint> _accY = new List<DataPoint>();                      //List that contains acceleration in Y data
        public List<DataPoint> _accZ = new List<DataPoint>();                      //List that contains acceleration in Z data
        public List<DataPoint> _gyroX = new List<DataPoint>();                      //List that contains gyroscope data in X 
        public List<DataPoint> _gyroY = new List<DataPoint>();                      //List that contains gyroscope data in Y
        public List<DataPoint> _gyroZ = new List<DataPoint>();                      //List that contains gyroscope data in Z
        public List<GpsPoint> _gpsPoints = new List<GpsPoint>();                   //List that holds the gps telemetry data
        public List<DataPoint> _Temp = new List<DataPoint>();                      //List that holds Temperature data
        public List<PhoenixPacket> _Telemetry = new List<PhoenixPacket>();         //List to hold all of the receiving data
        public DataLogger sigX = new DataLogger();
        public DataLogger sigY = new DataLogger();
        public DataLogger sigZ = new DataLogger();
        public DataLogger gyroX = new DataLogger();
        public DataLogger gyroY = new DataLogger();
        public DataLogger gyroZ = new DataLogger();
        public DataLogger alt = new DataLogger();

        public DataController(Form1 form1) 
        {
            this.form = form1;
        }


        public void SetupData()
        {
            alt = form.altitudePlot.Plot.Add.DataLogger();
            sigX = form.acceleroPlot.Plot.Add.DataLogger();
            sigY = form.acceleroPlot.Plot.Add.DataLogger();
            sigZ = form.acceleroPlot.Plot.Add.DataLogger();
            gyroX = form.gyroPlot.Plot.Add.DataLogger();
            gyroY = form.gyroPlot.Plot.Add.DataLogger();
            gyroZ = form.gyroPlot.Plot.Add.DataLogger();

            sigX.LegendText = "X";
            sigY.LegendText = "Y";
            sigZ.LegendText = "Z";
            gyroX.LegendText = "X";
            gyroY.LegendText = "Y";
            gyroZ.LegendText = "Z";

            
        }


        /// <summary>
        /// Method to add data to ui and local memory
        /// </summary>
        /// <param name="packet">The received packet</param>
        public void InsertDataPacket(PhoenixPacket packet)
        {
            int packetNumber = form.msgReceived +1;
            //Log data to local variables
            _Telemetry.Add(packet);
            _altitude.Add(new DataPoint { Id = packetNumber, Value = packet.Altitude });
            _accX.Add(new DataPoint { Id = packetNumber, Value = packet.AccelerationX });
            _accY.Add(new DataPoint { Id = packetNumber, Value = packet.AccelerationY });
            _accZ.Add(new DataPoint { Id = packetNumber, Value = packet.AccelerationZ });
            _gpsPoints.Add(new GpsPoint { Id = packetNumber, LAT = packet.Lattitude, LONG = packet.Longitude });
            _Temp.Add(new DataPoint { Id = packetNumber, Value = packet.Temperature });

            //Add packet data to graphs
            sigX.Add(packetNumber, packet.AccelerationX);
            sigY.Add(packetNumber, packet.AccelerationY);
            sigZ.Add(packetNumber, packet.AccelerationZ);
            gyroX.Add(packetNumber, packet.GyroX);
            gyroY.Add(packetNumber, packet.GyroY);
            gyroZ.Add(packetNumber, packet.GyroZ);
            alt.Add(packetNumber, packet.Altitude);

            //form.mapController.AddPointToMap(packet.Lattitude, packet.Longitude);

            form.acceleroPlot.Refresh();
            form.altitudePlot.Refresh();
            form.gyroPlot.Refresh();

            //Increment number of packets
            form.msgReceived++;
            form.msgReceivedLabel.Text = $"PACKETS RECEIVED : {packetNumber}";


        }

        public void EnableGraphFull()
        {
            alt.ViewFull();
            sigX.ViewFull();
            sigY.ViewFull();
            sigZ.ViewFull();
            gyroX.ViewFull();
            gyroY.ViewFull();
            gyroZ.ViewFull();
        }

        public void EnableGraphSlide()
        {
            alt.ViewSlide(10);
            sigX.ViewSlide(10);
            sigY.ViewSlide(10);
            sigZ.ViewSlide(10);
            gyroX.ViewSlide(10);
            gyroY.ViewSlide(10);
            gyroZ.ViewSlide(10);

        }

    }
}

