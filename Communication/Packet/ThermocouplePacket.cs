
namespace GCS_Phoenix.Communication.Packet
{
  internal class ThermocouplePacket
  {
    private uint _timeStamp_ms = 0;
    private float _temperature_C = 0;

    private RawDataParser _rawDataParser;

    public const uint THERMOCOUPLE_HEADER_ID = 0xA550U;

    public ThermocouplePacket(byte[] rawData)
    {
      _rawDataParser = new RawDataParser();
      
      if (!isPacketEmptyOrNull(rawData))
      {
        byte[] timeStampData = { rawData[0], rawData[1] };
        byte[] temperatureData = { rawData[2], rawData[3] };

        _timeStamp_ms = _rawDataParser.parseUInt16(timeStampData) * 10U;
        _temperature_C = Convert.ToSingle(_rawDataParser.parseUInt16(temperatureData));
      }
      else
      {
        Serilog.Log.Error("ThermocouplePacket: Invalid packet data:\n" + rawData);
        // THROW EXCEPTION
      }
    }

    public uint getTimeStamp_ms()
    {
      return _timeStamp_ms;
    }

    public float getTemperature_C()
    {
      return _temperature_C;
    }

    public bool ValidatePacketValues()
    {
      return
        _timeStamp_ms != 0 &&
        _temperature_C != 0;
    }

    public static bool isPacketEmptyOrNull(byte[] rawData)
    {
      return rawData == null || rawData.Length != 4;
    }

    public override string ToString()
    {
      return "ThermocouplePacket: " +
        "TimeStamp_ms: " + _timeStamp_ms +
        ", Temperature_C: " + _temperature_C;
    }
  }
}
