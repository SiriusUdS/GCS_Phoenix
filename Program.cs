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


        /// <summary>
        /// Try to connect to the Serial port using the baudrate chosen in the drop down menus.
        /// </summary>
        /// <returns>Returns a boolean showing if the connection was succesful or not.</returns>
        public static Boolean ConnectPort()
        {

            try
            {
                if (form1.GetSerialPort().Equals("")|| form1.GetBaudRate().Equals(0))
                {
                    throw new Exception("Serial port or baud rate not usable.");
                }
                if(_serialPort == null)
                    _serialPort = new SerialPort(form1.GetSerialPort(), form1.GetBaudRate(), Parity.None, 8, StopBits.One);
                else
                {
                    DisconnectPort();
                    _serialPort = new SerialPort(form1.GetSerialPort(), form1.GetBaudRate(), Parity.None, 8, StopBits.One);
                }

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

        /// <summary>
        /// Return the serial port that is open.
        /// </summary>
        /// <returns>Returns a SerialPort object.</returns>
        public static SerialPort GetSerialPort()
        {
            return _serialPort;
        }

        /// <summary>
        /// Closes the port that is open.
        /// </summary>
        public static void DisconnectPort()
        {
            try
            {
                if (_serialPort == null)
                    MessageBox.Show("Error, no ports open.", "Error!");
                else
                {
                    _serialPort.Close();
                    _serialPort.Dispose();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Exception when closing port :: {ex.Message}", "Error!");
            }

            
        }
    }
}