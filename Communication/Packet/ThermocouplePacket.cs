using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Communication.Packet
{
    internal class ThermocouplePacket
    {
        private uint _timeStamp_ms;
        private float _temperature_C;

        private RawDataParser _rawDataParser;

        public const uint THERMOCOUPLE_HEADER_ID = 0xA550U;

        public ThermocouplePacket(byte[] rawData)
        {
            _rawDataParser = new RawDataParser();

            if (rawData != null && rawData.Length == 4)
            {
                byte[] timeStampData = { rawData[0], rawData[1] };
                byte[] temperatureData = { rawData[2], rawData[3] };

                _timeStamp_ms = _rawDataParser.parseUInt16(timeStampData) * 10U;
                _temperature_C = Convert.ToSingle(_rawDataParser.parseUInt16(temperatureData)) / 100.0f;
            }
            else
            {
                _timeStamp_ms = 0;
                _temperature_C = 0;
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
    }
}
