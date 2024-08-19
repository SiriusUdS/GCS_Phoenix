using Color = System.Drawing.Color;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System.IO.Ports;
using System.Windows.Forms;
using ScottPlot;
using GCS_Phoenix.Communication;
using GCS_Phoenix.Exception;
using GCS_Phoenix.Communication.Packet;
using MissionPlanner.Maps;
using System.Net;
using GMap.NET.WindowsForms.Markers;
using GCS_Phoenix.Managers;
using ScottPlot.Plottables;

namespace GCS_Phoenix
{
  public partial class DashboardForm : Form
  {
    private readonly string cachePath = Directory.GetCurrentDirectory() + "\\Cache";
    private GMapOverlay markersOverlay = new GMapOverlay("marker1");

    private SerialPortManager serialPortManager;

    private List<byte> uartBuffer = new List<byte>();
    private List<GMarkerGoogle> addedMarkers = new List<GMarkerGoogle>();
    private List<GMarkerGoogle> displayedMarkers = new List<GMarkerGoogle>();

    private CsvFileManager csvFileManager = new CsvFileManager();

    private System.Windows.Forms.Timer mainTimer;
    Random random = new Random();

    public DataLogger sigX = new DataLogger();
    public DataLogger sigY = new DataLogger();
    public DataLogger sigZ = new DataLogger();
    public DataLogger alt = new DataLogger();

    public DashboardForm()
    {
      InitializeComponent();
      InitializeMap();
      InitializeComPort();

      mainTimer = new System.Windows.Forms.Timer();
      mainTimer.Interval = 1000;
      mainTimer.Tick += MainTimer_Tick;

      num_markersToDisplay.Enabled = false;
    }

    private void MainTimer_Tick(object sender, EventArgs e)
    {

    }

    private void DashboardForm_FormClosing(object sender, FormClosingEventArgs e)
    {

    }

