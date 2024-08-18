
namespace GCS_Phoenix.Communication.Packet
{
  public class AltimeterPacket
  {
    private uint _timeStamp_ms = 0;
    private float _altitude_m = 0;

    private RawDataParser _rawDataParser;

    public const uint ALTIMETER_HEADER_ID = 0xA520U;

    public AltimeterPacket(byte[] rawData)
    {
      _rawDataParser = new RawDataParser();

      if (!isPacketEmptyOrNull(rawData)) 
      {
        byte[] timeStampData = { rawData[0], rawData[1] };
        byte[] altitudeData = { rawData[2], rawData[3] };

        _timeStamp_ms = _rawDataParser.parseUInt16(timeStampData) * 10U;
        _altitude_m = Convert.ToSingle(_rawDataParser.parseUInt16(altitudeData)) / 100.0f;
      }
      else
      {
        Serilog.Log.Error("AltimeterPacket: Invalid packet data:\n" + rawData);
        // THROW EXCEPTION
      }
    }

    public uint getTimeStamp_ms()
    {
      return _timeStamp_ms;
    }

    public float getAltitude_m()
    {
      return _altitude_m;
    }

    public bool ValidatePacketValues()
    {
      return
        _timeStamp_ms != 0 &&
        _altitude_m != 0;
    }

    public static bool isPacketEmptyOrNull(byte[] rawData)
    {
      return rawData == null || rawData.Length != 4;
    }

    public override string ToString()
    {
      return "AltimeterPacket: " +
        "TimeStamp_ms: " + _timeStamp_ms +
        ", Altitude_m: " + _altitude_m;
    }
  }
}
