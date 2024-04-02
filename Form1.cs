using ScottPlot;
using Color = System.Drawing.Color;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.IO.Ports;

namespace GCS_Phoenix
{



    public partial class Form1 : Form
    {

        private const float PADLEFT = 60; // Offset des graphiques
        private string cachePath = Directory.GetCurrentDirectory() + "\\Cache";
        private GMapOverlay markersOverlay = new GMapOverlay("marker1");
        private int packetSize = 0;
        private byte[] data;

        public Form1()
        {
            InitializeComponent();
            InitializeMap();
            InitializeComPort();
            AddPointToMap();

        }

//------------------------------------------MAP----------------------------------------------------------------------------------------//
        public void InitializeMap()
        {
            gMapControl1.CacheLocation = cachePath;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleSatelliteMap;
            gMapControl1.Dock = DockStyle.Fill;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache; // Change ServerAndCahe to Cache only for offline use
            gMapControl1.ShowCenter = false;
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;
            
        }

        public void AddPointToMap()
        {

            double latitude = 48.47583; // Your received latitude;
            double longitude = -81.330494; // Your received longitude;

            gMapControl1.Position = new PointLatLng(latitude, longitude);
            gMapControl1.Zoom = 15;
            for (int i = 0; i < 10; i++)
            {
                latitude += 0.0005;
                longitude += 0.0005;
                var marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new PointLatLng(latitude, longitude), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_small);
                markersOverlay.Markers.Add(marker);
                gMapControl1.Overlays.Add(markersOverlay);
            }


            gMapControl1.Update();
            gMapControl1.Refresh();
        }
//------------------------------------------FIN MAP------------------------------------------------------------------------------------//


//------------------------------------------SERIAL PORT--------------------------------------------------------------------------------//

        private void InitializeComPort()
        {
            // Lister les ports de COM utilisable
            string[] ports = SerialPort.GetPortNames();

            // Initialiser le combobox de ports avec les ports utilisables
            foreach (string port in ports)
            {
                comboPorts.Items.Add(port);
            }
        
        }

        public string GetSerialPort()
        {
            try
            {
                return comboPorts.SelectedItem.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a valid serial port. :: " + ex.Message, "Error!");
                return "";
            }
            
        }

        public int GetBaudRate()
        {
            try
            {
                int baudRate = Int32.Parse(comboBaud.SelectedItem.ToString());
                return baudRate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select the baudrate. :: " + ex.Message, "Error!");
                return 0;
            }

        }

        // Connect button
        private void button4_Click(object sender, EventArgs e)
        {
            if (Program.ConnectPort())
            {
                SerialPort sp1 = Program.GetSerialPort();

                serialConnectivityLabel.Text = "Connected";
                serialConnectivityLabel.ForeColor = Color.Green;
                connectedLed.Color = Color.Green;
                
                sp1.DataReceived += new SerialDataReceivedEventHandler(Sp_DataReceived);
            }
        }

        // Add this method to subscribe to DataReceived event and handle received data
        

        // Event handler for DataReceived event
        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Cast sender to SerialPort
            SerialPort sp = (SerialPort)sender;

            // Read the data from the serial port
            int receivedData;


            receivedData = sp.ReadByte();
            packetSize = receivedData+1;    
            data = new byte[packetSize];
            data[0] = (byte)receivedData;
            for (int i=1; i < packetSize; i++) {
                data[i] = (byte)sp.ReadByte(); 
            }
           

           using (MemoryStream stream = new MemoryStream(data))
                {
                    // Deserialize the byte array back to a Person instance
                    SimpleMessage deserializedPerson = SimpleMessage.Parser.ParseDelimitedFrom(stream);

                    // Display the deserialized Person
                    AppendToSerialDataBox($"Number: {deserializedPerson.LuckyNumber}");
                }


            // Append the received data to the RichTextBox
        }

        // Method to append data to the serialDataBox RichTextBox
        private void AppendToSerialDataBox(string data)
        {
            if (serialDataBox.InvokeRequired)
            {
                serialDataBox.Invoke(new MethodInvoker(() => AppendToSerialDataBox(data)));
            }
            else
            {
                serialDataBox.AppendText(data + Environment.NewLine); // Append data and add a newline
            }
        }



        // Disconnect button
        private void button5_Click(object sender, EventArgs e)
        {
            Program.DisconnectPort();
            serialConnectivityLabel.Text = "Disconnected";
            serialConnectivityLabel.ForeColor = Color.Red;
            connectedLed.Color = Color.Red;
        }






        //------------------------------------------FIN SERIAL PORT----------------------------------------------------------------------------//


        //------------------------------------------UI-----------------------------------------------------------------------------------------//

        private void Form1_Load(object sender, EventArgs e)
        {


            acceleroPlot.Plot.SetAxisLimits(0, 100, -2, 2);
            altitudePlot.Plot.SetAxisLimits(0, 100, -2, 2);

            acceleroPlot.Plot.Style(Style.Blue1);
            acceleroPlot.Plot.Layout(PADLEFT);
            acceleroPlot.Plot.XLabel("Time (S)");
            acceleroPlot.Plot.Title("Accelerometers (C)");
            acceleroPlot.Render();

            altitudePlot.Plot.Style(Style.Blue1);
            altitudePlot.Plot.Layout(PADLEFT);
            altitudePlot.Plot.XLabel("Time (S)");
            altitudePlot.Plot.Title("Altitude (M)");
            altitudePlot.Render();

        }

        // Reset button
        private void button3_Click(object sender, EventArgs e)
        {
            gMapControl1.Position = new PointLatLng(48.47583, -81.330494);
            gMapControl1.Update();
            gMapControl1.Refresh();

        }

        


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void currentStageLabel_Click(object sender, EventArgs e)
        {

        }
//------------------------------------------FIN UI-------------------------------------------------------------------------------------//
    }
}