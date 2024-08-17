using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Models.Sensors
{
  internal class AltimeterMap : ClassMap<AltimeterModel>
  {
    public AltimeterMap()
    {
      Map(m => m.TimeStamp_ms).Name("Time stamp (ms)");
      Map(m => m.Altitude_m).Name("Altitude (m)");
    }
  }
}
