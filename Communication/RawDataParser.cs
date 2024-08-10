using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Communication
{
    internal class RawDataParser
    {
        public UInt16 parseUInt16(byte[] data)
        {
            UInt16 value = BitConverter.ToUInt16(data);
            return value;
        }

        public Int16 parseInt16(byte[] data) 
        {
            Int16 value = BitConverter.ToInt16(data);
            return value;
        }

        public char parseChar(byte[] data) 
        {
            char value = BitConverter.ToChar(data);
            return value;
        }
        public float parseFloat(byte[] data) 
        {
            float value = BitConverter.ToSingle(data);
            return value;
        }
    }
}
