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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            tabControl = new TabControl();
            tabPage1 = new TabPage();
            pictureBox1 = new PictureBox();
            altitudePlot = new ScottPlot.WinForms.FormsPlot();
            acceleroPlot = new ScottPlot.WinForms.FormsPlot();
            mapGroupBox = new GroupBox();
            resetButton = new Button();
            gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            groupBox1 = new GroupBox();
            connectedLabel = new Label();
            connectedLed = new Bulb.LedBulb();
            safedLabel = new Label();
            safedLed = new Bulb.LedBulb();
            armedLabel = new Label();
            armedLed = new Bulb.LedBulb();
            liftOffLabel = new Label();
            liftOffLed = new Bulb.LedBulb();
            poweredFlightLabel = new Label();
            poweredFlightLed = new Bulb.LedBulb();
            unpFlightLabel = new Label();
            unpFlightLed = new Bulb.LedBulb();
            apogeeLabel = new Label();
            apogeeLed = new Bulb.LedBulb();
            freeFallLabel = new Label();
            freeFallLed = new Bulb.LedBulb();
            drogueDeployedLabel = new Label();
            drogueDeployedLed = new Bulb.LedBulb();
            mainDeployedLabel = new Label();
            mainDeployedLed = new Bulb.LedBulb();
            mainDescentLabel = new Label();
            mainDescentLed = new Bulb.LedBulb();
            drogueDescentLabel = new Label();
            drogueDescentLed = new Bulb.LedBulb();
            touchDownLabel = new Label();
            touchdownLed = new Bulb.LedBulb();
            tabPage2 = new TabPage();
            groupBox4 = new GroupBox();
            msgReceivedLabel = new Label();
            rxErrorsLabel = new Label();
            currentStageLabel = new Label();
            groupBox3 = new GroupBox();
            serialDataBox = new RichTextBox();
            groupBox2 = new GroupBox();
            disconnectSerialButton = new Button();
            serialConnectivityLabel = new Label();
            connectSerialButton = new Button();
            baudRateLabel = new Label();
            comPortLabel = new Label();
            comboPorts = new ComboBox();
            comboBaud = new ComboBox();
            tabControl.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            mapGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPage1);
            tabControl.Controls.Add(tabPage2);
            tabControl.Location = new Point(-6, 1);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1435, 819);
            tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(22, 48, 32);
            tabPage1.BackgroundImageLayout = ImageLayout.None;
            tabPage1.Controls.Add(pictureBox1);
            tabPage1.Controls.Add(altitudePlot);
            tabPage1.Controls.Add(acceleroPlot);
            tabPage1.Controls.Add(mapGroupBox);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage1.ForeColor = Color.FromArgb(198, 169, 105);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1427, 791);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "DATA";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(290, 237);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 61;
            pictureBox1.TabStop = false;
            // 
            // altitudePlot
            // 
            altitudePlot.DisplayScale = 1F;
            altitudePlot.Location = new Point(308, 2);
            altitudePlot.Name = "altitudePlot";
            altitudePlot.Size = new Size(544, 313);
            altitudePlot.TabIndex = 58;
            // 
            // acceleroPlot
            // 
            acceleroPlot.DisplayScale = 1F;
            acceleroPlot.Location = new Point(871, 2);
            acceleroPlot.Name = "acceleroPlot";
            acceleroPlot.Size = new Size(544, 313);
            acceleroPlot.TabIndex = 57;
            // 
            // mapGroupBox
            // 
            mapGroupBox.Controls.Add(resetButton);
            mapGroupBox.Controls.Add(gMapControl1);
            mapGroupBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mapGroupBox.ForeColor = Color.FromArgb(198, 169, 105);
            mapGroupBox.Location = new Point(309, 337);
            mapGroupBox.Name = "mapGroupBox";
            mapGroupBox.Size = new Size(561, 449);
            mapGroupBox.TabIndex = 56;
            mapGroupBox.TabStop = false;
            mapGroupBox.Text = "MAP";
            // 
            // resetButton
            // 
            resetButton.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            resetButton.Location = new Point(453, 418);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(102, 23);
            resetButton.TabIndex = 12;
            resetButton.Text = "Reset Map";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
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
            groupBox1.Location = new Point(17, 337);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(273, 449);
            groupBox1.TabIndex = 54;
            groupBox1.TabStop = false;
            groupBox1.Text = "STATUS";
            // 
            // connectedLabel
            // 
            connectedLabel.AutoSize = true;
            connectedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            connectedLabel.ForeColor = Color.FromArgb(198, 169, 105);
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
            // safedLabel
            // 
            safedLabel.AutoSize = true;
            safedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            safedLabel.ForeColor = Color.FromArgb(198, 169, 105);
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
            // armedLabel
            // 
            armedLabel.AutoSize = true;
            armedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            armedLabel.ForeColor = Color.FromArgb(198, 169, 105);
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
            // liftOffLabel
            // 
            liftOffLabel.AutoSize = true;
            liftOffLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            liftOffLabel.ForeColor = Color.FromArgb(198, 169, 105);
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
            // poweredFlightLabel
            // 
            poweredFlightLabel.AutoSize = true;
            poweredFlightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            poweredFlightLabel.ForeColor = Color.FromArgb(198, 169, 105);
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
            // unpFlightLabel
            // 
            unpFlightLabel.AutoSize = true;
            unpFlightLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            unpFlightLabel.ForeColor = Color.FromArgb(198, 169, 105);
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
            // apogeeLabel
            // 
            apogeeLabel.AutoSize = true;
            apogeeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            apogeeLabel.ForeColor = Color.FromArgb(198, 169, 105);
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
            // freeFallLabel
            // 
            freeFallLabel.AutoSize = true;
            freeFallLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            freeFallLabel.ForeColor = Color.FromArgb(198, 169, 105);
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
            // drogueDeployedLabel
            // 
            drogueDeployedLabel.AutoSize = true;
            drogueDeployedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drogueDeployedLabel.ForeColor = Color.FromArgb(198, 169, 105);
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
            // mainDeployedLabel
            // 
            mainDeployedLabel.AutoSize = true;
            mainDeployedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainDeployedLabel.ForeColor = Color.FromArgb(198, 169, 105);
            mainDeployedLabel.Location = new Point(42, 93);
            mainDeployedLabel.Name = "mainDeployedLabel";
            mainDeployedLabel.Size = new Size(113, 21);
            mainDeployedLabel.TabIndex = 22;
            mainDeployedLabel.Text = "Main deployed";
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
            // mainDescentLabel
            // 
            mainDescentLabel.AutoSize = true;
            mainDescentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            mainDescentLabel.ForeColor = Color.FromArgb(198, 169, 105);
            mainDescentLabel.Location = new Point(42, 64);
            mainDescentLabel.Name = "mainDescentLabel";
            mainDescentLabel.Size = new Size(102, 21);
            mainDescentLabel.TabIndex = 20;
            mainDescentLabel.Text = "Main descent";
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
            // drogueDescentLabel
            // 
            drogueDescentLabel.AutoSize = true;
            drogueDescentLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drogueDescentLabel.ForeColor = Color.FromArgb(198, 169, 105);
            drogueDescentLabel.Location = new Point(42, 122);
            drogueDescentLabel.Name = "drogueDescentLabel";
            drogueDescentLabel.Size = new Size(119, 21);
            drogueDescentLabel.TabIndex = 18;
            drogueDescentLabel.Text = "Drogue descent";
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
            // touchDownLabel
            // 
            touchDownLabel.AutoSize = true;
            touchDownLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            touchDownLabel.ForeColor = Color.FromArgb(198, 169, 105);
            touchDownLabel.Location = new Point(42, 35);
            touchDownLabel.Name = "touchDownLabel";
            touchDownLabel.Size = new Size(89, 21);
            touchDownLabel.TabIndex = 16;
            touchDownLabel.Text = "Touchdown";
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
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(22, 48, 32);
            tabPage2.Controls.Add(groupBox4);
            tabPage2.Controls.Add(groupBox3);
            tabPage2.Controls.Add(groupBox2);
            tabPage2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabPage2.ForeColor = Color.FromArgb(198, 169, 105);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1427, 791);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "SERIAL";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(msgReceivedLabel);
            groupBox4.Controls.Add(rxErrorsLabel);
            groupBox4.Controls.Add(currentStageLabel);
            groupBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox4.ForeColor = Color.FromArgb(198, 169, 105);
            groupBox4.Location = new Point(14, 15);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(249, 194);
            groupBox4.TabIndex = 63;
            groupBox4.TabStop = false;
            groupBox4.Text = "STATS";
            // 
            // msgReceivedLabel
            // 
            msgReceivedLabel.AutoSize = true;
            msgReceivedLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            msgReceivedLabel.ForeColor = Color.FromArgb(198, 169, 105);
            msgReceivedLabel.Location = new Point(6, 93);
            msgReceivedLabel.Name = "msgReceivedLabel";
            msgReceivedLabel.Size = new Size(165, 21);
            msgReceivedLabel.TabIndex = 45;
            msgReceivedLabel.Text = "PACKETS RECEIVED : 0";
            // 
            // rxErrorsLabel
            // 
            rxErrorsLabel.AutoSize = true;
            rxErrorsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rxErrorsLabel.ForeColor = Color.FromArgb(198, 169, 105);
            rxErrorsLabel.Location = new Point(6, 64);
            rxErrorsLabel.Name = "rxErrorsLabel";
            rxErrorsLabel.Size = new Size(112, 21);
            rxErrorsLabel.TabIndex = 44;
            rxErrorsLabel.Text = "RX ERRORS : 0";
            // 
            // currentStageLabel
            // 
            currentStageLabel.AutoSize = true;
            currentStageLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            currentStageLabel.ForeColor = Color.FromArgb(198, 169, 105);
            currentStageLabel.Location = new Point(6, 33);
            currentStageLabel.Name = "currentStageLabel";
            currentStageLabel.Size = new Size(148, 21);
            currentStageLabel.TabIndex = 43;
            currentStageLabel.Text = "CURRENT STAGE : 0";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(serialDataBox);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.FromArgb(198, 169, 105);
            groupBox3.Location = new Point(273, 15);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(276, 449);
            groupBox3.TabIndex = 62;
            groupBox3.TabStop = false;
            groupBox3.Text = "SERIAL CONSOLE";
            // 
            // serialDataBox
            // 
            serialDataBox.BackColor = Color.FromArgb(48, 77, 48);
            serialDataBox.BorderStyle = BorderStyle.None;
            serialDataBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            serialDataBox.ForeColor = Color.FromArgb(198, 169, 105);
            serialDataBox.Location = new Point(6, 22);
            serialDataBox.Name = "serialDataBox";
            serialDataBox.Size = new Size(263, 419);
            serialDataBox.TabIndex = 48;
            serialDataBox.Text = "";
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
            groupBox2.Location = new Point(14, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(249, 249);
            groupBox2.TabIndex = 61;
            groupBox2.TabStop = false;
            groupBox2.Text = "SERIAL";
            // 
            // disconnectSerialButton
            // 
            disconnectSerialButton.ForeColor = SystemColors.ActiveCaptionText;
            disconnectSerialButton.Location = new Point(12, 161);
            disconnectSerialButton.Name = "disconnectSerialButton";
            disconnectSerialButton.Size = new Size(139, 32);
            disconnectSerialButton.TabIndex = 15;
            disconnectSerialButton.Text = "Disconnect";
            disconnectSerialButton.UseVisualStyleBackColor = true;
            disconnectSerialButton.Click += disconnectSerialButton_Click;
            // 
            // serialConnectivityLabel
            // 
            serialConnectivityLabel.AutoSize = true;
            serialConnectivityLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            serialConnectivityLabel.ForeColor = Color.Red;
            serialConnectivityLabel.Location = new Point(15, 208);
            serialConnectivityLabel.Name = "serialConnectivityLabel";
            serialConnectivityLabel.Size = new Size(139, 30);
            serialConnectivityLabel.TabIndex = 14;
            serialConnectivityLabel.Text = "Disconnected";
            serialConnectivityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // connectSerialButton
            // 
            connectSerialButton.ForeColor = SystemColors.ActiveCaptionText;
            connectSerialButton.Location = new Point(12, 116);
            connectSerialButton.Name = "connectSerialButton";
            connectSerialButton.Size = new Size(139, 32);
            connectSerialButton.TabIndex = 13;
            connectSerialButton.Text = "Connect";
            connectSerialButton.UseVisualStyleBackColor = true;
            connectSerialButton.Click += connectSerialButton_Click;
            // 
            // baudRateLabel
            // 
            baudRateLabel.AutoSize = true;
            baudRateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            baudRateLabel.ForeColor = Color.FromArgb(198, 169, 105);
            baudRateLabel.Location = new Point(158, 73);
            baudRateLabel.Name = "baudRateLabel";
            baudRateLabel.Size = new Size(90, 21);
            baudRateLabel.TabIndex = 10;
            baudRateLabel.Text = "BAUD RATE";
            // 
            // comPortLabel
            // 
            comPortLabel.AutoSize = true;
            comPortLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comPortLabel.ForeColor = Color.FromArgb(198, 169, 105);
            comPortLabel.Location = new Point(158, 31);
            comPortLabel.Name = "comPortLabel";
            comPortLabel.Size = new Size(88, 21);
            comPortLabel.TabIndex = 9;
            comPortLabel.Text = "COM PORT";
            // 
            // comboPorts
            // 
            comboPorts.FormattingEnabled = true;
            comboPorts.Location = new Point(12, 28);
            comboPorts.Name = "comboPorts";
            comboPorts.Size = new Size(140, 29);
            comboPorts.TabIndex = 8;
            // 
            // comboBaud
            // 
            comboBaud.FormattingEnabled = true;
            comboBaud.Items.AddRange(new object[] { "9600", "19200", "38400", "57600", "115200" });
            comboBaud.Location = new Point(11, 70);
            comboBaud.Name = "comboBaud";
            comboBaud.Size = new Size(140, 29);
            comboBaud.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(22, 48, 32);
            ClientSize = new Size(1424, 814);
            Controls.Add(tabControl);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            Text = "Phoenix GCS";
            Load += Form1_Load;
            tabControl.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            mapGroupBox.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tabPage1;
        private PictureBox pictureBox1;
        private ScottPlot.WinForms.FormsPlot altitudePlot;
        private ScottPlot.WinForms.FormsPlot acceleroPlot;
        private GroupBox mapGroupBox;
        private Button resetButton;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private GroupBox groupBox1;
        private Label connectedLabel;
        private Bulb.LedBulb connectedLed;
        private Label safedLabel;
        private Bulb.LedBulb safedLed;
        private Label armedLabel;
        private Bulb.LedBulb armedLed;
        private Label liftOffLabel;
        private Bulb.LedBulb liftOffLed;
        private Label poweredFlightLabel;
        private Bulb.LedBulb poweredFlightLed;
        private Label unpFlightLabel;
        private Bulb.LedBulb unpFlightLed;
        private Label apogeeLabel;
        private Bulb.LedBulb apogeeLed;
        private Label freeFallLabel;
        private Bulb.LedBulb freeFallLed;
        private Label drogueDeployedLabel;
        private Bulb.LedBulb drogueDeployedLed;
        private Label mainDeployedLabel;
        private Bulb.LedBulb mainDeployedLed;
        private Label mainDescentLabel;
        private Bulb.LedBulb mainDescentLed;
        private Label drogueDescentLabel;
        private Bulb.LedBulb drogueDescentLed;
        private Label touchDownLabel;
        private Bulb.LedBulb touchdownLed;
        private TabPage tabPage2;
        private GroupBox groupBox4;
        private Label msgReceivedLabel;
        private Label rxErrorsLabel;
        private Label currentStageLabel;
        private GroupBox groupBox3;
        private RichTextBox serialDataBox;
        private GroupBox groupBox2;
        private Button disconnectSerialButton;
        private Label serialConnectivityLabel;
        private Button connectSerialButton;
        private Label baudRateLabel;
        private Label comPortLabel;
        private ComboBox comboPorts;
        private ComboBox comboBaud;
    }
}