using Color = System.Drawing.Color;
using GMap.NET;
using GMap.NET.WindowsForms;
using System.IO.Ports;
using ScottPlot;
using GCS_Phoenix.Communication;
using GCS_Phoenix.Exception;
using System.Text;
using GCS_Phoenix.Communication.Packet;
using GCS_Phoenix.Models.Sensors;
using CsvHelper;
using System.Globalization;

namespace GCS_Phoenix
{
	public partial class DashboardForm : Form
	{
		private readonly string cachePath = Directory.GetCurrentDirectory() + "\\Cache";
		private GMapOverlay markersOverlay = new GMapOverlay("marker1");

		private SerialPortManager serialPortManager;

		private List<byte> uartBuffer = new List<byte>();

		private readonly string csvPath = Directory.GetCurrentDirectory() + "\\Data";

		private List<AccelerometerModel> accelerometerDataList = new List<AccelerometerModel>();
		private List<AltimeterModel> altimeterDataList = new List<AltimeterModel>();
		private List<GyroscopeModel> gyroscopeDataList = new List<GyroscopeModel>();
		private List<GPSModel> gpsDataList = new List<GPSModel>();
		private List<ThermocoupleModel> thermocoupleDataList = new List<ThermocoupleModel>();

		public DashboardForm()
		{
			InitializeComponent();
			InitializeMap();
			InitializeComPort();

			//TODO remove when we start to receive real values and move into another method.
			AddPointToMap(5, 5);
			if (!Directory.Exists(csvPath))
			{
				Directory.CreateDirectory(csvPath);
			}
    }

