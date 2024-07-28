using ScottPlot.WinForms;
using Color = System.Drawing.Color;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.IO.Ports;
using ScottPlot;
using System.Data;
using System.Xml;
using System;
using GCS_Phoenix.Communication;

namespace GCS_Phoenix
{
	public partial class DashboardForm : Form
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

		private SerialPortManager serialPortManager;

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

		public DashboardForm()
		{
			InitializeComponent();
			InitializeMap();
			InitializeComPort();

			//TODO remove when we start to receive real values and move into another method.
			AddPointToMap(5, 5);
		}

		//------------------------------------------MAP----------------------------------------------------------------------------------------//
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

		private void resetButton_Click(object sender, EventArgs e)
		{
			gMapControl1.Position = new PointLatLng(48.47583, -81.330494);
			gMapControl1.Zoom = 15;
			gMapControl1.Update();
			gMapControl1.Refresh();
		}
		//------------------------------------------FIN MAP------------------------------------------------------------------------------------//


		//------------------------------------------SERIAL PORT--------------------------------------------------------------------------------//
		private void InitializeComPort()
		{
			string[] ports = SerialPort.GetPortNames();

			foreach (string port in ports)
			{
				comboPorts.Items.Add(port);
			}
		}

		public string GetSerialPort()
		{
			try
			{
				string? port = comboPorts.SelectedItem?.ToString();
					
				if (port != null)
					return port;
				else
					return "";
			}
			catch (System.Exception ex)
			{
				MessageBox.Show("Please select a valid serial port. :: " + ex.Message, "Error!");
				return "";
			}
		}

		public int GetBaudRate()
		{
			try
			{
				string? baudString = comboBaud.SelectedItem?.ToString();
					
				if (baudString != null)
					return int.Parse(baudString);
				else
					return 0;
			}
			catch (System.Exception ex)
			{
				MessageBox.Show("Please select the baudrate. :: " + ex.Message, "Error!");
				return 0;
			}
		}

		private void connectSerialButton_Click(object sender, EventArgs e)
		{
			if (Program.ConnectPort())
			{
				SerialPort sp1 = Program.GetSerialPort();

				serialConnectivityLabel.Text = "Connected";
				serialConnectivityLabel.ForeColor = Color.Green;
				connectedLed.Color = Color.Green;

				serialPortManager.Port = sp1;
				//sp1.DataReceived += SerialPort_DataReceived;
				sp1.DataReceived += PB_Sp_DataReceived;
			}
		}

		private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
					
		}

		//private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
		//{
		//  while ((serialPort1.IsOpen) && (serialPort1.BytesToRead > 0))
		//  {
		//    rxString = string.Empty;
		//    try
		//    {
		//      rxString = serialPort1.ReadTo("\r\n");//read line from grbl, discard CR LF
		//      dataProcessing = true;
		//      this.Invoke(new EventHandler(dataRx));//tigger rx process
		//      while ((serialPort1.IsOpen) && (dataProcessing)) ;//wait previous data line processed done
		//    }
		//    catch (Exception errort)
		//    {
		//      mens = "Error reading line from serial port";
		//      ClosePort();
		//      err = errort;
		//      this.Invoke(new EventHandler(logErrorThr));
		//    }
		//  }
		//}

		private void PB_Sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			SerialPort sp = (SerialPort)sender;

			int receivedData;
			receivedData = sp.ReadByte();

			AppendToSerialDataBox(receivedData.ToString());

			_packetSize = receivedData + 1;
			_data = new byte[_packetSize];
			_data[0] = (byte)receivedData;

			for (int i = 1; i < _packetSize; i++)
			{
				byte received = (byte)sp.ReadByte();
				_data[i] = received;
				AppendToSerialDataBox(System.Text.Encoding.ASCII.GetString(_data));
			}

			//using (MemoryStream stream = new MemoryStream(_data))
			//{
			//	try
			//	{
			//		SimpleMessage deserializedPerson = SimpleMessage.Parser.ParseDelimitedFrom(stream);
			//		AppendToSerialDataBox($"Number: {deserializedPerson.LuckyNumber}");

			//		msgReceived++;
			//		msgReceivedLabel.Text = $"PACKETS RECEIVED : {msgReceived}";
			//	}
			//	catch (Exception ex)
			//	{
			//		rxErrors++;
			//		rxErrorsLabel.Text = $"RX ERRORS : {rxErrors}";
			//		MessageBox.Show("Error parsing protobuf data packet :: " + ex.Message, "Error!");
			//	}
			//}
		}

		private void AppendToSerialDataBox(string data)
		{
			if (serialDataBox.InvokeRequired)
			{
				serialDataBox.Invoke(new MethodInvoker(() => AppendToSerialDataBox(data)));
			}
			else
			{
				serialDataBox.AppendText(data + Environment.NewLine);
			}
		}

		private void disconnectSerialButton_Click(object sender, EventArgs e)
		{
			Program.DisconnectPort();
			//serialPortManager.Port

			serialConnectivityLabel.Text = "Disconnected";
			serialConnectivityLabel.ForeColor = Color.Red;
			connectedLed.Color = Color.Red;
		}

		//------------------------------------------FIN SERIAL PORT----------------------------------------------------------------------------//


		//------------------------------------------UI-----------------------------------------------------------------------------------------//

		private void Form1_Load(object sender, EventArgs e)
		{
			SetupGraphAccelero();
			SetupGraphAltitude();
		}

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
	}
}