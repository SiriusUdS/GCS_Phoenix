using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Models.Sensors
{
  internal class GPSModel
  {
    [CsvHelper.Configuration.Attributes.Name("Time stamp (ms)")]
    public uint TimeStamp_ms { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Latitude direction")]
    public char LatitudeDirection { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Latitude degrees")]
    public uint LatitudeDegrees { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Latitude minutes")]
    public float LatitudeMinutes { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Longitude direction")]
    public char LongitudeDirection { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Longitude degrees")]
    public uint LongitudeDegrees { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Longitude minutes")]
    public float LongitudeMinutes { get; set; }
  }
}
