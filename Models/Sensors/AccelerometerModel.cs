using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Models.Sensors
{
  internal class AccelerometerModel
  {
    [CsvHelper.Configuration.Attributes.Name("Time stamp (ms)")]
    public uint TimeStamp_ms { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Acceleration X (g)")]
    public float AccelerationX_g { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Acceleration Y (g)")]
    public float AccelerationY_g { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Acceleration Z (g)")]
    public float AccelerationZ_g { get; set; }
  }
}
