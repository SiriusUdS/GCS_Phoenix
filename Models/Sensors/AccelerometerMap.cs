using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using CsvHelper.Configuration;

namespace GCS_Phoenix.Models.Sensors
{
  internal class AccelerometerMap : ClassMap<AccelerometerModel>
  {
    public AccelerometerMap()
    {
      Map(m => m.TimeStamp_ms).Name("Time stamp (ms)");
      Map(m => m.AccelerationX_g).Name("Acceleration X (g)");
      Map(m => m.AccelerationY_g).Name("Acceleration Y (g)");
      Map(m => m.AccelerationZ_g).Name("Acceleration Z (g)");
    }
  }
}
