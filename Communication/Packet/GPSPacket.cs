using ScottPlot.TickGenerators.TimeUnits;
using System;
namespace GCS_Phoenix.Communication.Packet
{
  public class GPSPacket
  {
    private uint _timeStamp_ms = 0;

    private char _latitudeDirection = ' ';
    private uint _latitudeDegrees = 0;
    private float _latitudeMinutes = 0;

    private char _longitudeDirection = ' ';
    private uint _longitudeDegrees = 0;
    private float _longitudeMinutes = 0;

    private RawDataParser _rawDataParser;

    public const uint GPS_HEADER_ID = 0xA540U;

    public GPSPacket(byte[] rawData)
    {
      _rawDataParser = new RawDataParser();

      if (!isPacketEmptyOrNull(rawData))
      {
        byte[] timeStampData = { rawData[0], rawData[1] };
        byte[] latitudeDirection = { rawData[2], rawData[3] };
        byte[] latitudeDegrees = { rawData[4], rawData[5] };
        byte[] latitudeMinutes = { rawData[6], rawData[7] };
        byte[] longitudeDirection = { rawData[8], rawData[9] };
        byte[] longitudeDegrees = { rawData[10], rawData[11] };
        byte[] longitudeMinutes = { rawData[12], rawData[13] };

        _timeStamp_ms = _rawDataParser.parseUInt16(timeStampData) * 10U;
        _latitudeDirection = _rawDataParser.parseChar(latitudeDirection);
        _latitudeDegrees = _rawDataParser.parseUInt16(latitudeDegrees);
        _latitudeMinutes = _rawDataParser.parseUInt16(latitudeMinutes) / 1000.0f;
        _longitudeDirection = _rawDataParser.parseChar(longitudeDirection);
        _longitudeDegrees = _rawDataParser.parseUInt16(longitudeDegrees);
        _longitudeMinutes = _rawDataParser.parseUInt16(longitudeMinutes) / 1000.0f;
      }
      else
      {
        Serilog.Log.Error("GPSPacket: Invalid packet data:\n" + rawData);
        // THROW EXCEPTION
      }
    }

    public uint getTimeStamp_ms()
    {
      return _timeStamp_ms;
    }

    public char getLatitudeDirection()
    {
      return _latitudeDirection;
    }

    public uint getLatitudeDegrees()
    {
      return _latitudeDegrees;
    }

    public float getLatitudeMinutes()
    {
      return _latitudeMinutes;
    }

    public double getLatitudeValuesDegrees()
    {
      if (_latitudeDirection == 'S')
      {
        return -(_latitudeDegrees + (_latitudeMinutes / 60.0));
      } else
      {
        return _latitudeDegrees + (_latitudeMinutes / 60.0);
      }
    }

    public char getLongitudeDirection()
    {
      return _longitudeDirection;
    }

    public uint getLongitudeDegrees()
    {
      return _longitudeDegrees;
    }

    public float getLongitudeMinutes()
    {
      return _longitudeMinutes;
    }

    public double getLongitudeValuesDegrees()
    {
      if (_longitudeDirection == 'W')
      {
        return -(_longitudeDegrees + (_longitudeMinutes / 60.0));
      }
      else
      {
        return _longitudeDegrees + (_longitudeMinutes / 60.0);
      }
    }

    public string getLatitudeFormatted()
    {
      return "" + _latitudeDegrees + "°" + _latitudeMinutes + "'" + _latitudeDirection;
    }

    public string getLongitudeFormatted()
    {
      return "" + _longitudeDegrees + "°" + _longitudeMinutes + "'" + _longitudeDirection;
    }

    public bool ValidatePacketValues()
    {
      return 
        _timeStamp_ms != 0 &&
        _latitudeDirection != ' ' &&
        _latitudeDegrees != 0 &&
        _latitudeMinutes != 0 &&
        _longitudeDirection != ' ' &&
        _longitudeDegrees != 0 &&
        _longitudeMinutes != 0;
    }

    public static bool isPacketEmptyOrNull(byte[] rawData)
    {
      return rawData == null || rawData.Length != 14;
    }

    public override string ToString()
    {
      return "GPSPacket: " +
        "TimeStamp_ms: " + _timeStamp_ms +
        ", Latitude direction: " + _latitudeDirection +
        ", Latitude degrees: " + _latitudeDegrees +
        ", Latitude minutes: " + _latitudeMinutes +
        ", Longitude direction: " + _longitudeDirection +
        ", Longitude degrees: " + _longitudeDegrees +
        ", Longitude minutes: " + _longitudeMinutes;
    }
  }
}
