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
      chk_displayInConsole = new CheckBox();
      disconnectSerialButton = new Button();
      gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
      mapGroupBox = new GroupBox();
      groupBox3 = new GroupBox();
      serialDataBox = new RichTextBox();
      acceleroPlot = new ScottPlot.WinForms.FormsPlot();
      altitudePlot = new ScottPlot.WinForms.FormsPlot();
      grpCommands = new GroupBox();
      btn_clearSerialConsole = new Button();
      btn_saveDataOff = new Button();
      btn_gatherDataOff = new Button();
      btn_igniteSmoke = new Button();
      btn_gatherDataOn = new Button();
      btn_clearFlash = new Button();
      btn_readFlash = new Button();
      btn_saveDataOn = new Button();
      pictureBox1 = new PictureBox();
      grp_GraphOptions = new GroupBox();
      rb_graphFull = new RadioButton();
      rb_graphSlide = new RadioButton();
      grp_mapOptions = new GroupBox();
      lbl_nbMkarkers = new Label();
      num_markersToDisplay = new NumericUpDown();
      rb_allMarkers = new RadioButton();
      rb_onlyLastXMarkers = new RadioButton();
      groupBox1.SuspendLayout();
      groupBox2.SuspendLayout();
      mapGroupBox.SuspendLayout();
      groupBox3.SuspendLayout();
      grpCommands.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
      grp_GraphOptions.SuspendLayout();
      grp_mapOptions.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)num_markersToDisplay).BeginInit();
      SuspendLayout();
      // 
      // comboBaud
      // 
      comboBaud.FormattingEnabled = true;
      comboBaud.Items.AddRange(new object[] { "9600", "19200", "38400", "115200", "256000" });
      comboBaud.Location = new Point(17, 82);
      comboBaud.Margin = new Padding(4, 5, 4, 5);
      comboBaud.Name = "comboBaud";
      comboBaud.Size = new Size(198, 40);
      comboBaud.TabIndex = 4;
      comboBaud.SelectedIndexChanged += comboBaud_SelectedIndexChanged;
      // 
      // comboPorts
      // 
      comboPorts.FormattingEnabled = true;
      comboPorts.Location = new Point(17, 32);
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
      comPortLabel.Location = new Point(226, 37);
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
      baudRateLabel.Location = new Point(227, 87);
      baudRateLabel.Margin = new Padding(4, 0, 4, 0);
      baudRateLabel.Name = "baudRateLabel";
      baudRateLabel.Size = new Size(135, 32);
      baudRateLabel.TabIndex = 10;
      baudRateLabel.Text = "BAUD RATE";
      // 
      // resetButton
      // 
      resetButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
      resetButton.Location = new Point(530, 561);
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
      connectSerialButton.Location = new Point(16, 132);
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
      serialConnectivityLabel.Font = new Font("Segoe UI", 15.5F, FontStyle.Regular, GraphicsUnit.Point);
      serialConnectivityLabel.ForeColor = Color.Red;
      serialConnectivityLabel.Location = new Point(16, 253);
      serialConnectivityLabel.Margin = new Padding(4, 0, 4, 0);
      serialConnectivityLabel.Name = "serialConnectivityLabel";
      serialConnectivityLabel.Size = new Size(204, 42);
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
      groupBox1.Location = new Point(19, 984);
      groupBox1.Margin = new Padding(4, 5, 4, 5);
      groupBox1.Name = "groupBox1";
      groupBox1.Padding = new Padding(4, 5, 4, 5);
      groupBox1.Size = new Size(291, 30);
      groupBox1.TabIndex = 41;
      groupBox1.TabStop = false;
      groupBox1.Text = "STATUS";
      // 
      // groupBox2
      // 
      groupBox2.Controls.Add(chk_displayInConsole);
      groupBox2.Controls.Add(disconnectSerialButton);
      groupBox2.Controls.Add(serialConnectivityLabel);
      groupBox2.Controls.Add(connectSerialButton);
      groupBox2.Controls.Add(baudRateLabel);
      groupBox2.Controls.Add(comPortLabel);
      groupBox2.Controls.Add(comboPorts);
      groupBox2.Controls.Add(comboBaud);
      groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      groupBox2.ForeColor = Color.FromArgb(198, 169, 105);
      groupBox2.Location = new Point(1010, 719);
      groupBox2.Margin = new Padding(4, 5, 4, 5);
      groupBox2.Name = "groupBox2";
      groupBox2.Padding = new Padding(4, 5, 4, 5);
      groupBox2.Size = new Size(473, 297);
      groupBox2.TabIndex = 42;
      groupBox2.TabStop = false;
      groupBox2.Text = "SERIAL";
      // 
      // chk_displayInConsole
      // 
      chk_displayInConsole.AutoSize = true;
      chk_displayInConsole.Location = new Point(233, 132);
      chk_displayInConsole.Name = "chk_displayInConsole";
      chk_displayInConsole.Size = new Size(233, 36);
      chk_displayInConsole.TabIndex = 16;
      chk_displayInConsole.Text = "Display in console";
      chk_displayInConsole.UseVisualStyleBackColor = true;
      // 
      // disconnectSerialButton
      // 
      disconnectSerialButton.Enabled = false;
      disconnectSerialButton.ForeColor = SystemColors.ActiveCaptionText;
      disconnectSerialButton.Location = new Point(16, 195);
      disconnectSerialButton.Margin = new Padding(4, 5, 4, 5);
      disconnectSerialButton.Name = "disconnectSerialButton";
      disconnectSerialButton.Size = new Size(199, 53);
      disconnectSerialButton.TabIndex = 15;
      disconnectSerialButton.Text = "Disconnect";
      disconnectSerialButton.UseVisualStyleBackColor = true;
      disconnectSerialButton.Click += DisconnectSerialButton_Click;
      // 
      // gMapControl1
      // 
      gMapControl1.Bearing = 0F;
      gMapControl1.CanDragMap = true;
      gMapControl1.EmptyTileColor = Color.Navy;
      gMapControl1.GrayScaleMode = false;
      gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
      gMapControl1.LevelsKeepInMemory = 5;
      gMapControl1.Location = new Point(169, 168);
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
      mapGroupBox.Location = new Point(318, 407);
      mapGroupBox.Margin = new Padding(4, 5, 4, 5);
      mapGroupBox.Name = "mapGroupBox";
      mapGroupBox.Padding = new Padding(4, 5, 4, 5);
      mapGroupBox.Size = new Size(684, 609);
      mapGroupBox.TabIndex = 47;
      mapGroupBox.TabStop = false;
      mapGroupBox.Text = "MAP";
      // 
      // groupBox3
      // 
      groupBox3.Controls.Add(serialDataBox);
      groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      groupBox3.ForeColor = Color.FromArgb(198, 169, 105);
      groupBox3.Location = new Point(1491, 407);
      groupBox3.Margin = new Padding(4, 5, 4, 5);
      groupBox3.Name = "groupBox3";
      groupBox3.Padding = new Padding(4, 5, 4, 5);
      groupBox3.Size = new Size(394, 610);
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
      serialDataBox.Size = new Size(376, 556);
      serialDataBox.TabIndex = 48;
      serialDataBox.Text = "";
      // 
      // acceleroPlot
      // 
      acceleroPlot.DisplayScale = 1F;
      acceleroPlot.Location = new Point(1183, 2);
      acceleroPlot.Margin = new Padding(4, 5, 4, 5);
      acceleroPlot.Name = "acceleroPlot";
      acceleroPlot.Size = new Size(709, 395);
      acceleroPlot.TabIndex = 49;
      // 
      // altitudePlot
      // 
      altitudePlot.DisplayScale = 1F;
      altitudePlot.Location = new Point(485, 2);
      altitudePlot.Margin = new Padding(4, 5, 4, 5);
      altitudePlot.Name = "altitudePlot";
      altitudePlot.Size = new Size(690, 395);
      altitudePlot.TabIndex = 50;
      // 
      // grpCommands
      // 
      grpCommands.Controls.Add(btn_clearSerialConsole);
      grpCommands.Controls.Add(btn_saveDataOff);
      grpCommands.Controls.Add(btn_gatherDataOff);
      grpCommands.Controls.Add(btn_igniteSmoke);
      grpCommands.Controls.Add(btn_gatherDataOn);
      grpCommands.Controls.Add(btn_clearFlash);
      grpCommands.Controls.Add(btn_readFlash);
      grpCommands.Controls.Add(btn_saveDataOn);
      grpCommands.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      grpCommands.ForeColor = Color.FromArgb(198, 169, 105);
      grpCommands.Location = new Point(1010, 407);
      grpCommands.Margin = new Padding(4, 5, 4, 5);
      grpCommands.Name = "grpCommands";
      grpCommands.Padding = new Padding(4, 5, 4, 5);
      grpCommands.Size = new Size(473, 302);
      grpCommands.TabIndex = 52;
      grpCommands.TabStop = false;
      grpCommands.Text = "COMMANDS";
      // 
      // btn_clearSerialConsole
      // 
      btn_clearSerialConsole.ForeColor = SystemColors.ActiveCaptionText;
      btn_clearSerialConsole.Location = new Point(241, 103);
      btn_clearSerialConsole.Name = "btn_clearSerialConsole";
      btn_clearSerialConsole.Size = new Size(216, 50);
      btn_clearSerialConsole.TabIndex = 59;
      btn_clearSerialConsole.Text = "Clear console";
      btn_clearSerialConsole.UseVisualStyleBackColor = true;
      btn_clearSerialConsole.Click += btn_clearSerialConsole_Click;
      // 
      // btn_saveDataOff
      // 
      btn_saveDataOff.Enabled = false;
      btn_saveDataOff.ForeColor = SystemColors.ActiveCaptionText;
      btn_saveDataOff.Location = new Point(239, 168);
      btn_saveDataOff.Name = "btn_saveDataOff";
      btn_saveDataOff.Size = new Size(216, 50);
      btn_saveDataOff.TabIndex = 56;
      btn_saveDataOff.Text = "Save Data OFF";
      btn_saveDataOff.UseVisualStyleBackColor = true;
      btn_saveDataOff.Click += btn_saveDataOff_Click;
      // 
      // btn_gatherDataOff
      // 
      btn_gatherDataOff.Enabled = false;
      btn_gatherDataOff.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      btn_gatherDataOff.ForeColor = SystemColors.ActiveCaptionText;
      btn_gatherDataOff.Location = new Point(241, 235);
      btn_gatherDataOff.Name = "btn_gatherDataOff";
      btn_gatherDataOff.Size = new Size(216, 50);
      btn_gatherDataOff.TabIndex = 58;
      btn_gatherDataOff.Text = "Gather Data OFF";
      btn_gatherDataOff.UseVisualStyleBackColor = true;
      btn_gatherDataOff.Click += btn_gatherDataOff_Click;
      // 
      // btn_igniteSmoke
      // 
      btn_igniteSmoke.Enabled = false;
      btn_igniteSmoke.ForeColor = SystemColors.ActiveCaptionText;
      btn_igniteSmoke.Location = new Point(16, 103);
      btn_igniteSmoke.Name = "btn_igniteSmoke";
      btn_igniteSmoke.Size = new Size(216, 50);
      btn_igniteSmoke.TabIndex = 56;
      btn_igniteSmoke.Text = "Ignite Smoke";
      btn_igniteSmoke.UseVisualStyleBackColor = true;
      btn_igniteSmoke.Click += btn_igniteSmoke_Click;
      // 
      // btn_gatherDataOn
      // 
      btn_gatherDataOn.Enabled = false;
      btn_gatherDataOn.ForeColor = SystemColors.ActiveCaptionText;
      btn_gatherDataOn.Location = new Point(17, 235);
      btn_gatherDataOn.Name = "btn_gatherDataOn";
      btn_gatherDataOn.Size = new Size(216, 50);
      btn_gatherDataOn.TabIndex = 57;
      btn_gatherDataOn.Text = "Gather Data ON";
      btn_gatherDataOn.UseVisualStyleBackColor = true;
      btn_gatherDataOn.Click += btn_gatherDataOn_Click;
      // 
      // btn_clearFlash
      // 
      btn_clearFlash.Enabled = false;
      btn_clearFlash.ForeColor = SystemColors.ActiveCaptionText;
      btn_clearFlash.Location = new Point(241, 37);
      btn_clearFlash.Name = "btn_clearFlash";
      btn_clearFlash.Size = new Size(216, 50);
      btn_clearFlash.TabIndex = 55;
      btn_clearFlash.Text = "Clear Flash";
      btn_clearFlash.UseVisualStyleBackColor = true;
      btn_clearFlash.Click += btn_clearFlash_Click;
      // 
      // btn_readFlash
      // 
      btn_readFlash.Enabled = false;
      btn_readFlash.ForeColor = SystemColors.ActiveCaptionText;
      btn_readFlash.Location = new Point(16, 37);
      btn_readFlash.Name = "btn_readFlash";
      btn_readFlash.Size = new Size(216, 50);
      btn_readFlash.TabIndex = 54;
      btn_readFlash.Text = "Read Flash";
      btn_readFlash.UseVisualStyleBackColor = true;
      btn_readFlash.Click += btn_readFlash_Click;
      // 
      // btn_saveDataOn
      // 
      btn_saveDataOn.Enabled = false;
      btn_saveDataOn.ForeColor = SystemColors.ActiveCaptionText;
      btn_saveDataOn.Location = new Point(17, 168);
      btn_saveDataOn.Name = "btn_saveDataOn";
      btn_saveDataOn.Size = new Size(216, 50);
      btn_saveDataOn.TabIndex = 55;
      btn_saveDataOn.Text = "Save Data ON";
      btn_saveDataOn.UseVisualStyleBackColor = true;
      btn_saveDataOn.Click += btn_saveDataOn_Click;
      // 
      // pictureBox1
      // 
      pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
      pictureBox1.Location = new Point(-5, 2);
      pictureBox1.Margin = new Padding(4, 5, 4, 5);
      pictureBox1.Name = "pictureBox1";
      pictureBox1.Size = new Size(414, 395);
      pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
      pictureBox1.TabIndex = 53;
      pictureBox1.TabStop = false;
      // 
      // grp_GraphOptions
      // 
      grp_GraphOptions.Controls.Add(rb_graphFull);
      grp_GraphOptions.Controls.Add(rb_graphSlide);
      grp_GraphOptions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      grp_GraphOptions.ForeColor = Color.FromArgb(198, 169, 105);
      grp_GraphOptions.Location = new Point(12, 407);
      grp_GraphOptions.Name = "grp_GraphOptions";
      grp_GraphOptions.Size = new Size(291, 150);
      grp_GraphOptions.TabIndex = 54;
      grp_GraphOptions.TabStop = false;
      grp_GraphOptions.Text = "GRAPH OPTIONS";
      // 
      // rb_graphFull
      // 
      rb_graphFull.AutoSize = true;
      rb_graphFull.Checked = true;
      rb_graphFull.Location = new Point(12, 83);
      rb_graphFull.Name = "rb_graphFull";
      rb_graphFull.Size = new Size(131, 36);
      rb_graphFull.TabIndex = 1;
      rb_graphFull.TabStop = true;
      rb_graphFull.Text = "View full";
      rb_graphFull.UseVisualStyleBackColor = true;
      rb_graphFull.CheckedChanged += rb_graphFull_CheckedChanged;
      // 
      // rb_graphSlide
      // 
      rb_graphSlide.AutoSize = true;
      rb_graphSlide.Location = new Point(12, 38);
      rb_graphSlide.Name = "rb_graphSlide";
      rb_graphSlide.Size = new Size(146, 36);
      rb_graphSlide.TabIndex = 0;
      rb_graphSlide.Text = "View slide";
      rb_graphSlide.UseVisualStyleBackColor = true;
      rb_graphSlide.CheckedChanged += rb_graphSlide_CheckedChanged;
      // 
      // grp_mapOptions
      // 
      grp_mapOptions.Controls.Add(lbl_nbMkarkers);
      grp_mapOptions.Controls.Add(num_markersToDisplay);
      grp_mapOptions.Controls.Add(rb_allMarkers);
      grp_mapOptions.Controls.Add(rb_onlyLastXMarkers);
      grp_mapOptions.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
      grp_mapOptions.ForeColor = Color.FromArgb(198, 169, 105);
      grp_mapOptions.Location = new Point(12, 560);
      grp_mapOptions.Name = "grp_mapOptions";
      grp_mapOptions.Size = new Size(291, 150);
      grp_mapOptions.TabIndex = 55;
      grp_mapOptions.TabStop = false;
      grp_mapOptions.Text = "MAP OPTIONS";
      // 
      // lbl_nbMkarkers
      // 
      lbl_nbMkarkers.AutoSize = true;
      lbl_nbMkarkers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
      lbl_nbMkarkers.Location = new Point(192, 40);
      lbl_nbMkarkers.Name = "lbl_nbMkarkers";
      lbl_nbMkarkers.Size = new Size(91, 30);
      lbl_nbMkarkers.TabIndex = 3;
      lbl_nbMkarkers.Text = "markers";
      // 
      // num_markersToDisplay
      // 
      num_markersToDisplay.Location = new Point(130, 37);
      num_markersToDisplay.Name = "num_markersToDisplay";
      num_markersToDisplay.Size = new Size(56, 39);
      num_markersToDisplay.TabIndex = 2;
      num_markersToDisplay.Value = new decimal(new int[] { 10, 0, 0, 0 });
      num_markersToDisplay.ValueChanged += num_markersToDisplay_ValueChanged;
      // 
      // rb_allMarkers
      // 
      rb_allMarkers.AutoSize = true;
      rb_allMarkers.Checked = true;
      rb_allMarkers.Location = new Point(12, 83);
      rb_allMarkers.Name = "rb_allMarkers";
      rb_allMarkers.Size = new Size(157, 36);
      rb_allMarkers.TabIndex = 1;
      rb_allMarkers.TabStop = true;
      rb_allMarkers.Text = "All markers";
      rb_allMarkers.UseVisualStyleBackColor = true;
      rb_allMarkers.CheckedChanged += rb_allMarkers_CheckedChanged;
      // 
      // rb_onlyLastXMarkers
      // 
      rb_onlyLastXMarkers.AutoSize = true;
      rb_onlyLastXMarkers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
      rb_onlyLastXMarkers.Location = new Point(12, 38);
      rb_onlyLastXMarkers.Name = "rb_onlyLastXMarkers";
      rb_onlyLastXMarkers.Size = new Size(121, 34);
      rb_onlyLastXMarkers.TabIndex = 0;
      rb_onlyLastXMarkers.Text = "Only last";
      rb_onlyLastXMarkers.UseVisualStyleBackColor = true;
      rb_onlyLastXMarkers.CheckedChanged += rb_onlyLastXMarkers_CheckedChanged;
      // 
      // DashboardForm
      // 
      AutoScaleDimensions = new SizeF(10F, 25F);
      AutoScaleMode = AutoScaleMode.Font;
      BackColor = Color.FromArgb(22, 48, 32);
      ClientSize = new Size(1898, 1024);
      Controls.Add(grp_mapOptions);
      Controls.Add(grp_GraphOptions);
      Controls.Add(pictureBox1);
      Controls.Add(grpCommands);
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
      grpCommands.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
      grp_GraphOptions.ResumeLayout(false);
      grp_GraphOptions.PerformLayout();
      grp_mapOptions.ResumeLayout(false);
      grp_mapOptions.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)num_markersToDisplay).EndInit();
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
        private GroupBox grpCommands;
        private Label rxErrorsLabel;
        private Label msgReceivedLabel;
        private PictureBox pictureBox1;
        private Button btn_readFlash;
        private Button btn_igniteSmoke;
        private Button btn_clearFlash;
        private Button btn_saveDataOn;
        private Button btn_saveDataOff;
        private Button btn_gatherDataOn;
        private Button btn_gatherDataOff;
    private Button btn_clearSerialConsole;
    private GroupBox grp_GraphOptions;
    private RadioButton rb_graphFull;
    private RadioButton rb_graphSlide;
    private GroupBox grp_mapOptions;
    private Label lbl_nbMkarkers;
    private NumericUpDown num_markersToDisplay;
    private RadioButton rb_allMarkers;
    private RadioButton rb_onlyLastXMarkers;
    private CheckBox chk_displayInConsole;
  }
}