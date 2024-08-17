using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Models.Sensors
{
  internal class ThermocoupleModel
  {
    [CsvHelper.Configuration.Attributes.Name("Time stamp (ms)")]
    public uint TimeStamp_ms { get; set; }

    [CsvHelper.Configuration.Attributes.Name("Temperature (C)")]
    public float Temperature_C { get; set; }
  }
}
