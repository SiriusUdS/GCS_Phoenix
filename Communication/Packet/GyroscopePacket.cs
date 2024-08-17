
namespace GCS_Phoenix.Communication.Packet
{
  internal class GyroscopePacket
  {
    private uint _timeStamp_ms = 0;
    private float _rotationX_dps = 0;
    private float _rotationY_dps = 0;
    private float _rotationZ_dps = 0;

    private RawDataParser _rawDataParser;

    public const uint GYROSCOPE_HEADER_ID = 0xA530U;

    public GyroscopePacket(byte[] rawData)
    {
      _rawDataParser = new RawDataParser();

      if (!isPacketEmptyOrNull(rawData))
      {
        byte[] timeStampData = { rawData[0], rawData[1] };
        byte[] rotationXData = { rawData[2], rawData[3] };
        byte[] rotationYData = { rawData[4], rawData[5] };
        byte[] rotationZData = { rawData[6], rawData[7] };

        _timeStamp_ms = _rawDataParser.parseUInt16(timeStampData) * 10U;
        _rotationX_dps = _rawDataParser.parseInt16(rotationXData) / 1000.0f;
        _rotationY_dps = _rawDataParser.parseInt16(rotationYData) / 1000.0f;
        _rotationZ_dps = _rawDataParser.parseInt16(rotationZData) / 1000.0f;
      }
      else
      {
        Serilog.Log.Error("GyroscopePacket: Invalid packet data:\n" + rawData);
        // THROW EXCEPTION
      }
    }

    public uint getTimeStamp_ms()
    {
      return _timeStamp_ms;
    }

    public float getRotationX_dps()
    {
      return _rotationX_dps;
    }

    public float getRotationY_dps()
    {
      return _rotationY_dps;
    }

    public float getRotationZ_dps()
    {
      return _rotationZ_dps;
    }

    public bool ValidatePacketValues()
    {
      return
        _timeStamp_ms != 0 &&
        _rotationX_dps != 0 &&
        _rotationY_dps != 0 &&
        _rotationZ_dps != 0;
    }

    public static bool isPacketEmptyOrNull(byte[] rawData)
    {
      return rawData == null || rawData.Length != 8;
    }
  }
}
