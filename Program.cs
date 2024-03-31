using Google.Protobuf.WellKnownTypes;
using System.IO.Ports;

namespace GCS_Phoenix
{
    internal static class Program
    {
        private static Form1 form1;
        private static SerialPort _serialPort;

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            form1 = new Form1();
            Application.Run(form1);
        }

        public static Boolean ConnectPort()
        {

            try
            {
                if (form1.GetSerialPort() == null || form1.GetBaudRate() == 0)
                {
                    throw new Exception("Serial port or baud rate not usable.");
                }
                _serialPort = new SerialPort(form1.GetSerialPort(), form1.GetBaudRate(), Parity.None, 8, StopBits.One);
                if (!(_serialPort.IsOpen))
                    _serialPort.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
                return false;
            }

        }

        public static void DisconnectPort()
        {
            if (_serialPort.IsOpen)
                _serialPort.Close();
        }
    }
}