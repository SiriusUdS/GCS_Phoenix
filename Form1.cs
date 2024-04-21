using ScottPlot.WinForms;
using Color = System.Drawing.Color;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.IO.Ports;
using ScottPlot;

namespace GCS_Phoenix
{



    public partial class Form1 : Form
    {

        private readonly string cachePath = Directory.GetCurrentDirectory() + "\\Cache";     //Path of the cache folder for the map.
        private GMapOverlay markersOverlay = new GMapOverlay("marker1");            //Markers overlay for the map.
        private byte[] _data;                                                       //Byte array to store the protobuf message.

        private int rxErrors = 0;                                                   //Number of reception errors
        private int msgReceived = 0;                                                //Number of messages correctly received
        private int _packetSize = 0;                                                //The size of the receiving packet

        private List<DataPoint> _altitude = new List<DataPoint>();                  //List that contains altitude data
        private List<DataPoint> _accX = new List<DataPoint>();                      //List that contains acceleration in X data
        private List<DataPoint> _accY = new List<DataPoint>();                      //List that contains acceleration in Y data
        private List<DataPoint> _accZ = new List<DataPoint>();                      //List that contains acceleration in Z data
        private List<GpsPoint> _gpsPoints = new List<GpsPoint>();

        public struct DataPoint
        {
            private float X;
            private int Y;

            public DataPoint(float x, int y)
            {
                X = x;
                Y = y;
            }
        }

        public struct GpsPoint
        {
            private float LAT;
            private float LONG;

            public GpsPoint(float lat, float _long)
            {
                LAT = lat;
                LONG = _long;
            }
        }



        public Form1()
        {
            InitializeComponent();
            InitializeMap();
            InitializeComPort();

            //TODO remove when we start to receive real values and move into another method.
            AddPointToMap(5, 5);

        }

        //------------------------------------------MAP----------------------------------------------------------------------------------------//

        /// <summary>
        /// Code to initialize the map.
        /// </summary>
        public void InitializeMap()
        {
            gMapControl1.CacheLocation = cachePath;
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleSatelliteMap;
            gMapControl1.Dock = DockStyle.Fill;
            GMaps.Instance.Mode = AccessMode.CacheOnly; // Change ServerAndCahe to Cache only for offline use
            gMapControl1.ShowCenter = false;
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;

        }

        /// <summary>
        /// Adds a marker to the map using the provides latitude and longitude.
        /// </summary>
        /// <param name="_lat">The latitude of the marker to add.</param>
        /// <param name="_long">The longitude of the marker to add.</param>
        public void AddPointToMap(double _lat, double _long)
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



        /// <summary>
        /// Resets the position of the map when the reset map button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            gMapControl1.Position = new PointLatLng(48.47583, -81.330494);
            gMapControl1.Zoom = 15;
            gMapControl1.Update();
            gMapControl1.Refresh();

        }


        //------------------------------------------FIN MAP------------------------------------------------------------------------------------//


        //------------------------------------------SERIAL PORT--------------------------------------------------------------------------------//

        /// <summary>
        /// Initializes the COM ports by populating the combo box with available port names.
        /// </summary>
        private void InitializeComPort()
        {
            // Get available port names
            string[] ports = SerialPort.GetPortNames();

            // Add each port name to the combo box
            foreach (string port in ports)
            {
                comboPorts.Items.Add(port);
            }
        }

        /// <summary>
        /// Retrieves the selected serial port name from the combo box.
        /// </summary>
        /// <returns>The selected serial port name.</returns>
        public string GetSerialPort()
        {
            try
            {
                string? port = comboPorts.SelectedItem?.ToString();
                
                // Return the selected serial port name
                if (port != null)
                    return port;
                else
                    return "";

            }
            catch (Exception ex)
            {
                // Show error message if no port selected
                MessageBox.Show("Please select a valid serial port. :: " + ex.Message, "Error!");
                return "";
            }
        }

        /// <summary>
        /// Retrieves the selected baud rate from the combo box.
        /// </summary>
        /// <returns>The selected baud rate.</returns>
        public int GetBaudRate()
        {
            try
            {
                string? baudString = comboBaud.SelectedItem?.ToString();
                
                // Parse and return the selected baud rate
                if (baudString != null)
                    return int.Parse(baudString);
                else
                    return 0;
            }
            catch (Exception ex)
            {
                // Show error message if no baud rate selected
                MessageBox.Show("Please select the baudrate. :: " + ex.Message, "Error!");
                return 0;
            }
        }

        /// <summary>
        /// Event handler for the Connect button click event.
        /// Initiates the connection to the serial port and subscribes to data received event.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void button4_Click(object sender, EventArgs e)
        {
            // Attempt to connect to the serial port
            if (Program.ConnectPort())
            {
                // Retrieve the connected serial port
                SerialPort sp1 = Program.GetSerialPort();

                // Update UI elements to indicate successful connection
                serialConnectivityLabel.Text = "Connected";
                serialConnectivityLabel.ForeColor = Color.Green;
                connectedLed.Color = Color.Green;

                // Subscribe to data received event
                sp1.DataReceived += Sp_DataReceived;
            }
        }

        /// <summary>
        /// Event handler for the serial port data received event.
        /// Reads incoming data, processes it, and updates the UI.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Cast sender to SerialPort
            SerialPort sp = (SerialPort)sender;

            // Read the data from the serial port
            int receivedData;
            receivedData = sp.ReadByte();

            // Append received data to the serial data box
            AppendToSerialDataBox(receivedData.ToString());

            // Process received data (if applicable)
            _packetSize = receivedData + 1;
            _data = new byte[_packetSize];
            _data[0] = (byte)receivedData;

            for (int i = 1; i < _packetSize; i++)
            {
                byte received = (byte)sp.ReadByte();
                _data[i] = received;
                AppendToSerialDataBox(received.ToString());
            }

