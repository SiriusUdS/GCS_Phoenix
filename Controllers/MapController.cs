using GMap.NET.WindowsForms;
using GMap.NET;

namespace GCS_Phoenix.Controllers
{
    public class MapController
    {

        public Form1 form;
        public GMapControl mapControl;
        public readonly string cachePath;                                          //Path of the cache folder for the map.
        public GMapOverlay markersOverlay;                                         //Markers overlay for the map.

        public MapController(Form1 form, GMapControl mapControl)
        {
            this.form = form;
            this.mapControl = mapControl;
            cachePath = Directory.GetCurrentDirectory() + "\\Cache";
            markersOverlay = new GMapOverlay("marker1");
        }


        /// <summary>
        /// Code to initialize the map.
        /// </summary>
        public void InitializeMap()
        {
            mapControl.CacheLocation = cachePath;
            mapControl.MapProvider = GMap.NET.MapProviders.GMapProviders.GoogleSatelliteMap;
            mapControl.Dock = DockStyle.Fill;
            GMaps.Instance.Mode = AccessMode.CacheOnly; // Change ServerAndCahe to Cache only for offline use
            mapControl.ShowCenter = false;
            mapControl.MinZoom = 1;
            mapControl.MaxZoom = 20;
            ResetMap();

        }

        /// <summary>
        /// Adds a marker to the map using the provides latitude and longitude.
        /// </summary>
        /// <param name="_lat">The latitude of the marker to add.</param>
        /// <param name="_long">The longitude of the marker to add.</param>
        public void AddPointToMap(double _lat, double _long)
        {
            if(markersOverlay.Markers.Count != 0)
                markersOverlay.Markers.LastOrDefault().Size = new Size(6, 10);

            double latitude = 48.47583; // Your received latitude;
            double longitude = -81.330494; // Your received longitude;

            
            var marker = new GMap.NET.WindowsForms.Markers.GMarkerGoogle(
                    new PointLatLng(_lat, _long), GMap.NET.WindowsForms.Markers.GMarkerGoogleType.red_small);
            markersOverlay.Markers.Add(marker);
            mapControl.Overlays.Add(markersOverlay);

            mapControl.Update();
            mapControl.Refresh();
            
        }



        /// <summary>
        /// Resets the position of the map when the reset map button is pressed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void ResetMap()
        {
            mapControl.Position = new PointLatLng(48.47583, -81.330494);
            mapControl.Zoom = 15;
            mapControl.Update();
            mapControl.Refresh();

        }
    }
}
