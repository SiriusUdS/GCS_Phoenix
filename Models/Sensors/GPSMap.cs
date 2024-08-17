using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Models.Sensors
{
  internal class GPSMap : ClassMap<GPSModel>
  {
    public GPSMap() 
    {
      Map(m => m.TimeStamp_ms).Name("Time stamp (ms)");
      Map(m => m.LatitudeDirection).Name("Latitude direction");
      Map(m => m.LatitudeDegrees).Name("Latitude degrees");
      Map(m => m.LatitudeMinutes).Name("Latitude minutes");
      Map(m => m.LongitudeDirection).Name("Longitude direction");
      Map(m => m.LongitudeDegrees).Name("Longitude degrees");
      Map(m => m.LongitudeMinutes).Name("Longitude minutes");
    }
  }
}