    private void SerialPortManager_DataReceived(object? sender, byte[] data)
    {
      string displayText = "";
      Serilog.Log.Information("Data received: " + BitConverter.ToString(data));
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

                csvFileManager.AddAccelerometerData(packet);
                Serilog.Log.Information("Decoded accelerometer packet with values:\n" +
                  "\tAcc. X: " + packet.getAccelerationX_g() + "\n" +
                  "\tAcc. Y: " + packet.getAccelerationY_g() + "\n" +
                  "\tAcc. Z: " + packet.getAccelerationZ_g() + "\n" +
                  "\tTimestamp: " + packet.getTimeStamp_ms()
                );

                sigX.Add(packet.getTimeStamp_ms(), packet.getAccelerationX_g());
                sigY.Add(packet.getTimeStamp_ms(), packet.getAccelerationY_g());
                sigZ.Add(packet.getTimeStamp_ms(), packet.getAccelerationZ_g());
                if (acceleroPlot.InvokeRequired)
                {
                  acceleroPlot.Invoke(new Action(() => acceleroPlot.Refresh()));
                }
                else
                {
                  acceleroPlot.Refresh();
                }
              }
              break;
            case (byte)0x20U:
              if (data.Length - (i + 3) > 4)
              {
                byte[] altimeterData = { data[i + 4], data[i + 5], data[i + 6], data[i + 7] };
                AltimeterPacket packet = new AltimeterPacket(altimeterData);

                displayText += "TimeStamp Altimetre : " + packet.getTimeStamp_ms() + Environment.NewLine;
                displayText += "Altitude : " + packet.getAltitude_m().ToString() + Environment.NewLine;

                csvFileManager.AddAltimeterData(packet);
                Serilog.Log.Information("Decoded altimeter packet with values:\n" +
                  "\tAltitude: " + packet.getAltitude_m() + "\n" +
                  "\tTimestamp: " + packet.getTimeStamp_ms()
                );

                alt.Add(packet.getTimeStamp_ms(), packet.getAltitude_m());
                if (altitudePlot.InvokeRequired)
                {
                  altitudePlot.Invoke(new Action(() => altitudePlot.Refresh()));
                }
                else
                {
                  altitudePlot.Refresh();
                }
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

                csvFileManager.AddGyroscopeData(packet);
                Serilog.Log.Information("Decoded gyroscope packet with values:\n" +
                  "\tRot. X: " + packet.getRotationX_dps() + "\n" +
                  "\tRot. Y: " + packet.getRotationY_dps() + "\n" +
                  "\tRot. Z: " + packet.getRotationZ_dps() + "\n" +
                  "\tTimestamp: " + packet.getTimeStamp_ms()
                );
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

                AddPointToMap(packet);

                csvFileManager.AddGPSData(packet);
                Serilog.Log.Information("Decoded GPS packet with values:\n" +
                  "\tLatitude: " + packet.getLatitudeFormatted() + "\n" +
                  "\tLongitude: " + packet.getLongitudeFormatted() + "\n" +
                  "\tTimestamp: " + packet.getTimeStamp_ms()
                );
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

                //csvFileManager.AddThermocoupleData(packetPC0);
                //csvFileManager.AddThermocoupleData(packetPC1);
                //csvFileManager.AddThermocoupleData(packetPC2);
                csvFileManager.AddThermocoupleData(packetPC3);
                Serilog.Log.Information("Decoded thermocouple PC0 packet with values:\n" +
                  "\tTemperature: " + packetPC0.getTemperature_C() + "\n" +
                  "\tTimestamp: " + packetPC0.getTimeStamp_ms()
                );
                Serilog.Log.Information("Decoded thermocouple PC1 packet with values:\n" +
                  "\tTemperature: " + packetPC1.getTemperature_C() + "\n" +
                  "\tTimestamp: " + packetPC1.getTimeStamp_ms()
                );
                Serilog.Log.Information("Decoded thermocouple PC2 packet with values:\n" +
                  "\tTemperature: " + packetPC2.getTemperature_C() + "\n" +
                  "\tTimestamp: " + packetPC2.getTimeStamp_ms()
                );
                Serilog.Log.Information("Decoded thermocouple PC3 packet with values:\n" +
                  "\tTemperature: " + packetPC3.getTemperature_C() + "\n" +
                  "\tTimestamp: " + packetPC3.getTimeStamp_ms()
                );
              }
              break;
            default:
              break;
          }
        }
        AppendToSerialDataBox(displayText, addNewLine: false);
      }
      // TODO: Check if new data is available for sensor before opening the file
      csvFileManager.WriteDataFiles();
    }

    public void InitializeMap()
    {
      gMapControl1.CacheLocation = cachePath;
      gMapControl1.MapProvider = GMap.NET.MapProviders.GoogleSatelliteMapProvider.Instance;
      gMapControl1.Dock = DockStyle.Fill;
      GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
      //GMaps.Instance.Mode = AccessMode.CacheOnly; // Change ServerAndCahe to Cache only for offline use
      gMapControl1.ShowCenter = false;
      gMapControl1.MinZoom = 1;
      gMapControl1.MaxZoom = 20;
      gMapControl1.Zoom = 15;
      //gMapControl1.Position = new GMap.NET.PointLatLng(48.486483, -81.328833);
      gMapControl1.Position = new GMap.NET.PointLatLng(47.989111, -81.853388);
    }

    public void SetupData()
    {
      alt = altitudePlot.Plot.Add.DataLogger();
      sigX = acceleroPlot.Plot.Add.DataLogger();
      sigY = acceleroPlot.Plot.Add.DataLogger();
      sigZ = acceleroPlot.Plot.Add.DataLogger();

      sigX.LegendText = "X";
      sigY.LegendText = "Y";
      sigZ.LegendText = "Z";

      alt.ViewFull();
      sigX.ViewFull();
      sigY.ViewFull();
      sigZ.ViewFull();
    }

    public void updateMapMarkers()
    {
      markersOverlay.Markers.Clear();
      int adjustedNumberToDisplay = (int)num_markersToDisplay.Value;
      if (num_markersToDisplay.Value > addedMarkers.Count)
      {
        adjustedNumberToDisplay = addedMarkers.Count;
      }
      displayedMarkers = addedMarkers.GetRange(addedMarkers.Count - adjustedNumberToDisplay, adjustedNumberToDisplay);
      //displayedMarkers = addedMarkers.GetRange(addedMarkers.Count - (int)num_markersToDisplay.Value, (int)num_markersToDisplay.Value);
      if (rb_onlyLastXMarkers.Checked)
      {
        foreach (GMarkerGoogle marker in displayedMarkers)
        {
          markersOverlay.Markers.Add(marker);
        }
      }
      else
      {
        foreach (GMarkerGoogle marker in addedMarkers)
        {
          markersOverlay.Markers.Add(marker);
        }
      }
      gMapControl1.Overlays.Add(markersOverlay);
      gMapControl1.Update();
      gMapControl1.Refresh();
    }

    public void AddPointToMap(GPSPacket gpsPacket)
    {
      if (gMapControl1.InvokeRequired)
      {
        gMapControl1.Invoke(new Action(() => AddPointToMap(gpsPacket)));
        return;
      }
      double latitude = gpsPacket.getLatitudeValuesDegrees();
      double longitude = gpsPacket.getLongitudeValuesDegrees();
      GMarkerGoogle marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
        new PointLatLng(latitude, longitude),
        GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_dot
      );
      marker.ToolTipText = string.Format($"Latitude: {latitude}, Longitude: {longitude}");
      addedMarkers.Add(marker);
      //displayedMarkers = addedMarkers.GetRange(addedMarkers.Count - (int)num_markersToDisplay.Value, (int)num_markersToDisplay.Value);
      //markersOverlay.Markers.Add(marker);
      if (gMapControl1.InvokeRequired)
      {
        gMapControl1.Invoke(new Action(() => AddPointToMap(gpsPacket)));
      }
      else
      {
        gMapControl1.Position = new PointLatLng(latitude, longitude);
        //gMapControl1.Overlays.Add(markersOverlay);
        //gMapControl1.Update();
        //gMapControl1.Refresh();
        updateMapMarkers();
      }
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

      string customDataOutputFolderName = Microsoft.VisualBasic.Interaction.InputBox("Custom folder name for flight data:",
                       "Custom folder name",
                       DateTime.Now.ToString("yyyy-MM-dd HHmmss"),
                       0,
                       0);
      csvFileManager.CsvSessionFolderName = customDataOutputFolderName;
      csvFileManager.Initialize();
      Serilog.Log.Information($"Custom folder name for flight data: {customDataOutputFolderName}");

      serialPortManager = new SerialPortManager(new SerialSettings(portName, baudRate));
      serialPortManager.DataReceived += SerialPortManager_DataReceived;

      try
      {
        serialPortManager.Connect();
        serialConnectivityLabel.Text = "Connected";
        serialConnectivityLabel.ForeColor = Color.Green;
        connectedLed.Color = Color.Green;
        disconnectSerialButton.Enabled = true;
        comboPorts.Enabled = false;
        comboBaud.Enabled = false;
        btn_clearFlash.Enabled = true;
        btn_igniteSmoke.Enabled = true;
        btn_readFlash.Enabled = true;
        btn_saveDataOff.Enabled = true;
        btn_saveDataOn.Enabled = true;
        btn_gatherDataOff.Enabled = true;
        btn_gatherDataOn.Enabled = true;
        Serilog.Log.Information($"Serial port connected to port: {portName} with baud rate: {baudRate}.");
      }
      catch (CannotConnectSerialPortException ex)
      {
        MessageBox.Show("Error connecting to serial port: " + Environment.NewLine + ex.Message, "Error!");
      }
    }

    private void AppendToSerialDataBox(string data, bool addNewLine = true)
    {
      if (!chk_displayInConsole.Checked)
      {
        return; 
      }
      if (data == null || data.Length <= 0)
      {
        return;
      }
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
      disconnectSerialButton.Enabled = false;
      connectSerialButton.Enabled = true;
      comboPorts.Enabled = true;
      comboBaud.Enabled = true;
      btn_clearFlash.Enabled = false;
      btn_igniteSmoke.Enabled = false;
      btn_readFlash.Enabled = false;
      btn_saveDataOff.Enabled = false;
      btn_saveDataOn.Enabled = false;
      btn_gatherDataOff.Enabled = false;
      btn_gatherDataOn.Enabled = false;
      Serilog.Log.Information("Serial port disconnected.");
    }

    private void DashboardForm_Load(object sender, EventArgs e)
    {
      SetupGraphAccelero();
      SetupGraphAltitude();
      SetupData();
    }

    private void SetupGraphAccelero()
    {
      acceleroPlot.Plot.Axes.Left.Label.Text = "Accelerometers (M/S�)";
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

    private void SetupGraphAltitude()
    {
      altitudePlot.Plot.Axes.Left.Label.Text = "Altitude (M)";
      altitudePlot.Plot.Axes.Left.IsVisible = true;
      altitudePlot.Plot.FigureBackground.Color = ScottPlot.Color.FromHex("163020");
      altitudePlot.Plot.DataBackground.Color = ScottPlot.Color.FromHex("304D30");
      altitudePlot.Plot.Axes.Color(ScottPlot.Color.FromHex("C6A969"));
      altitudePlot.Plot.Axes.AutoScale();
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

    private void comboPorts_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboPorts.SelectedItem == null || comboPorts.GetItemText(comboPorts.SelectedItem) == String.Empty)
      {
        return;
      }
      if (comboBaud.SelectedItem == null || comboBaud.GetItemText(comboBaud.SelectedItem) == String.Empty)
      {
        return;
      }
      connectSerialButton.Enabled = true;
    }

    private void comboBaud_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (comboPorts.SelectedItem == null || comboPorts.GetItemText(comboPorts.SelectedItem) == String.Empty)
      {
        return;
      }
      if (comboBaud.SelectedItem == null || comboBaud.GetItemText(comboBaud.SelectedItem) == String.Empty)
      {
        return;
      }
      connectSerialButton.Enabled = true;
    }

    private void btn_readFlash_Click(object sender, EventArgs e)
    {
      //byte[] command = { 0xA5, 0x80, 0x00, 0x00, 0x00, 0x00 };
      //byte[] command = { 0x80, 0xA5, 0x00, 0x00, 0x00, 0x00 };

      //serialPortManager.Write(command, command.Length);
      serialPortManager.Write("f");
      Serilog.Log.Information("Read flash memory command sent.");
    }

    private void btn_clearFlash_Click(object sender, EventArgs e)
    {
      //byte[] command = { 0xA5, 0x81, 0x00, 0x01, 0x00, 0x01 };
      //byte[] command = { 0x81, 0xA5, 0x01, 0x00, 0x01, 0x00 };

      DialogResult result = MessageBox.Show("Are you sure you want to DELETE ALL STORED DATA ?",
                                            "WARNING",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

      if (result == DialogResult.Yes)
      {
        //serialPortManager.Write(command, command.Length);
        serialPortManager.Write("c");
      }
      Serilog.Log.Information("Clear flash memory command sent.");
    }

    private async void btn_igniteSmoke_Click(object sender, EventArgs e)
    {
      //byte[] command = { 0xA5, 0x10, 0x00, 0x01, 0x00, 0x01 };
      //byte[] command = { 0x10, 0xA5, 0x01, 0x00, 0x01, 0x00 };

      DialogResult result = MessageBox.Show("Are you sure you want to IGNITE THE SMOKE BOMB ?",
                                            "WARNING",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);

      if (result == DialogResult.Yes)
      {
        for (int i = 0; i < 5; i++)
        {
          serialPortManager.Write("s");
          await Task.Delay(1000);
        }
      }
      Serilog.Log.Information("Ignite smoke bomb command sent.");
    }

    private void btn_saveDataOn_Click(object sender, EventArgs e)
    {
      //byte[] command = { 0xA5, 0x20, 0x00, 0x01, 0x00, 0x01 };
      //byte[] command = { 0x82, 0xA5, 0x01, 0x00, 0x01, 0x00 };

      //serialPortManager.Write(command, command.Length);
      serialPortManager.Write("p");
      Serilog.Log.Information("Save data = on command sent.");
    }

    private void btn_saveDataOff_Click(object sender, EventArgs e)
    {
      //byte[] command = { 0xA5, 0x82, 0x00, 0x01, 0x00, 0x00 };
      //byte[] command = { 0x82, 0xA5, 0x01, 0x00, 0x00, 0x00 };

      //serialPortManager.Write(command, command.Length);
      serialPortManager.Write("P");
      Serilog.Log.Information("Save data = off command sent.");
    }

    private void btn_gatherDataOn_Click(object sender, EventArgs e)
    {
      //byte[] command = { 0x20, 0xA5, 0x01, 0x00, 0x01, 0x00 };

      //serialPortManager.Write(command, command.Length);
      serialPortManager.Write("g");
      Serilog.Log.Information("Gather data = on command sent.");
    }

    private void btn_gatherDataOff_Click(object sender, EventArgs e)
    {
      //byte[] command = { 0x20, 0xA5, 0x01, 0x00, 0x00, 0x00 };

      //serialPortManager.Write(command, command.Length);
      serialPortManager.Write("G");
      Serilog.Log.Information("Gather data = off command sent.");
    }

    private void btn_clearSerialConsole_Click(object sender, EventArgs e)
    {
      serialDataBox.Clear();
      Serilog.Log.Information("Serial console cleared.");
    }

    private void rb_graphSlide_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton? radioButton = sender as RadioButton;
      if (radioButton is not null && radioButton.Checked)
      {
        alt.ViewSlide();
        sigX.ViewSlide();
        sigY.ViewSlide();
        sigZ.ViewSlide();
      }
      else
      {
        alt.ViewFull();
        sigX.ViewFull();
        sigY.ViewFull();
        sigZ.ViewFull();
      }
      acceleroPlot.Refresh();
      altitudePlot.Refresh();
    }

    private void rb_graphFull_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton? radioButton = sender as RadioButton;
      if (radioButton is not null && radioButton.Checked)
      {
        alt.ViewFull();
        sigX.ViewFull();
        sigY.ViewFull();
        sigZ.ViewFull();
      }
      else
      {
        alt.ViewSlide();
        sigX.ViewSlide();
        sigY.ViewSlide();
        sigZ.ViewSlide();
      }
      acceleroPlot.Refresh();
      altitudePlot.Refresh();
    }

    private void rb_onlyLastXMarkers_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton? radioButton = sender as RadioButton;
      if (radioButton is not null && radioButton.Checked)
      {
        num_markersToDisplay.Enabled = true;
        int adjustedNumberToDisplay = (int)num_markersToDisplay.Value;
        if (num_markersToDisplay.Value > addedMarkers.Count)
        {
          adjustedNumberToDisplay = addedMarkers.Count;
        }
        displayedMarkers = addedMarkers.GetRange(addedMarkers.Count - adjustedNumberToDisplay, adjustedNumberToDisplay);
      }
    }

    private void rb_allMarkers_CheckedChanged(object sender, EventArgs e)
    {
      RadioButton? radioButton = sender as RadioButton;
      if (radioButton is not null && radioButton.Checked)
      {
        num_markersToDisplay.Enabled = false;
      }
    }

    private void num_markersToDisplay_ValueChanged(object sender, EventArgs e)
    {
      NumericUpDown? numericUpDown = sender as NumericUpDown;
      if (numericUpDown is null)
      {
        return;
      }
      int adjustedNumberToDisplay = (int)num_markersToDisplay.Value;
      if (num_markersToDisplay.Value > addedMarkers.Count)
      {
        adjustedNumberToDisplay = addedMarkers.Count;
      }
      displayedMarkers = addedMarkers.GetRange(addedMarkers.Count - adjustedNumberToDisplay, adjustedNumberToDisplay);
      //displayedMarkers = addedMarkers.GetRange(addedMarkers.Count - (int)numericUpDown.Value, (int)numericUpDown.Value);
    }
  }
}