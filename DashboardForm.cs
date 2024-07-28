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
using GCS_Phoenix.Exception;

namespace GCS_Phoenix
{
	public partial class DashboardForm : Form
	{
		private readonly string cachePath = Directory.GetCurrentDirectory() + "\\Cache";
		private GMapOverlay markersOverlay = new GMapOverlay("marker1");

		private List<DataPoint> _altitude = new List<DataPoint>();
		private List<DataPoint> _accX = new List<DataPoint>();
		private List<DataPoint> _accY = new List<DataPoint>();
		private List<DataPoint> _accZ = new List<DataPoint>();
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

      serialPortManager = new SerialPortManager();
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

		public string GetSelectedSerialPort()
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

		public int GetSelectedBaudRate()
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
			string portName = GetSelectedSerialPort();
			int baudRate = GetSelectedBaudRate();

			serialPortManager.Port.PortName = portName;
      serialPortManager.Port.BaudRate = baudRate;

			try
			{
				serialPortManager.Connect();
        serialConnectivityLabel.Text = "Connected";
        serialConnectivityLabel.ForeColor = Color.Green;
        connectedLed.Color = Color.Green;
      }
			catch (CannotConnectSerialPortException ex)
			{
				MessageBox.Show("Error connecting to serial port: " + Environment.NewLine + ex.Message, "Error!");
			}

   //   if (Program.ConnectPort())
			//{
			//	SerialPort sp1 = Program.GetSerialPort();

			//	serialConnectivityLabel.Text = "Connected";
			//	serialConnectivityLabel.ForeColor = Color.Green;
			//	connectedLed.Color = Color.Green;

			//	serialPortManager.Port = sp1;
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

			serialConnectivityLabel.Text = "Disconnected";
			serialConnectivityLabel.ForeColor = Color.Red;
			connectedLed.Color = Color.Red;
		}

		//------------------------------------------FIN SERIAL PORT----------------------------------------------------------------------------//


		//------------------------------------------UI-----------------------------------------------------------------------------------------//

		private void DashboardForm_Load(object sender, EventArgs e)
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