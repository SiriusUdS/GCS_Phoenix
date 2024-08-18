
namespace GCS_Phoenix.Communication.Packet
{
  internal class AccelerometerPacket
  {
    private uint _timeStamp_ms = 0;
    private float _accelerationX_g = 0;
    private float _accelerationY_g = 0;
    private float _accelerationZ_g = 0;

    private RawDataParser _rawDataParser;

    public const uint ACCELEROMETER_HEADER_ID = 0xA510U;

    public AccelerometerPacket(byte[] rawData)
    {
      _rawDataParser = new RawDataParser();

      if (!isPacketEmptyOrNull(rawData))
      {
        byte[] timeStampData = { rawData[0], rawData[1] };
        byte[] accelerationXData = { rawData[2], rawData[3] };
        byte[] accelerationYData = { rawData[4], rawData[5] };
        byte[] accelerationZData = { rawData[6], rawData[7] };

        _timeStamp_ms = _rawDataParser.parseUInt16(timeStampData) * 100U;
        _accelerationX_g = _rawDataParser.parseInt16(accelerationXData) / 1000.0f;
        _accelerationY_g = _rawDataParser.parseInt16(accelerationYData) / 1000.0f;
        _accelerationZ_g = _rawDataParser.parseInt16(accelerationZData) / 1000.0f;
      }
      else
      {
        Serilog.Log.Error("AcceleromterPacket: Invalid packet data:\n" + rawData);
        // THROW EXCEPTION
      }
    }

    public uint getTimeStamp_ms()
    {
      return _timeStamp_ms;
    }

    public float getAccelerationX_g()
    {
      return _accelerationX_g;
    }

    public float getAccelerationY_g()
    {
      return _accelerationY_g;
    }

    public float getAccelerationZ_g()
    {
      return _accelerationZ_g;
    }

    public bool ValidatePacketValues()
    {
      return
        _timeStamp_ms != 0 &&
        _accelerationX_g != 0 &&
        _accelerationY_g != 0 &&
        _accelerationZ_g != 0;
    }

    public static bool isPacketEmptyOrNull(byte[] rawData)
    {
      return rawData == null || rawData.Length != 8;
    }

    public override string ToString()
    {
      return "AccelerometerPacket: " +
        "TimeStamp_ms: " + _timeStamp_ms +
        ", AccelerationX_g: " + _accelerationX_g +
        ", AccelerationY_g: " + _accelerationY_g +
        ", AccelerationZ_g: " + _accelerationZ_g;
    }
  }
}
