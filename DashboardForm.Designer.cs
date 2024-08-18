namespace GCS_Phoenix
{
    partial class DashboardForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
      comboBaud = new ComboBox();
      comboPorts = new ComboBox();
      comPortLabel = new Label();
      baudRateLabel = new Label();
      resetButton = new Button();
      connectSerialButton = new Button();
      serialConnectivityLabel = new Label();
      touchdownLed = new Bulb.LedBulb();
      touchDownLabel = new Label();
      drogueDescentLed = new Bulb.LedBulb();
      drogueDescentLabel = new Label();
      mainDescentLed = new Bulb.LedBulb();
      mainDescentLabel = new Label();
      mainDeployedLed = new Bulb.LedBulb();
      mainDeployedLabel = new Label();
      drogueDeployedLabel = new Label();
      drogueDeployedLed = new Bulb.LedBulb();
      freeFallLabel = new Label();
      freeFallLed = new Bulb.LedBulb();
      apogeeLabel = new Label();
      apogeeLed = new Bulb.LedBulb();
      unpFlightLabel = new Label();
      unpFlightLed = new Bulb.LedBulb();
      poweredFlightLabel = new Label();
      poweredFlightLed = new Bulb.LedBulb();
      liftOffLabel = new Label();
      liftOffLed = new Bulb.LedBulb();
      armedLabel = new Label();
      armedLed = new Bulb.LedBulb();
      safedLabel = new Label();
      safedLed = new Bulb.LedBulb();
      connectedLabel = new Label();
      connectedLed = new Bulb.LedBulb();
      groupBox1 = new GroupBox();
      groupBox2 = new GroupBox();
      disconnectSerialButton = new Button();
      currentStageLabel = new Label();
      gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
      mapGroupBox = new GroupBox();
      groupBox3 = new GroupBox();
      serialDataBox = new RichTextBox();
      acceleroPlot = new ScottPlot.WinForms.FormsPlot();
      altitudePlot = new ScottPlot.WinForms.FormsPlot();
      groupBox4 = new GroupBox();
      msgReceivedLabel = new Label();
      rxErrorsLabel = new Label();
      pictureBox1 = new PictureBox();
      groupBox1.SuspendLayout();
      groupBox2.SuspendLayout();
      mapGroupBox.SuspendLayout();
      groupBox3.SuspendLayout();
      groupBox4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      SuspendLayout();
      // 
      // comboBaud
      // 
      comboBaud.FormattingEnabled = true;
      comboBaud.Items.AddRange(new object[] { "9600", "19200", "38400", "115200", "256000" });
      comboBaud.Location = new Point(16, 117);
      comboBaud.Margin = new Padding(4, 5, 4, 5);
      comboBaud.Name = "comboBaud";
      comboBaud.Size = new Size(198, 40);
      comboBaud.TabIndex = 4;
      comboBaud.SelectedIndexChanged += comboBaud_SelectedIndexChanged;
      // 
      // comboPorts
      // 
      comboPorts.FormattingEnabled = true;
      comboPorts.Location = new Point(17, 47);
      comboPorts.Margin = new Padding(4, 5, 4, 5);
      comboPorts.Name = "comboPorts";
      comboPorts.Size = new Size(198, 40);
      comboPorts.TabIndex = 8;
      comboPorts.SelectedIndexChanged += comboPorts_SelectedIndexChanged;
      // 
      // comPortLabel
      // 
      comPortLabel.AutoSize = true;
      comPortLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      comPortLabel.ForeColor = Color.FromArgb(198, 169, 105);
      comPortLabel.Location = new Point(226, 52);
      comPortLabel.Margin = new Padding(4, 0, 4, 0);
      comPortLabel.Name = "comPortLabel";
      comPortLabel.Size = new Size(132, 32);
      comPortLabel.TabIndex = 9;
      comPortLabel.Text = "COM PORT";
      // 
      // baudRateLabel
      // 
      baudRateLabel.AutoSize = true;
      baudRateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      baudRateLabel.ForeColor = Color.FromArgb(198, 169, 105);
      baudRateLabel.Location = new Point(226, 122);
      baudRateLabel.Margin = new Padding(4, 0, 4, 0);
      baudRateLabel.Name = "baudRateLabel";
      baudRateLabel.Size = new Size(135, 32);
      baudRateLabel.TabIndex = 10;
      baudRateLabel.Text = "BAUD RATE";
      // 
      // resetButton
      // 
      resetButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      resetButton.Location = new Point(647, 697);
      resetButton.Margin = new Padding(4, 5, 4, 5);
      resetButton.Name = "resetButton";
      resetButton.Size = new Size(146, 38);
      resetButton.TabIndex = 12;
      resetButton.Text = "Reset Map";
      resetButton.UseVisualStyleBackColor = true;
      resetButton.Click += ResetButton_Click;
      // 
      // connectSerialButton
      // 
      connectSerialButton.Enabled = false;
      connectSerialButton.ForeColor = SystemColors.ActiveCaptionText;
      connectSerialButton.Location = new Point(17, 193);
      connectSerialButton.Margin = new Padding(4, 5, 4, 5);
      connectSerialButton.Name = "connectSerialButton";
      connectSerialButton.Size = new Size(199, 53);
      connectSerialButton.TabIndex = 13;
      connectSerialButton.Text = "Connect";
      connectSerialButton.UseVisualStyleBackColor = true;
      connectSerialButton.Click += ConnectSerialButton_Click;
      // 
      // serialConnectivityLabel
      // 
      serialConnectivityLabel.AutoSize = true;
      serialConnectivityLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
      serialConnectivityLabel.ForeColor = Color.Red;
      serialConnectivityLabel.Location = new Point(21, 347);
      serialConnectivityLabel.Margin = new Padding(4, 0, 4, 0);
      serialConnectivityLabel.Name = "serialConnectivityLabel";
      serialConnectivityLabel.Size = new Size(213, 45);
      serialConnectivityLabel.TabIndex = 14;
      serialConnectivityLabel.Text = "Disconnected";
      serialConnectivityLabel.TextAlign = ContentAlignment.MiddleCenter;
      // 
      // touchdownLed
      // 
      touchdownLed.Color = Color.Red;
      touchdownLed.ForeColor = SystemColors.Control;
      touchdownLed.Location = new Point(24, 55);
      touchdownLed.Margin = new Padding(4, 5, 4, 5);
      touchdownLed.Name = "touchdownLed";
      touchdownLed.On = true;
      touchdownLed.Size = new Size(34, 38);
      touchdownLed.TabIndex = 15;
      touchdownLed.Text = "LED1";
      // 
      // touchDownLabel
      // 
      touchDownLabel.AutoSize = true;
      touchDownLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      touchDownLabel.ForeColor = Color.FromArgb(198, 169, 105);
      touchDownLabel.Location = new Point(60, 58);
      touchDownLabel.Margin = new Padding(4, 0, 4, 0);
      touchDownLabel.Name = "touchDownLabel";
      touchDownLabel.Size = new Size(137, 32);
      touchDownLabel.TabIndex = 16;
      touchDownLabel.Text = "Touchdown";
      // 
      // drogueDescentLed
      // 
      drogueDescentLed.Color = Color.Red;
      drogueDescentLed.Location = new Point(24, 200);
      drogueDescentLed.Margin = new Padding(4, 5, 4, 5);
      drogueDescentLed.Name = "drogueDescentLed";
      drogueDescentLed.On = true;
      drogueDescentLed.Size = new Size(34, 38);
      drogueDescentLed.TabIndex = 17;
      drogueDescentLed.Text = "ledBulb1";
      // 
      // drogueDescentLabel
      // 
      drogueDescentLabel.AutoSize = true;
      drogueDescentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      drogueDescentLabel.ForeColor = Color.FromArgb(198, 169, 105);
      drogueDescentLabel.Location = new Point(60, 203);
      drogueDescentLabel.Margin = new Padding(4, 0, 4, 0);
      drogueDescentLabel.Name = "drogueDescentLabel";
      drogueDescentLabel.Size = new Size(184, 32);
      drogueDescentLabel.TabIndex = 18;
      drogueDescentLabel.Text = "Drogue descent";
      // 
      // mainDescentLed
      // 
      mainDescentLed.Color = Color.Red;
      mainDescentLed.Location = new Point(24, 103);
      mainDescentLed.Margin = new Padding(4, 5, 4, 5);
      mainDescentLed.Name = "mainDescentLed";
      mainDescentLed.On = true;
      mainDescentLed.Size = new Size(34, 38);
      mainDescentLed.TabIndex = 19;
      mainDescentLed.Text = "ledBulb2";
      // 
      // mainDescentLabel
      // 
      mainDescentLabel.AutoSize = true;
      mainDescentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      mainDescentLabel.ForeColor = Color.FromArgb(198, 169, 105);
      mainDescentLabel.Location = new Point(60, 107);
      mainDescentLabel.Margin = new Padding(4, 0, 4, 0);
      mainDescentLabel.Name = "mainDescentLabel";
      mainDescentLabel.Size = new Size(158, 32);
      mainDescentLabel.TabIndex = 20;
      mainDescentLabel.Text = "Main descent";
      // 
      // mainDeployedLed
      // 
      mainDeployedLed.Color = Color.Red;
      mainDeployedLed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      mainDeployedLed.ForeColor = SystemColors.ActiveCaption;
      mainDeployedLed.Location = new Point(24, 152);
      mainDeployedLed.Margin = new Padding(4, 5, 4, 5);
      mainDeployedLed.Name = "mainDeployedLed";
      mainDeployedLed.On = true;
      mainDeployedLed.Size = new Size(34, 38);
      mainDeployedLed.TabIndex = 21;
      mainDeployedLed.Text = "Gps locked";
      // 
      // mainDeployedLabel
      // 
      mainDeployedLabel.AutoSize = true;
      mainDeployedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      mainDeployedLabel.ForeColor = Color.FromArgb(198, 169, 105);
      mainDeployedLabel.Location = new Point(60, 155);
      mainDeployedLabel.Margin = new Padding(4, 0, 4, 0);
      mainDeployedLabel.Name = "mainDeployedLabel";
      mainDeployedLabel.Size = new Size(175, 32);
      mainDeployedLabel.TabIndex = 22;
      mainDeployedLabel.Text = "Main deployed";
      // 
      // drogueDeployedLabel
      // 
      drogueDeployedLabel.AutoSize = true;
      drogueDeployedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      drogueDeployedLabel.ForeColor = Color.FromArgb(198, 169, 105);
      drogueDeployedLabel.Location = new Point(60, 253);
      drogueDeployedLabel.Margin = new Padding(4, 0, 4, 0);
      drogueDeployedLabel.Name = "drogueDeployedLabel";
      drogueDeployedLabel.Size = new Size(201, 32);
      drogueDeployedLabel.TabIndex = 24;
      drogueDeployedLabel.Text = "Drogue deployed";
      // 
      // drogueDeployedLed
      // 
      drogueDeployedLed.Color = Color.Red;
      drogueDeployedLed.Location = new Point(24, 250);
      drogueDeployedLed.Margin = new Padding(4, 5, 4, 5);
      drogueDeployedLed.Name = "drogueDeployedLed";
      drogueDeployedLed.On = true;
      drogueDeployedLed.Size = new Size(34, 38);
      drogueDeployedLed.TabIndex = 23;
      drogueDeployedLed.Text = "ledBulb1";
      // 
      // freeFallLabel
      // 
      freeFallLabel.AutoSize = true;
      freeFallLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      freeFallLabel.ForeColor = Color.FromArgb(198, 169, 105);
      freeFallLabel.Location = new Point(60, 308);
      freeFallLabel.Margin = new Padding(4, 0, 4, 0);
      freeFallLabel.Name = "freeFallLabel";
      freeFallLabel.Size = new Size(99, 32);
      freeFallLabel.TabIndex = 26;
      freeFallLabel.Text = "Free fall";
      // 
      // freeFallLed
      // 
      freeFallLed.Color = Color.Red;
      freeFallLed.Location = new Point(24, 305);
      freeFallLed.Margin = new Padding(4, 5, 4, 5);
      freeFallLed.Name = "freeFallLed";
      freeFallLed.On = true;
      freeFallLed.Size = new Size(34, 38);
      freeFallLed.TabIndex = 25;
      freeFallLed.Text = "ledBulb1";
      // 
      // apogeeLabel
      // 
      apogeeLabel.AutoSize = true;
      apogeeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      apogeeLabel.ForeColor = Color.FromArgb(198, 169, 105);
      apogeeLabel.Location = new Point(60, 363);
      apogeeLabel.Margin = new Padding(4, 0, 4, 0);
      apogeeLabel.Name = "apogeeLabel";
      apogeeLabel.Size = new Size(97, 32);
      apogeeLabel.TabIndex = 28;
      apogeeLabel.Text = "Apogee";
      // 
      // apogeeLed
      // 
      apogeeLed.Color = Color.Red;
      apogeeLed.Location = new Point(24, 360);
      apogeeLed.Margin = new Padding(4, 5, 4, 5);
      apogeeLed.Name = "apogeeLed";
      apogeeLed.On = true;
      apogeeLed.Size = new Size(34, 38);
      apogeeLed.TabIndex = 27;
      apogeeLed.Text = "ledBulb1";
      // 
      // unpFlightLabel
      // 
      unpFlightLabel.AutoSize = true;
      unpFlightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      unpFlightLabel.ForeColor = Color.FromArgb(198, 169, 105);
      unpFlightLabel.Location = new Point(60, 418);
      unpFlightLabel.Margin = new Padding(4, 0, 4, 0);
      unpFlightLabel.Name = "unpFlightLabel";
      unpFlightLabel.Size = new Size(200, 32);
      unpFlightLabel.TabIndex = 30;
      unpFlightLabel.Text = "Unpowered flight";
      // 
      // unpFlightLed
      // 
      unpFlightLed.Color = Color.Red;
      unpFlightLed.Location = new Point(24, 415);
      unpFlightLed.Margin = new Padding(4, 5, 4, 5);
      unpFlightLed.Name = "unpFlightLed";
      unpFlightLed.On = true;
      unpFlightLed.Size = new Size(34, 38);
      unpFlightLed.TabIndex = 29;
      unpFlightLed.Text = "ledBulb1";
      // 
      // poweredFlightLabel
      // 
      poweredFlightLabel.AutoSize = true;
      poweredFlightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      poweredFlightLabel.ForeColor = Color.FromArgb(198, 169, 105);
      poweredFlightLabel.Location = new Point(60, 468);
      poweredFlightLabel.Margin = new Padding(4, 0, 4, 0);
      poweredFlightLabel.Name = "poweredFlightLabel";
      poweredFlightLabel.Size = new Size(168, 32);
      poweredFlightLabel.TabIndex = 32;
      poweredFlightLabel.Text = "Powered flight";
      // 
      // poweredFlightLed
      // 
      poweredFlightLed.Color = Color.Red;
      poweredFlightLed.Location = new Point(24, 465);
      poweredFlightLed.Margin = new Padding(4, 5, 4, 5);
      poweredFlightLed.Name = "poweredFlightLed";
      poweredFlightLed.On = true;
      poweredFlightLed.Size = new Size(34, 38);
      poweredFlightLed.TabIndex = 31;
      poweredFlightLed.Text = "ledBulb1";
      // 
      // liftOffLabel
      // 
      liftOffLabel.AutoSize = true;
      liftOffLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      liftOffLabel.ForeColor = Color.FromArgb(198, 169, 105);
      liftOffLabel.Location = new Point(60, 520);
      liftOffLabel.Margin = new Padding(4, 0, 4, 0);
      liftOffLabel.Name = "liftOffLabel";
      liftOffLabel.Size = new Size(77, 32);
      liftOffLabel.TabIndex = 34;
      liftOffLabel.Text = "Liftoff";
      // 
      // liftOffLed
      // 
      liftOffLed.Color = Color.Red;
      liftOffLed.Location = new Point(24, 517);
      liftOffLed.Margin = new Padding(4, 5, 4, 5);
      liftOffLed.Name = "liftOffLed";
      liftOffLed.On = true;
      liftOffLed.Size = new Size(34, 38);
      liftOffLed.TabIndex = 33;
      liftOffLed.Text = "ledBulb1";
      // 
      // armedLabel
      // 
      armedLabel.AutoSize = true;
      armedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      armedLabel.ForeColor = Color.FromArgb(198, 169, 105);
      armedLabel.Location = new Point(60, 570);
      armedLabel.Margin = new Padding(4, 0, 4, 0);
      armedLabel.Name = "armedLabel";
      armedLabel.Size = new Size(85, 32);
      armedLabel.TabIndex = 36;
      armedLabel.Text = "Armed";
      // 
      // armedLed
      // 
      armedLed.Color = Color.Red;
      armedLed.Location = new Point(24, 567);
      armedLed.Margin = new Padding(4, 5, 4, 5);
      armedLed.Name = "armedLed";
      armedLed.On = true;
      armedLed.Size = new Size(34, 38);
      armedLed.TabIndex = 35;
      armedLed.Text = "ledBulb1";
      // 
      // safedLabel
      // 
      safedLabel.AutoSize = true;
      safedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      safedLabel.ForeColor = Color.FromArgb(198, 169, 105);
      safedLabel.Location = new Point(60, 625);
      safedLabel.Margin = new Padding(4, 0, 4, 0);
      safedLabel.Name = "safedLabel";
      safedLabel.Size = new Size(74, 32);
      safedLabel.TabIndex = 38;
      safedLabel.Text = "Safed";
      // 
      // safedLed
      // 
      safedLed.Color = Color.Red;
      safedLed.Location = new Point(24, 622);
      safedLed.Margin = new Padding(4, 5, 4, 5);
      safedLed.Name = "safedLed";
      safedLed.On = true;
      safedLed.Size = new Size(34, 38);
      safedLed.TabIndex = 37;
      safedLed.Text = "ledBulb1";
      // 
      // connectedLabel
      // 
      connectedLabel.AutoSize = true;
      connectedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      connectedLabel.ForeColor = Color.FromArgb(198, 169, 105);
      connectedLabel.Location = new Point(60, 680);
      connectedLabel.Margin = new Padding(4, 0, 4, 0);
      connectedLabel.Name = "connectedLabel";
      connectedLabel.Size = new Size(130, 32);
      connectedLabel.TabIndex = 40;
      connectedLabel.Text = "Connected";
      // 
      // connectedLed
      // 
      connectedLed.Color = Color.Red;
      connectedLed.Location = new Point(24, 677);
      connectedLed.Margin = new Padding(4, 5, 4, 5);
      connectedLed.Name = "connectedLed";
      connectedLed.On = true;
      connectedLed.Size = new Size(34, 38);
      connectedLed.TabIndex = 39;
      connectedLed.Text = "ledBulb1";
      // 
      // groupBox1
      // 
      groupBox1.Controls.Add(connectedLabel);
      groupBox1.Controls.Add(connectedLed);
      groupBox1.Controls.Add(safedLabel);
      groupBox1.Controls.Add(safedLed);
      groupBox1.Controls.Add(armedLabel);
      groupBox1.Controls.Add(armedLed);
      groupBox1.Controls.Add(liftOffLabel);
      groupBox1.Controls.Add(liftOffLed);
      groupBox1.Controls.Add(poweredFlightLabel);
      groupBox1.Controls.Add(poweredFlightLed);
      groupBox1.Controls.Add(unpFlightLabel);
      groupBox1.Controls.Add(unpFlightLed);
      groupBox1.Controls.Add(apogeeLabel);
      groupBox1.Controls.Add(apogeeLed);
      groupBox1.Controls.Add(freeFallLabel);
      groupBox1.Controls.Add(freeFallLed);
      groupBox1.Controls.Add(drogueDeployedLabel);
      groupBox1.Controls.Add(drogueDeployedLed);
      groupBox1.Controls.Add(mainDeployedLabel);
      groupBox1.Controls.Add(mainDeployedLed);
      groupBox1.Controls.Add(mainDescentLabel);
      groupBox1.Controls.Add(mainDescentLed);
      groupBox1.Controls.Add(drogueDescentLabel);
      groupBox1.Controls.Add(drogueDescentLed);
      groupBox1.Controls.Add(touchDownLabel);
      groupBox1.Controls.Add(touchdownLed);
      groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      groupBox1.ForeColor = Color.FromArgb(198, 169, 105);
      groupBox1.Location = new Point(19, 560);
      groupBox1.Margin = new Padding(4, 5, 4, 5);
      groupBox1.Name = "groupBox1";
      groupBox1.Padding = new Padding(4, 5, 4, 5);
      groupBox1.Size = new Size(390, 748);
      groupBox1.TabIndex = 41;
      groupBox1.TabStop = false;
      groupBox1.Text = "STATUS";
      // 
      // groupBox2
      // 
      groupBox2.Controls.Add(disconnectSerialButton);
      groupBox2.Controls.Add(serialConnectivityLabel);
      groupBox2.Controls.Add(connectSerialButton);
      groupBox2.Controls.Add(baudRateLabel);
      groupBox2.Controls.Add(comPortLabel);
      groupBox2.Controls.Add(comboPorts);
      groupBox2.Controls.Add(comboBaud);
      groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      groupBox2.ForeColor = Color.FromArgb(198, 169, 105);
      groupBox2.Location = new Point(1253, 893);
      groupBox2.Margin = new Padding(4, 5, 4, 5);
      groupBox2.Name = "groupBox2";
      groupBox2.Padding = new Padding(4, 5, 4, 5);
      groupBox2.Size = new Size(356, 415);
      groupBox2.TabIndex = 42;
      groupBox2.TabStop = false;
      groupBox2.Text = "SERIAL";
      // 
      // disconnectSerialButton
      // 
      disconnectSerialButton.Enabled = false;
      disconnectSerialButton.ForeColor = SystemColors.ActiveCaptionText;
      disconnectSerialButton.Location = new Point(17, 268);
      disconnectSerialButton.Margin = new Padding(4, 5, 4, 5);
      disconnectSerialButton.Name = "disconnectSerialButton";
      disconnectSerialButton.Size = new Size(199, 53);
      disconnectSerialButton.TabIndex = 15;
      disconnectSerialButton.Text = "Disconnect";
      disconnectSerialButton.UseVisualStyleBackColor = true;
      disconnectSerialButton.Click += DisconnectSerialButton_Click;
      // 
      // currentStageLabel
      // 
      currentStageLabel.AutoSize = true;
      currentStageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      currentStageLabel.ForeColor = Color.FromArgb(198, 169, 105);
      currentStageLabel.Location = new Point(9, 55);
      currentStageLabel.Margin = new Padding(4, 0, 4, 0);
      currentStageLabel.Name = "currentStageLabel";
      currentStageLabel.Size = new Size(222, 32);
      currentStageLabel.TabIndex = 43;
      currentStageLabel.Text = "CURRENT STAGE : 0";
      // 
      // gMapControl1
      // 
      gMapControl1.Bearing = 0F;
      gMapControl1.CanDragMap = true;
      gMapControl1.EmptyTileColor = Color.Navy;
      gMapControl1.GrayScaleMode = false;
      gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
      gMapControl1.LevelsKeepInMemory = 5;
      gMapControl1.Location = new Point(320, 142);
      gMapControl1.Margin = new Padding(4, 5, 4, 5);
      gMapControl1.MarkersEnabled = true;
      gMapControl1.MaxZoom = 2;
      gMapControl1.MinZoom = 2;
      gMapControl1.MouseWheelZoomEnabled = true;
      gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
      gMapControl1.Name = "gMapControl1";
      gMapControl1.NegativeMode = false;
      gMapControl1.PolygonsEnabled = true;
      gMapControl1.RetryLoadTile = 0;
      gMapControl1.RoutesEnabled = true;
      gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
      gMapControl1.SelectedAreaFillColor = Color.FromArgb(33, 65, 105, 225);
      gMapControl1.ShowTileGridLines = false;
      gMapControl1.Size = new Size(420, 377);
      gMapControl1.TabIndex = 46;
      gMapControl1.Zoom = 0D;
      // 
      // mapGroupBox
      // 
      mapGroupBox.Controls.Add(resetButton);
      mapGroupBox.Controls.Add(gMapControl1);
      mapGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      mapGroupBox.ForeColor = Color.FromArgb(198, 169, 105);
      mapGroupBox.Location = new Point(436, 560);
      mapGroupBox.Margin = new Padding(4, 5, 4, 5);
      mapGroupBox.Name = "mapGroupBox";
      mapGroupBox.Padding = new Padding(4, 5, 4, 5);
      mapGroupBox.Size = new Size(801, 748);
      mapGroupBox.TabIndex = 47;
      mapGroupBox.TabStop = false;
      mapGroupBox.Text = "MAP";
      // 
      // groupBox3
      // 
      groupBox3.Controls.Add(serialDataBox);
      groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      groupBox3.ForeColor = Color.FromArgb(198, 169, 105);
      groupBox3.Location = new Point(1623, 560);
      groupBox3.Margin = new Padding(4, 5, 4, 5);
      groupBox3.Name = "groupBox3";
      groupBox3.Padding = new Padding(4, 5, 4, 5);
      groupBox3.Size = new Size(394, 748);
      groupBox3.TabIndex = 51;
      groupBox3.TabStop = false;
      groupBox3.Text = "SERIAL CONSOLE";
      // 
      // serialDataBox
      // 
      serialDataBox.BackColor = Color.FromArgb(48, 77, 48);
      serialDataBox.BorderStyle = BorderStyle.None;
      serialDataBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      serialDataBox.ForeColor = Color.FromArgb(198, 169, 105);
      serialDataBox.Location = new Point(9, 37);
      serialDataBox.Margin = new Padding(4, 5, 4, 5);
      serialDataBox.Name = "serialDataBox";
      serialDataBox.Size = new Size(376, 698);
      serialDataBox.TabIndex = 48;
      serialDataBox.Text = "";
      // 
      // acceleroPlot
      // 
      acceleroPlot.DisplayScale = 1F;
      acceleroPlot.Location = new Point(1190, 2);
      acceleroPlot.Margin = new Padding(4, 5, 4, 5);
      acceleroPlot.Name = "acceleroPlot";
      acceleroPlot.Size = new Size(777, 522);
      acceleroPlot.TabIndex = 49;
      // 
      // altitudePlot
      // 
      altitudePlot.DisplayScale = 1F;
      altitudePlot.Location = new Point(417, 2);
      altitudePlot.Margin = new Padding(4, 5, 4, 5);
      altitudePlot.Name = "altitudePlot";
      altitudePlot.Size = new Size(777, 522);
      altitudePlot.TabIndex = 50;
      // 
      // groupBox4
      // 
      groupBox4.Controls.Add(msgReceivedLabel);
      groupBox4.Controls.Add(rxErrorsLabel);
      groupBox4.Controls.Add(currentStageLabel);
      groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      groupBox4.ForeColor = Color.FromArgb(198, 169, 105);
      groupBox4.Location = new Point(1253, 560);
      groupBox4.Margin = new Padding(4, 5, 4, 5);
      groupBox4.Name = "groupBox4";
      groupBox4.Padding = new Padding(4, 5, 4, 5);
      groupBox4.Size = new Size(356, 323);
      groupBox4.TabIndex = 52;
      groupBox4.TabStop = false;
      groupBox4.Text = "STATS";
      // 
      // msgReceivedLabel
      // 
      msgReceivedLabel.AutoSize = true;
      msgReceivedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      msgReceivedLabel.ForeColor = Color.FromArgb(198, 169, 105);
      msgReceivedLabel.Location = new Point(9, 155);
      msgReceivedLabel.Margin = new Padding(4, 0, 4, 0);
      msgReceivedLabel.Name = "msgReceivedLabel";
      msgReceivedLabel.Size = new Size(249, 32);
      msgReceivedLabel.TabIndex = 45;
      msgReceivedLabel.Text = "PACKETS RECEIVED : 0";
      // 
      // rxErrorsLabel
      // 
      rxErrorsLabel.AutoSize = true;
      rxErrorsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      rxErrorsLabel.ForeColor = Color.FromArgb(198, 169, 105);
      rxErrorsLabel.Location = new Point(9, 107);
      rxErrorsLabel.Margin = new Padding(4, 0, 4, 0);
      rxErrorsLabel.Name = "rxErrorsLabel";
      rxErrorsLabel.Size = new Size(166, 32);
      rxErrorsLabel.TabIndex = 44;
      rxErrorsLabel.Text = "RX ERRORS : 0";
      // 
      // pictureBox1
      // 
      pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
      pictureBox1.Location = new Point(-6, 45);
      pictureBox1.Margin = new Padding(4, 5, 4, 5);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(414, 395);
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      pictureBox1.TabIndex = 53;
      pictureBox1.TabStop = false;
      // 
      // DashboardForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(22, 48, 32);
      ClientSize = new Size(2034, 1357);
      Controls.Add(pictureBox1);
      Controls.Add(groupBox4);
      Controls.Add(groupBox3);
      Controls.Add(altitudePlot);
      Controls.Add(acceleroPlot);
      Controls.Add(mapGroupBox);
      Controls.Add(groupBox2);
      Controls.Add(groupBox1);
      FormBorderStyle = FormBorderStyle.FixedToolWindow;
      Margin = new Padding(4, 5, 4, 5);
      Name = "DashboardForm";
      Text = "Phoenix GCS";
      FormClosing += DashboardForm_FormClosing;
      Load += DashboardForm_Load;
      groupBox1.ResumeLayout(false);
      groupBox1.PerformLayout();
      groupBox2.ResumeLayout(false);
      groupBox2.PerformLayout();
      mapGroupBox.ResumeLayout(false);
      groupBox3.ResumeLayout(false);
      groupBox4.ResumeLayout(false);
      groupBox4.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      ResumeLayout(false);
    }

    #endregion
    private ComboBox comboBaud;
        private ComboBox comboPorts;
        private Label comPortLabel;
        private Label baudRateLabel;
        private Button resetButton;
        private Button connectSerialButton;
        private Label serialConnectivityLabel;
        private Bulb.LedBulb touchdownLed;
        private Label touchDownLabel;
        private Bulb.LedBulb drogueDescentLed;
        private Label drogueDescentLabel;
        private Bulb.LedBulb mainDescentLed;
        private Label mainDescentLabel;
        private Bulb.LedBulb mainDeployedLed;
        private Label mainDeployedLabel;
        private Label drogueDeployedLabel;
        private Bulb.LedBulb drogueDeployedLed;
        private Label freeFallLabel;
        private Bulb.LedBulb freeFallLed;
        private Label apogeeLabel;
        private Bulb.LedBulb apogeeLed;
        private Label unpFlightLabel;
        private Bulb.LedBulb unpFlightLed;
        private Label poweredFlightLabel;
        private Bulb.LedBulb poweredFlightLed;
        private Label liftOffLabel;
        private Bulb.LedBulb liftOffLed;
        private Label armedLabel;
        private Bulb.LedBulb armedLed;
        private Label safedLabel;
        private Bulb.LedBulb safedLed;
        private Label connectedLabel;
        private Bulb.LedBulb connectedLed;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button disconnectSerialButton;
        private Label currentStageLabel;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private GroupBox mapGroupBox;
        private RichTextBox serialDataBox;
        private ScottPlot.WinForms.FormsPlot acceleroPlot;
        private ScottPlot.WinForms.FormsPlot altitudePlot;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private Label rxErrorsLabel;
        private Label msgReceivedLabel;
        private PictureBox pictureBox1;
  }
}