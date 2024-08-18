using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CsvHelper.Configuration.Attributes;

namespace GCS_Phoenix.Models.Sensors
{
  internal class GyroscopeModel
  {
    [CsvHelper.Configuration.Attributes.Name("Time stamp (ms)")]
    public uint TimeStamp_ms { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Rotation X (dps)")]
    public float RotationX_dps { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Rotation Y (dps)")]
    public float RotationY_dps { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Rotation Z (dps)")]
    public float RotationZ_dps { get; set; }
  }
}