    private void SerialPortManager_DataReceived(object? sender, byte[] data)
    {
			string displayText = "";
			if (data is null || data.Length <= 0)
			{
				return;
			}

			for (int i = 0; i < data.Length - 3; i++)
			{
			  displayText = "";
			  if (data[i] == 0x5AU && data[i + 1] == 0xA5U && data[i + 3] == 0xA5U)
				{
					switch (data[i + 2])
					{
						case (byte)0x10U:
							if (data.Length - (i + 3) > 8)
							{
								byte[] accelerometerData = { data[i + 4], data[i + 5], data[i + 6], data[i + 7], data[i + 8], data[i + 9], data[i + 10], data[i + 11] };
								AccelerometerPacket packet = new AccelerometerPacket(accelerometerData);

			          displayText += "TimeStamp Accelerometre : " + packet.getTimeStamp_ms() + Environment.NewLine;
			          displayText += "Acceleration X : " + packet.getAccelerationX_g().ToString() + Environment.NewLine;
			          displayText += "Acceleration Y : " + packet.getAccelerationY_g().ToString() + Environment.NewLine;
			          displayText += "Acceleration Z : " + packet.getAccelerationZ_g().ToString() + Environment.NewLine;

								accelerometerDataList.Add(new AccelerometerModel
                {
                  TimeStamp_ms =		packet.getTimeStamp_ms(),
                  AccelerationX_g = packet.getAccelerationX_g(),
                  AccelerationY_g = packet.getAccelerationY_g(),
                  AccelerationZ_g = packet.getAccelerationZ_g()
                });

			        }
							break;
			      case (byte)0x20U:
			        if (data.Length - (i + 3) > 4)
			        {
			          byte[] altimeterData = { data[i + 4], data[i + 5], data[i + 6], data[i + 7] };
			          AltimeterPacket packet = new AltimeterPacket(altimeterData);

			          displayText += "TimeStamp Altimetre : " + packet.getTimeStamp_ms() + Environment.NewLine;
			          displayText += "Altitude : " + packet.getAltitude_m().ToString() + Environment.NewLine;

								altimeterDataList.Add(new AltimeterModel
                {
                  TimeStamp_ms =	packet.getTimeStamp_ms(),
                  Altitude_m =		packet.getAltitude_m()
                });
			        }
			        break;
			      case (byte)0x30U:
			        if (data.Length - (i + 3) > 8)
			        {
			          byte[] gyroscopeData = { data[i + 4], data[i + 5], data[i + 6], data[i + 7], data[i + 8], data[i + 9], data[i + 10], data[i + 11] };
			          GyroscopePacket packet = new GyroscopePacket(gyroscopeData);

			          displayText += "TimeStamp Gyroscope : " + packet.getTimeStamp_ms() + Environment.NewLine;
			          displayText += "Rotation X : " + packet.getRotationX_dps().ToString() + Environment.NewLine;
			          displayText += "Rotation Y : " + packet.getRotationY_dps().ToString() + Environment.NewLine;
			          displayText += "Rotation Z : " + packet.getRotationZ_dps().ToString() + Environment.NewLine;

								gyroscopeDataList.Add(new GyroscopeModel
                {
                  TimeStamp_ms =	packet.getTimeStamp_ms(),
                  RotationX_dps = packet.getRotationX_dps(),
                  RotationY_dps = packet.getRotationY_dps(),
                  RotationZ_dps = packet.getRotationZ_dps()
                });
			        }
			        break;
			      case (byte)0x40U:
			        if (data.Length - (i + 3) > 14)
			        {
			          byte[] gpsData = { data[i + 4], data[i + 5], data[i + 6], data[i + 7], data[i + 8], data[i + 9], data[i + 10], data[i + 11], data[i + 12], data[i + 13], data[i + 14], data[i + 15], data[i + 16], data[i + 17] };
			          GPSPacket packet = new GPSPacket(gpsData);

			          displayText += "TimeStamp GPS : " + packet.getTimeStamp_ms() + Environment.NewLine;
			          displayText += "Latitude : " + packet.getLatitudeFormatted() + Environment.NewLine;
			          displayText += "Longitude : " + packet.getLongitudeFormatted() + Environment.NewLine;

								gpsDataList.Add(new GPSModel
                {
                  TimeStamp_ms =	packet.getTimeStamp_ms(),
									LatitudeDirection = packet.getLatitudeDirection(),
									LatitudeDegrees = packet.getLatitudeDegrees(),
									LatitudeMinutes = packet.getLatitudeMinutes(),
									LongitudeDirection = packet.getLongitudeDirection(),
									LongitudeDegrees = packet.getLongitudeDegrees(),
									LongitudeMinutes = packet.getLongitudeMinutes()
                });
			        }
			        break;
			      case (byte)0x50U:
			        if (data.Length - (i + 3) > 10)
			        {
			          byte[] thermocouplePC0Data = { data[i + 4], data[i + 5], data[i + 6], data[i + 7] };
			          byte[] thermocouplePC1Data = { data[i + 4], data[i + 5], data[i + 8], data[i + 9] };
			          byte[] thermocouplePC2Data = { data[i + 4], data[i + 5], data[i + 10], data[i + 11] };
			          byte[] thermocouplePC3Data = { data[i + 4], data[i + 5], data[i + 12], data[i + 13] };
			          ThermocouplePacket packetPC0 = new ThermocouplePacket(thermocouplePC0Data);
			          ThermocouplePacket packetPC1 = new ThermocouplePacket(thermocouplePC1Data);
			          ThermocouplePacket packetPC2 = new ThermocouplePacket(thermocouplePC2Data);
			          ThermocouplePacket packetPC3 = new ThermocouplePacket(thermocouplePC3Data);

			          displayText += "TimeStamp Thermocouple : " + packetPC0.getTimeStamp_ms() + Environment.NewLine;
			          displayText += "Resistance PC0 : " + packetPC0.getTemperature_C().ToString() + Environment.NewLine;
			          displayText += "Resistance PC1 : " + packetPC1.getTemperature_C().ToString() + Environment.NewLine;
			          displayText += "Resistance PC2 : " + packetPC2.getTemperature_C().ToString() + Environment.NewLine;
			          displayText += "Resistance PC3 : " + packetPC3.getTemperature_C().ToString() + Environment.NewLine;

								thermocoupleDataList.Add(new ThermocoupleModel
                {
                  TimeStamp_ms = packetPC0.getTimeStamp_ms(),
                  Temperature_C = packetPC0.getTemperature_C()
                });
			        }
			        break;
			      default:
							break;
					}
				}
				AppendToSerialDataBox(displayText, addNewLine: false);
			}
			// TODO: Check if new data is available for sensor before opening the file
			using (StreamWriter sw = new StreamWriter(csvPath + "\\AccelerometerData.csv", append: true))
			{
				using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
				{
					cw.Context.RegisterClassMap<AccelerometerMap>();
					if (sw.BaseStream.Length == 0)
					{
						cw.WriteHeader<AccelerometerModel>();
						cw.NextRecord();
					}
					cw.WriteRecords(accelerometerDataList);
					accelerometerDataList.Clear();
				}
			}
			using (StreamWriter sw = new StreamWriter(csvPath + "\\AltimeterData.csv", append: true))
			{
				using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
				{
					cw.Context.RegisterClassMap<AltimeterMap>();
					if (sw.BaseStream.Length == 0)
					{
						cw.WriteHeader<AltimeterModel>();
						cw.NextRecord();
					}
					cw.WriteRecords(altimeterDataList);
					altimeterDataList.Clear();
				}
			}
			using (StreamWriter sw = new StreamWriter(csvPath + "\\GyroscopeData.csv", append: true))
			{
				using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
				{
					cw.Context.RegisterClassMap<GyroscopeMap>();
					if (sw.BaseStream.Length == 0)
					{
						cw.WriteHeader<GyroscopeModel>();
						cw.NextRecord();
					}
					cw.WriteRecords(gyroscopeDataList);
					gyroscopeDataList.Clear();
				}
			}
			using (StreamWriter sw = new StreamWriter(csvPath + "\\GPSData.csv", append: true))
			{
				using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
				{
					cw.Context.RegisterClassMap<GPSMap>();
					if (sw.BaseStream.Length == 0)
					{
						cw.WriteHeader<GPSModel>();
						cw.NextRecord();
					}
					cw.WriteRecords(gpsDataList);
					gpsDataList.Clear();
				}
			}
			using (StreamWriter sw = new StreamWriter(csvPath + "\\ThermocoupleData.csv", append: true))
			{
				using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
				{
					cw.Context.RegisterClassMap<ThermocoupleMap>();
					if (sw.BaseStream.Length == 0)
					{
						cw.WriteHeader<ThermocoupleModel>();
						cw.NextRecord();
					}
					cw.WriteRecords(thermocoupleDataList);
					thermocoupleDataList.Clear();
				}
			}
    }

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