            // Deserialize and display received message
            using (MemoryStream stream = new MemoryStream(_data))
            {
                try
                {
                    SimpleMessage deserializedPerson = SimpleMessage.Parser.ParseDelimitedFrom(stream);
                    AppendToSerialDataBox($"Number: {deserializedPerson.LuckyNumber}");

                    msgReceived++;
                    msgReceivedLabel.Text = $"PACKETS RECEIVED : {msgReceived}";

                }

                catch (Exception ex)
                {
                    rxErrors++;
                    rxErrorsLabel.Text = $"RX ERRORS : {rxErrors}";
                    MessageBox.Show("Error parsing protobuf data packet :: " + ex.Message, "Error!");
                }

            }
        }

        /// <summary>
        /// Appends data to the serial data box, updating the UI.
        /// </summary>
        /// <param name="data">The data to be appended.</param>
        private void AppendToSerialDataBox(string data)
        {
            if (serialDataBox.InvokeRequired)
            {
                // Invoke required if called from a different thread
                serialDataBox.Invoke(new MethodInvoker(() => AppendToSerialDataBox(data)));
            }
            else
            {
                // Append data to the serial data box
                serialDataBox.AppendText(data + Environment.NewLine);
            }
        }


        /// <summary>
        /// Event handler for the Disconnect button click event.
        /// Closes the connection to the serial port and updates the UI.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void button5_Click(object sender, EventArgs e)
        {
            // Disconnect from the serial port
            Program.DisconnectPort();

            // Update UI elements to indicate disconnection
            serialConnectivityLabel.Text = "Disconnected";
            serialConnectivityLabel.ForeColor = Color.Red;
            connectedLed.Color = Color.Red;
        }


        //------------------------------------------FIN SERIAL PORT----------------------------------------------------------------------------//


        //------------------------------------------UI-----------------------------------------------------------------------------------------//

        /// <summary>
        /// This method is called when the Form is first loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //Setup graphs
            SetupGraphAccelero();
            SetupGraphAltitude();

        }


        /// <summary>
        /// Sets up the Accelerometer graph styles and limits.
        /// </summary>
        private void SetupGraphAccelero()
        {
            acceleroPlot.Plot.Axes.Left.Label.Text = "Accelerometers (M/S²)";
            acceleroPlot.Plot.Axes.Left.IsVisible = true;
            acceleroPlot.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("163020");
            acceleroPlot.Plot.DataBackground.Color = ScottPlot.Color.FromHex("304D30");
            acceleroPlot.Plot.Axes.Color(ScottPlot.Color.FromHex("C6A969"));
            acceleroPlot.Plot.Axes.AutoScale();
            acceleroPlot.Interaction.Disable();
            

            //Adding sample data
            var sigX = acceleroPlot.Plot.Add.Signal(Generate.Sin(25, phase: .3));
            var sigY = acceleroPlot.Plot.Add.Signal(Generate.Sin(25, phase: .6));
            var sigZ = acceleroPlot.Plot.Add.Signal(Generate.Sin(25, phase: .9));

            sigX.Label = "X";
            sigY.Label = "Y";
            sigZ.Label = "Z";

            acceleroPlot.Plot.Legend.IsVisible = true;
            acceleroPlot.Plot.Legend.Orientation = ScottPlot.Orientation.Horizontal;
            acceleroPlot.Plot.Legend.OutlineStyle.Color = ScottPlot.Color.FromHex("C6A969");
            acceleroPlot.Plot.Legend.BackgroundFill.Color = ScottPlot.Color.FromHex("304D30");
            acceleroPlot.Plot.Legend.Font.Color = ScottPlot.Color.FromHex("C6A969");
        }

        /// <summary>
        /// Sets up the Altitude graph styles and limits.
        /// </summary>
        private void SetupGraphAltitude()
        {
            altitudePlot.Plot.Axes.Left.Label.Text = "Altitude (M)";
            altitudePlot.Plot.Axes.Left.IsVisible = true;
            altitudePlot.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("163020");
            altitudePlot.Plot.DataBackground.Color = ScottPlot.Color.FromHex("304D30");
            altitudePlot.Plot.Axes.Color(ScottPlot.Color.FromHex("C6A969"));
            altitudePlot.Plot.Axes.AutoScale();
            SetGraphsBehaviors(altitudePlot);
            SetGraphsBehaviors(acceleroPlot);


            


            double[] x = new double[239];
            double[] y = new double[239];
            for (int i = 0; i < 239; i++)
            {
                x[i] = i;
                y[i] = -(0.0453337 * Math.Pow(i, 2)) + 2.26424 * i + 1878.92;
            }


            var alt = altitudePlot.Plot.Add.Scatter(x, y);

        }




        /// <summary>
        /// Sets custom bindings when the mouse is inside a graph. 
        /// Left click to drag, right click to open contextual menu, middle click to resize
        /// </summary>
        private void SetGraphsBehaviors(ScottPlot.IPlotControl plot)
        {

            ScottPlot.Control.InputBindings inputBindings = new()
            {
                DragPanButton = ScottPlot.Control.MouseButton.Left,
                ZoomInWheelDirection = ScottPlot.Control.MouseWheelDirection.Up,
                ZoomOutWheelDirection = ScottPlot.Control.MouseWheelDirection.Down,
                ClickAutoAxisButton = ScottPlot.Control.MouseButton.Middle,
                ClickContextMenuButton = ScottPlot.Control.MouseButton.Right,
            };

            ScottPlot.Control.Interaction interaction = new(plot)
            {
                Inputs = inputBindings,
            };

            plot.Interaction = interaction;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }




        //------------------------------------------FIN UI-------------------------------------------------------------------------------------//
    }
}