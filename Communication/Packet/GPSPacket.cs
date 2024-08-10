using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Communication.Packet
{
    internal class GPSPacket
    {
        private uint _timeStamp_ms;

        private char _latitudeDirection;
        private uint _latitudeDegrees;
        private float _latitudeMinutes;

        private char _longitudeDirection;
        private uint _longitudeDegrees;
        private float _longitudeMinutes;

        private RawDataParser _rawDataParser;

        public const uint GPS_HEADER_ID = 0xA540U;

        public GPSPacket(byte[] rawData)
        {
            _rawDataParser = new RawDataParser();

            if (rawData != null && rawData.Length == 14)
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
                _timeStamp_ms = 0;
                _latitudeDirection = ' ';
                _latitudeDegrees = 0;
                _latitudeMinutes = 0;
                _longitudeDirection = ' ';
                _longitudeDegrees = 0;
                _longitudeMinutes = 0;
                // THROW EXCEPTION
            }
        }

        public uint getTimeStamp_ms()
        {
            return _timeStamp_ms;
        }

        public string getLatitude()
        {
            return "" + _latitudeDegrees + "°" + _latitudeMinutes + "'" + _latitudeDirection;
        }

        public string getLongitude()
        {
            return "" + _longitudeDegrees + "°" + _longitudeMinutes + "'" + _longitudeDirection;
        }
    }
}
