namespace GCS_Phoenix
{
    partial class Form1
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
            altitudePlot = new ScottPlot.FormsPlot();
            acceleroPlot = new ScottPlot.FormsPlot();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            mapGroupBox = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            mapGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // comboBaud
            // 
            comboBaud.FormattingEnabled = true;
            comboBaud.Items.AddRange(new object[] { "9600", "19200", "38400", "115200", "256000" });
            comboBaud.Location = new Point(12, 63);
            comboBaud.Name = "comboBaud";
            comboBaud.Size = new Size(140, 29);
            comboBaud.TabIndex = 4;
            comboBaud.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboPorts
            // 
            comboPorts.FormattingEnabled = true;
            comboPorts.Location = new Point(12, 28);
            comboPorts.Name = "comboPorts";
            comboPorts.Size = new Size(140, 29);
            comboPorts.TabIndex = 8;
            // 
            // comPortLabel
            // 
            comPortLabel.AutoSize = true;
            comPortLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comPortLabel.ForeColor = SystemColors.ActiveCaption;
            comPortLabel.Location = new Point(158, 31);
            comPortLabel.Name = "comPortLabel";
            comPortLabel.Size = new Size(88, 21);
            comPortLabel.TabIndex = 9;
            comPortLabel.Text = "COM PORT";
            // 
            // baudRateLabel
            // 
            baudRateLabel.AutoSize = true;
            baudRateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            baudRateLabel.ForeColor = SystemColors.ActiveCaption;
            baudRateLabel.Location = new Point(158, 66);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new Size(90, 21);
            baudRateLabel.TabIndex = 10;
            baudRateLabel.Text = "BAUD RATE";
            // 
            // resetButton
            // 
            resetButton.Location = new Point(1220, 706);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(102, 23);
            resetButton.TabIndex = 12;
            resetButton.Text = "Reset Map";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += button3_Click;
            // 
            // connectSerialButton
            // 
            connectSerialButton.ForeColor = SystemColors.ActiveCaptionText;
            connectSerialButton.Location = new Point(12, 98);
            connectSerialButton.Name = "connectSerialButton";
            connectSerialButton.Size = new Size(139, 32);
            connectSerialButton.TabIndex = 13;
            connectSerialButton.Text = "Connect";
            connectSerialButton.UseVisualStyleBackColor = true;
            connectSerialButton.Click += button4_Click;
            // 
            // serialConnectivityLabel
            // 
            serialConnectivityLabel.AutoSize = true;
            serialConnectivityLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            serialConnectivityLabel.ForeColor = Color.Red;
            serialConnectivityLabel.Location = new Point(12, 171);
            serialConnectivityLabel.Name = "serialConnectivityLabel";
            serialConnectivityLabel.Size = new Size(139, 30);
            serialConnectivityLabel.TabIndex = 14;
            serialConnectivityLabel.Text = "Disconnected";
            serialConnectivityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // touchdownLed
            // 
            touchdownLed.Color = Color.Red;
            touchdownLed.ForeColor = SystemColors.Control;
            touchdownLed.Location = new Point(17, 33);
            touchdownLed.Name = "touchdownLed";
            touchdownLed.On = true;
            touchdownLed.Size = new Size(24, 23);
            touchdownLed.TabIndex = 15;
            touchdownLed.Text = "LED1";
            // 
            // touchDownLabel
            // 
            touchDownLabel.AutoSize = true;
            touchDownLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            touchDownLabel.ForeColor = SystemColors.ActiveCaption;
            touchDownLabel.Location = new Point(42, 35);
            touchDownLabel.Name = "touchDownLabel";
            touchDownLabel.Size = new Size(89, 21);
            touchDownLabel.TabIndex = 16;
            touchDownLabel.Text = "Touchdown";
            // 
            // drogueDescentLed
            // 
            drogueDescentLed.Color = Color.Red;
            drogueDescentLed.Location = new Point(17, 120);
            drogueDescentLed.Name = "drogueDescentLed";
            drogueDescentLed.On = true;
            drogueDescentLed.Size = new Size(24, 23);
            drogueDescentLed.TabIndex = 17;
            drogueDescentLed.Text = "ledBulb1";
            // 
            // drogueDescentLabel
            // 
            drogueDescentLabel.AutoSize = true;
            drogueDescentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drogueDescentLabel.ForeColor = SystemColors.ActiveCaption;
            drogueDescentLabel.Location = new Point(42, 122);
            drogueDescentLabel.Name = "drogueDescentLabel";
            drogueDescentLabel.Size = new Size(119, 21);
            drogueDescentLabel.TabIndex = 18;
            drogueDescentLabel.Text = "Drogue descent";
            // 
            // mainDescentLed
            // 
            mainDescentLed.Color = Color.Red;
            mainDescentLed.Location = new Point(17, 62);
            mainDescentLed.Name = "mainDescentLed";
            mainDescentLed.On = true;
            mainDescentLed.Size = new Size(24, 23);
            mainDescentLed.TabIndex = 19;
            mainDescentLed.Text = "ledBulb2";
            // 
            // mainDescentLabel
            // 
            mainDescentLabel.AutoSize = true;
            mainDescentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainDescentLabel.ForeColor = SystemColors.ActiveCaption;
            mainDescentLabel.Location = new Point(42, 64);
            mainDescentLabel.Name = "mainDescentLabel";
            mainDescentLabel.Size = new Size(102, 21);
            mainDescentLabel.TabIndex = 20;
            mainDescentLabel.Text = "Main descent";
            // 
            // mainDeployedLed
            // 
            mainDeployedLed.Color = Color.Red;
            mainDeployedLed.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainDeployedLed.ForeColor = SystemColors.ActiveCaption;
            mainDeployedLed.Location = new Point(17, 91);
            mainDeployedLed.Name = "mainDeployedLed";
            mainDeployedLed.On = true;
            mainDeployedLed.Size = new Size(24, 23);
            mainDeployedLed.TabIndex = 21;
            mainDeployedLed.Text = "Gps locked";
            // 
            // mainDeployedLabel
            // 
            mainDeployedLabel.AutoSize = true;
            mainDeployedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainDeployedLabel.ForeColor = SystemColors.ActiveCaption;
            mainDeployedLabel.Location = new Point(42, 93);
            mainDeployedLabel.Name = "mainDeployedLabel";
            mainDeployedLabel.Size = new Size(113, 21);
            mainDeployedLabel.TabIndex = 22;
            mainDeployedLabel.Text = "Main deployed";
            // 
            // drogueDeployedLabel
            // 
            drogueDeployedLabel.AutoSize = true;
            drogueDeployedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drogueDeployedLabel.ForeColor = SystemColors.ActiveCaption;
            drogueDeployedLabel.Location = new Point(42, 152);
            drogueDeployedLabel.Name = "drogueDeployedLabel";
            drogueDeployedLabel.Size = new Size(130, 21);
            drogueDeployedLabel.TabIndex = 24;
            drogueDeployedLabel.Text = "Drogue deployed";
            // 
            // drogueDeployedLed
            // 
            drogueDeployedLed.Color = Color.Red;
            drogueDeployedLed.Location = new Point(17, 150);
            drogueDeployedLed.Name = "drogueDeployedLed";
            drogueDeployedLed.On = true;
            drogueDeployedLed.Size = new Size(24, 23);
            drogueDeployedLed.TabIndex = 23;
            drogueDeployedLed.Text = "ledBulb1";
            // 
            // freeFallLabel
            // 
            freeFallLabel.AutoSize = true;
            freeFallLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            freeFallLabel.ForeColor = SystemColors.ActiveCaption;
            freeFallLabel.Location = new Point(42, 185);
            freeFallLabel.Name = "freeFallLabel";
            freeFallLabel.Size = new Size(65, 21);
            freeFallLabel.TabIndex = 26;
            freeFallLabel.Text = "Free fall";
            // 
            // freeFallLed
            // 
            freeFallLed.Color = Color.Red;
            freeFallLed.Location = new Point(17, 183);
            freeFallLed.Name = "freeFallLed";
            freeFallLed.On = true;
            freeFallLed.Size = new Size(24, 23);
            freeFallLed.TabIndex = 25;
            freeFallLed.Text = "ledBulb1";
            // 
            // apogeeLabel
            // 
            apogeeLabel.AutoSize = true;
            apogeeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            apogeeLabel.ForeColor = SystemColors.ActiveCaption;
            apogeeLabel.Location = new Point(42, 218);
            apogeeLabel.Name = "apogeeLabel";
            apogeeLabel.Size = new Size(63, 21);
            apogeeLabel.TabIndex = 28;
            apogeeLabel.Text = "Apogee";
            // 
            // apogeeLed
            // 
            apogeeLed.Color = Color.Red;
            apogeeLed.Location = new Point(17, 216);
            apogeeLed.Name = "apogeeLed";
            apogeeLed.On = true;
            apogeeLed.Size = new Size(24, 23);
            apogeeLed.TabIndex = 27;
            apogeeLed.Text = "ledBulb1";
            // 
            // unpFlightLabel
            // 
            unpFlightLabel.AutoSize = true;
            unpFlightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            unpFlightLabel.ForeColor = SystemColors.ActiveCaption;
            unpFlightLabel.Location = new Point(42, 251);
            unpFlightLabel.Name = "unpFlightLabel";
            unpFlightLabel.Size = new Size(131, 21);
            unpFlightLabel.TabIndex = 30;
            unpFlightLabel.Text = "Unpowered flight";
            // 
            // unpFlightLed
            // 
            unpFlightLed.Color = Color.Red;
            unpFlightLed.Location = new Point(17, 249);
            unpFlightLed.Name = "unpFlightLed";
            unpFlightLed.On = true;
            unpFlightLed.Size = new Size(24, 23);
            unpFlightLed.TabIndex = 29;
            unpFlightLed.Text = "ledBulb1";
            // 
            // poweredFlightLabel
            // 
            poweredFlightLabel.AutoSize = true;
            poweredFlightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            poweredFlightLabel.ForeColor = SystemColors.ActiveCaption;
            poweredFlightLabel.Location = new Point(42, 281);
            poweredFlightLabel.Name = "poweredFlightLabel";
            poweredFlightLabel.Size = new Size(110, 21);
            poweredFlightLabel.TabIndex = 32;
            poweredFlightLabel.Text = "Powered flight";
            // 
            // poweredFlightLed
            // 
            poweredFlightLed.Color = Color.Red;
            poweredFlightLed.Location = new Point(17, 279);
            poweredFlightLed.Name = "poweredFlightLed";
            poweredFlightLed.On = true;
            poweredFlightLed.Size = new Size(24, 23);
            poweredFlightLed.TabIndex = 31;
            poweredFlightLed.Text = "ledBulb1";
            // 
            // liftOffLabel
            // 
            liftOffLabel.AutoSize = true;
            liftOffLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            liftOffLabel.ForeColor = SystemColors.ActiveCaption;
            liftOffLabel.Location = new Point(42, 312);
            liftOffLabel.Name = "liftOffLabel";
            liftOffLabel.Size = new Size(51, 21);
            liftOffLabel.TabIndex = 34;
            liftOffLabel.Text = "Liftoff";
            // 
            // liftOffLed
            // 
            liftOffLed.Color = Color.Red;
            liftOffLed.Location = new Point(17, 310);
            liftOffLed.Name = "liftOffLed";
            liftOffLed.On = true;
            liftOffLed.Size = new Size(24, 23);
            liftOffLed.TabIndex = 33;
            liftOffLed.Text = "ledBulb1";
            // 
            // armedLabel
            // 
            armedLabel.AutoSize = true;
            armedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            armedLabel.ForeColor = SystemColors.ActiveCaption;
            armedLabel.Location = new Point(42, 342);
            armedLabel.Name = "armedLabel";
            armedLabel.Size = new Size(57, 21);
            armedLabel.TabIndex = 36;
            armedLabel.Text = "Armed";
            // 
            // armedLed
            // 
            armedLed.Color = Color.Red;
            armedLed.Location = new Point(17, 340);
            armedLed.Name = "armedLed";
            armedLed.On = true;
            armedLed.Size = new Size(24, 23);
            armedLed.TabIndex = 35;
            armedLed.Text = "ledBulb1";
            // 
            // safedLabel
            // 
            safedLabel.AutoSize = true;
            safedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            safedLabel.ForeColor = SystemColors.ActiveCaption;
            safedLabel.Location = new Point(42, 375);
            safedLabel.Name = "safedLabel";
            safedLabel.Size = new Size(49, 21);
            safedLabel.TabIndex = 38;
            safedLabel.Text = "Safed";
            // 
            // safedLed
            // 
            safedLed.Color = Color.Red;
            safedLed.Location = new Point(17, 373);
            safedLed.Name = "safedLed";
            safedLed.On = true;
            safedLed.Size = new Size(24, 23);
            safedLed.TabIndex = 37;
            safedLed.Text = "ledBulb1";
            // 
            // connectedLabel
            // 
            connectedLabel.AutoSize = true;
            connectedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            connectedLabel.ForeColor = SystemColors.ActiveCaption;
            connectedLabel.Location = new Point(42, 408);
            connectedLabel.Name = "connectedLabel";
            connectedLabel.Size = new Size(84, 21);
            connectedLabel.TabIndex = 40;
            connectedLabel.Text = "Connected";
            // 
            // connectedLed
            // 
            connectedLed.Color = Color.Red;
            connectedLed.Location = new Point(17, 406);
            connectedLed.Name = "connectedLed";
            connectedLed.On = true;
            connectedLed.Size = new Size(24, 23);
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
            groupBox1.ForeColor = SystemColors.ActiveCaption;
            groupBox1.Location = new Point(13, 280);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 449);
            groupBox1.TabIndex = 41;
            groupBox1.TabStop = false;
            groupBox1.Text = "Status";
            groupBox1.Enter += groupBox1_Enter;
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
            groupBox2.ForeColor = SystemColors.ActiveCaption;
            groupBox2.Location = new Point(13, 13);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(273, 213);
            groupBox2.TabIndex = 42;
            groupBox2.TabStop = false;
            groupBox2.Text = "Serial";
            // 
            // disconnectSerialButton
            // 
            disconnectSerialButton.ForeColor = SystemColors.ActiveCaptionText;
            disconnectSerialButton.Location = new Point(11, 136);
            disconnectSerialButton.Name = "disconnectSerialButton";
            disconnectSerialButton.Size = new Size(139, 32);
            disconnectSerialButton.TabIndex = 15;
            disconnectSerialButton.Text = "Disconnect";
            disconnectSerialButton.UseVisualStyleBackColor = true;
            disconnectSerialButton.Click += button5_Click;
            // 
            // currentStageLabel
            // 
            currentStageLabel.AutoSize = true;
            currentStageLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            currentStageLabel.ForeColor = SystemColors.ActiveCaption;
            currentStageLabel.Location = new Point(13, 240);
            currentStageLabel.Name = "currentStageLabel";
            currentStageLabel.Size = new Size(166, 30);
            currentStageLabel.TabIndex = 43;
            currentStageLabel.Text = "Current stage : 0";
            currentStageLabel.Click += currentStageLabel_Click;
            // 
            // altitudePlot
            // 
            altitudePlot.Location = new Point(328, 27);
            altitudePlot.Margin = new Padding(4, 3, 4, 3);
            altitudePlot.Name = "altitudePlot";
            altitudePlot.Size = new Size(469, 286);
            altitudePlot.TabIndex = 44;
            // 
            // acceleroPlot
            // 
            acceleroPlot.Location = new Point(805, 27);
            acceleroPlot.Margin = new Padding(4, 3, 4, 3);
            acceleroPlot.Name = "acceleroPlot";
            acceleroPlot.Size = new Size(469, 286);
            acceleroPlot.TabIndex = 45;
            // 
            // gMapControl1
            // 
            gMapControl1.Bearing = 0F;
            gMapControl1.CanDragMap = true;
            gMapControl1.EmptyTileColor = Color.Navy;
            gMapControl1.GrayScaleMode = false;
            gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            gMapControl1.LevelsKeepInMemory = 5;
            gMapControl1.Location = new Point(224, 85);
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
            gMapControl1.Size = new Size(294, 226);
            gMapControl1.TabIndex = 46;
            gMapControl1.Zoom = 0D;
            // 
            // mapGroupBox
            // 
            mapGroupBox.Controls.Add(gMapControl1);
            mapGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mapGroupBox.ForeColor = SystemColors.ActiveCaption;
            mapGroupBox.Location = new Point(378, 313);
            mapGroupBox.Name = "mapGroupBox";
            mapGroupBox.Size = new Size(708, 416);
            mapGroupBox.TabIndex = 47;
            mapGroupBox.TabStop = false;
            mapGroupBox.Text = "MAP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(7, 38, 59);
            ClientSize = new Size(1361, 747);
            Controls.Add(mapGroupBox);
            Controls.Add(acceleroPlot);
            Controls.Add(altitudePlot);
            Controls.Add(currentStageLabel);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(resetButton);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form1";
            Text = "Logger";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            mapGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
        private ScottPlot.FormsPlot altitudePlot;
        private ScottPlot.FormsPlot acceleroPlot;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private GroupBox mapGroupBox;
    }
}