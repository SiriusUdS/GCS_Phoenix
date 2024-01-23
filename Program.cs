using System.IO.Ports;

namespace GCS_Phoenix
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            string[] ports = SerialPort.GetPortNames();

            ApplicationConfiguration.Initialize();

            Form1 form1 = new Form1();

            //Initialize combobox with serial ports
            foreach (string port in ports)
            {
                form1.AddPortToComboBox(port);
            }

            Application.Run(form1);
        }
    }
}