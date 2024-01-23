using ScottPlot;
using Color = System.Drawing.Color;
using GMap.NET;

namespace GCS_Phoenix
{



    public partial class Form1 : Form
    {

        const float PADLEFT = 60;

        public Form1()
        {
            InitializeComponent();


            gMapControl1.CacheLocation = "C:\\Users\\berna\\OneDrive - USherbrooke\\C#\\Logger\\Cache";
            gMapControl1.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleSatelliteMap;
            gMapControl1.Dock = DockStyle.Fill;
            //gMapControl1.MapProvider = GMap.NET.MapProviders.BingMapProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;
            gMapControl1.ShowCenter = false;
            gMapControl1.MinZoom = 1;
            gMapControl1.MaxZoom = 20;
            var markersOverlay = new GMap.NET.WindowsForms.GMapOverlay("marker1");

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








        // Temperature Graph
        private void Form1_Load(object sender, EventArgs e)
        {


            acceleroPlot.Plot.SetAxisLimits(0, 100, -2, 2);
            altitudePlot.Plot.SetAxisLimits(0, 100, -2, 2);

            acceleroPlot.Plot.Style(Style.Blue1);
            acceleroPlot.Plot.Layout(PADLEFT);
            acceleroPlot.Plot.XLabel("Time (S)");
            acceleroPlot.Plot.Title("Accelerometers (C)");
            acceleroPlot.Render();

            altitudePlot.Plot.Style(Style.Blue1);
            altitudePlot.Plot.Layout(PADLEFT);
            altitudePlot.Plot.XLabel("Time (S)");
            altitudePlot.Plot.Title("Altitude (M)");
            altitudePlot.Render();

        }

        // Accelerometer graph
        private void formsPlot2_Load(object sender, EventArgs e)
        {

            acceleroPlot.Plot.Style(Style.Blue1);
            acceleroPlot.Plot.Layout(PADLEFT);
            acceleroPlot.Plot.XLabel("Time (S)");
            acceleroPlot.Plot.Title("Accelerometers (C)");
            acceleroPlot.Render();

        }


        // Altitude Graph
        private void formsPlot3_Load(object sender, EventArgs e)
        {

            altitudePlot.Plot.Style(Style.Blue1);
            altitudePlot.Plot.Layout(PADLEFT);
            altitudePlot.Plot.XLabel("Time (S)");
            altitudePlot.Plot.Title("Altitude (M)");
            altitudePlot.Render();

        }




        public void AddPortToComboBox(string port)
        {
            comboPorts.Items.Add(port);
        }




        // Start button
        private void button2_Click(object sender, EventArgs e)
        {

        }


        // Stop button
        private void button1_Click(object sender, EventArgs e)
        {
        }

        // Reset button
        private void button3_Click(object sender, EventArgs e)
        {
            gMapControl1.Position = new PointLatLng(48.47583, -81.330494);
            gMapControl1.Update();
            gMapControl1.Refresh();

        }

        // Connect button
        private void button4_Click(object sender, EventArgs e)
        {
            // Testing labels
            serialConnectivityLabel.Text = "Connected";
            serialConnectivityLabel.ForeColor = Color.Green;
            connectedLed.Color = Color.Green;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {
            serialConnectivityLabel.Text = "Disconnected";
            serialConnectivityLabel.ForeColor = Color.Red;
            connectedLed.Color = Color.Red;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void currentStageLabel_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Form1.addMarker();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}