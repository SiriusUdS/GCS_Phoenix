using GCS_Phoenix.Communication.Packet;
using Google.Protobuf.WellKnownTypes;
using Microsoft.VisualBasic.Logging;
using Serilog;
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

      Serilog.Log.Logger = new LoggerConfiguration()
        .MinimumLevel.Debug()
        .WriteTo.Console()
        .WriteTo.File(Directory.GetCurrentDirectory() + "\\Logs\\log-.txt", rollingInterval: RollingInterval.Day)
        .CreateLogger();

      Serilog.Log.Information("Application started.");
      Application.Run(dashboardForm);
    }
  }
}