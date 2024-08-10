using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Communication.Packet
{
    internal class AltimeterPacket
    {
        private uint _timeStamp_ms;
        private float _altitude_m;

        private RawDataParser _rawDataParser;

        public const uint ALTIMETER_HEADER_ID = 0xA520U;

        public AltimeterPacket(byte[] rawData)
        {
            _rawDataParser = new RawDataParser();

            if (rawData != null && rawData.Length == 4) 
            {
                byte[] timeStampData = { rawData[0], rawData[1] };
                byte[] altitudeData = { rawData[2], rawData[3] };

                _timeStamp_ms = _rawDataParser.parseUInt16(timeStampData) * 10U;
                _altitude_m = Convert.ToSingle(_rawDataParser.parseUInt16(altitudeData)) / 100.0f;
            }
            else
            {
                _timeStamp_ms = 0;
                _altitude_m = 0;
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
    }
}
