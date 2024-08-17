using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Models.Sensors
{
  internal class ThermocoupleMap : ClassMap<ThermocoupleModel>
  {
    public ThermocoupleMap() {
      Map(m => m.TimeStamp_ms).Name("Time stamp (ms)");
      Map(m => m.Temperature_C).Name("Temperature (C)");
    }
  }
}
