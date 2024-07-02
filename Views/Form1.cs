using Color = System.Drawing.Color;
using GMap.NET.WindowsForms;
using System.IO.Ports;
using GCS_Phoenix.Controllers;

namespace GCS_Phoenix
{



    public partial class Form1 : Form
    {

        public readonly string cachePath;                                          //Path of the cache folder for the map.
        public GMapOverlay markersOverlay;                                         //Markers overlay for the map.
        public byte[] _data;                                                       //Byte array to store the protobuf message.
        public MapController mapController;                                        //Controller that handles operations on the map.
        public DataController dataController;                                      //Controller that handles the data.

        public int rxErrors = 0;                                                   //Number of reception errors
        public int msgReceived = 0;                                                //Number of messages correctly received
        public int _packetSize = 0;                                                //The size of the receiving packet

        public Form1()
        {
            cachePath = Directory.GetCurrentDirectory() + "\\Cache";
            markersOverlay = new GMapOverlay("marker1");

            InitializeComponent();
            InitializeComPort();
            timer1.Start();

            mapController = new MapController(this, gMapControl1);
            dataController = new DataController(this);


            mapController.InitializeMap();

        }

        /// <summary>
        /// Resets the position of the map when the reset map button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void resetButton_Click(object sender, EventArgs e)
        {
            mapController.ResetMap();
        }
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
        private void connectSerialButton_Click(object sender, EventArgs e)
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
        /// Event handler for the Disconnect button click event.
        /// Closes the connection to the serial port and updates the UI.
        /// </summary>
        /// <param name="sender">The object that raised the event.</param>
        /// <param name="e">The event arguments.</param>
        private void disconnectSerialButton_Click(object sender, EventArgs e)
        {
            // Disconnect from the serial port
            Program.DisconnectPort();

            // Update UI elements to indicate disconnection
            serialConnectivityLabel.Text = "Disconnected";
            serialConnectivityLabel.ForeColor = Color.Red;
            connectedLed.Color = Color.Red;
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
                    PhoenixPacket deserializedPacket = PhoenixPacket.Parser.ParseDelimitedFrom(stream);
                    dataController.InsertDataPacket(deserializedPacket);
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
            SetupGraphGyro();
            SetGraphsBehaviors(altitudePlot);
            SetGraphsBehaviors(acceleroPlot);
            SetGraphsBehaviors(gyroPlot);
            dataController.SetupData();

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



            acceleroPlot.Plot.Legend.IsVisible = true;
            acceleroPlot.Plot.Legend.Orientation = ScottPlot.Orientation.Horizontal;
            acceleroPlot.Plot.Legend.OutlineStyle.Color = ScottPlot.Color.FromHex("C6A969");
            acceleroPlot.Plot.Legend.BackgroundColor = ScottPlot.Color.FromHex("304D30");
            acceleroPlot.Plot.Legend.FontColor = ScottPlot.Color.FromHex("C6A969");
        }

        /// <summary>
        /// Sets up the Accelerometer graph styles and limits.
        /// </summary>
        private void SetupGraphGyro()
        {
            gyroPlot.Plot.Axes.Left.Label.Text = "Gyroscopes (°/s)";
            gyroPlot.Plot.Axes.Left.IsVisible = true;
            gyroPlot.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("163020");
            gyroPlot.Plot.DataBackground.Color = ScottPlot.Color.FromHex("304D30");
            gyroPlot.Plot.Axes.Color(ScottPlot.Color.FromHex("C6A969"));
            gyroPlot.Plot.Axes.AutoScale();
            gyroPlot.Interaction.Disable();



            gyroPlot.Plot.Legend.IsVisible = true;
            gyroPlot.Plot.Legend.Orientation = ScottPlot.Orientation.Horizontal;
            gyroPlot.Plot.Legend.OutlineStyle.Color = ScottPlot.Color.FromHex("C6A969");
            gyroPlot.Plot.Legend.BackgroundColor = ScottPlot.Color.FromHex("304D30");
            gyroPlot.Plot.Legend.FontColor = ScottPlot.Color.FromHex("C6A969");
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



        public static PhoenixPacket GeneratePhoenixPacket()
        {
            Random random = new Random();
            return new PhoenixPacket()
            {
                Lattitude = (float)(random.NextDouble() * (48.5 - 48.4) + 48.4), // Lat 48-49
                Longitude = (float)(random.NextDouble() * (-81.3 - (-81.4)) - 81.4), // Lon -81..-82
                AccelerationX = (float)(random.NextDouble() * (20) - 10), // Accel -10..10
                AccelerationY = (float)(random.NextDouble() * (20) - 10),
                AccelerationZ = (float)(random.NextDouble() * (20) - 10),
                GyroX = (float)(random.NextDouble() * (20) - 10),
                GyroY = (float)(random.NextDouble() * (20) - 10),
                GyroZ = (float)(random.NextDouble() * (20) - 10),
                Altitude = (float)(random.NextDouble() * (20) - 10),
                Temperature = (float)random.NextDouble(),
                DrogueDeployed = random.Next(2) == 1,
                MainDeployed = random.Next(2) == 1,
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dataController.InsertDataPacket(GeneratePhoenixPacket());
        }


        //------------------------------------------FIN UI-------------------------------------------------------------------------------------//
    }
}