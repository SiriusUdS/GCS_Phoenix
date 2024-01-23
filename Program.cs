using System.IO.Ports;

namespace GCS_Phoenix
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // Lister les ports de COM utilisable
            string[] ports = SerialPort.GetPortNames();

            ApplicationConfiguration.Initialize();

            Form1 form1 = new Form1();

            // Initialiser le combobox de ports avec les ports utilisables
            foreach (string port in ports)
            {
                form1.addPortToComboBox(port);
            }

            Application.Run(form1);
        }
    }
}