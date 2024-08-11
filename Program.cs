using GCS_Phoenix.Communication.Packet;
using Google.Protobuf.WellKnownTypes;
using System.IO.Ports;

namespace GCS_Phoenix
{
    internal static class Program
    {
        private static DashboardForm dashboardForm;
        private static SerialPort _serialPort;

        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            dashboardForm = new DashboardForm();

            /*byte[] altimeterRawData = { 216, 4, 244, 114 };
            AltimeterPacket altimeterPacket = new AltimeterPacket(altimeterRawData);

            byte[] accelerometerRawData = { 54, 4, 169, 255, 3, 0, 232, 3 };
            AccelerometerPacket accelerometerPacket = new AccelerometerPacket(accelerometerRawData);

            byte[] gyroscopeRawData = { 58, 4, 96, 253, 252, 255, 248, 255 };
            GyroscopePacket gyroscopePacket = new GyroscopePacket(gyroscopeRawData);

            byte[] gpsRawData = { 111, 4, 78, 0, 45, 0, 189, 90, 87, 0, 71, 0, 169, 216 };
            GPSPacket gPSPacket = new GPSPacket(gpsRawData);

            byte[] thermocoupleData = { 84, 4, 8, 135 };
            ThermocouplePacket thermocouplePacket = new ThermocouplePacket(thermocoupleData);*/

            Application.Run(dashboardForm);
        }


        /// <summary>
        /// Try to connect to the Serial port using the baudrate chosen in the drop down menus.
        /// </summary>
        /// <returns>Returns a boolean showing if the connection was succesful or not.</returns>
        public static Boolean ConnectPort()
        {

            try
            {
                if (dashboardForm.GetSelectedSerialPort().Equals("")|| dashboardForm.GetSelectedBaudRate().Equals(0))
                {
                    throw new System.Exception("Serial port or baud rate not usable.");
                }
                _serialPort = new SerialPort(dashboardForm.GetSelectedSerialPort(), dashboardForm.GetSelectedBaudRate(), Parity.None, 8, StopBits.One);
                if (!(_serialPort.IsOpen))
                    _serialPort.Open();
                return true;
            }
            catch (System.Exception ex)
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
            catch(System.Exception ex)
            {
                MessageBox.Show($"Exception when closing port :: {ex.Message}", "Error!");
            }

            
        }
    }
}