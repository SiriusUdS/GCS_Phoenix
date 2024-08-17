using CsvHelper.Configuration;

namespace GCS_Phoenix.Models.Sensors
{
  internal class GyroscopeMap : ClassMap<GyroscopeModel>
  {
    public GyroscopeMap() 
    {
      Map(m => m.TimeStamp_ms).Name("Time stamp (ms)");
      Map(m => m.RotationX_dps).Name("Rotation X (dps)");
      Map(m => m.RotationY_dps).Name("Rotation Y (dps)");
      Map(m => m.RotationZ_dps).Name("Rotation Z (dps)");
    }
  }
}
