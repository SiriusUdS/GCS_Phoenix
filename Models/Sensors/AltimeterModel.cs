using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Models.Sensors
{
  internal class AltimeterModel
  {
    [CsvHelper.Configuration.Attributes.Name("Time stamp (ms)")]
    public uint TimeStamp_ms { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Altitude (m)")]
    public float Altitude_m { get; set; }
  }
}