		private void ResetButton_Click(object sender, EventArgs e)
		{
			gMapControl1.Position = new PointLatLng(48.47583, -81.330494);
			gMapControl1.Zoom = 15;
			gMapControl1.Update();
			gMapControl1.Refresh();
		}

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

		private void ConnectSerialButton_Click(object sender, EventArgs e)
		{
			string portName = GetSelectedSerialPort();
			int baudRate = GetSelectedBaudRate();

			serialPortManager = new SerialPortManager(new SerialSettings(portName, baudRate));
      serialPortManager.DataReceived += SerialPortManager_DataReceived;

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
		}

		private void AppendToSerialDataBox(string data, bool addNewLine = true)
		{
			if (serialDataBox.InvokeRequired)
			{
				serialDataBox.Invoke(new MethodInvoker(() => AppendToSerialDataBox(data)));
			}
			else
			{
				if (addNewLine)
				{
          serialDataBox.AppendText(data + Environment.NewLine);
				}
        else
				{
					serialDataBox.Text += data;
				}
			}
		}

		private void DisconnectSerialButton_Click(object sender, EventArgs e)
		{
			serialPortManager.Disconnect();
			serialPortManager.DataReceived -= SerialPortManager_DataReceived;

			serialConnectivityLabel.Text = "Disconnected";
			serialConnectivityLabel.ForeColor = Color.Red;
			connectedLed.Color = Color.Red;
		}

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
	}
}