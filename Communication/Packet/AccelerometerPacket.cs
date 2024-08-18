using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Communication.Packet
{
    public class AccelerometerPacket
    {
        private uint _timeStamp_ms;
        private float _accelerationX_g;
        private float _accelerationY_g;
        private float _accelerationZ_g;

        private RawDataParser _rawDataParser;

        public const uint ACCELEROMETER_HEADER_ID = 0xA510U;

        public AccelerometerPacket(byte[] rawData)
        {
            _rawDataParser = new RawDataParser();

            if (rawData != null && rawData.Length == 8)
            {
                byte[] timeStampData = { rawData[0], rawData[1] };
                byte[] accelerationXData = { rawData[2], rawData[3] };
                byte[] accelerationYData = { rawData[4], rawData[5] };
                byte[] accelerationZData = { rawData[6], rawData[7] };

                _timeStamp_ms = _rawDataParser.parseUInt16(timeStampData) * 10U;
                _accelerationX_g = _rawDataParser.parseInt16(accelerationXData) / 1000.0f;
                _accelerationY_g = _rawDataParser.parseInt16(accelerationYData) / 1000.0f;
                _accelerationZ_g = _rawDataParser.parseInt16(accelerationZData) / 1000.0f;
            }
            else
            {
                _timeStamp_ms = 0;
                _accelerationX_g = 0;
                _accelerationY_g = 0;
                _accelerationZ_g = 0;
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
    }
}
