using System.Globalization;

using CsvHelper;

using GCS_Phoenix.Communication.Packet;
using GCS_Phoenix.Models.Sensors;

namespace GCS_Phoenix.Managers
{
  internal class CsvFileManager
  {
    private static string csvBaseOutputPath = Directory.GetCurrentDirectory() + "\\Data";
    private static string csvAccelerometerOutputFile = "\\AccelerometerData.csv";
    private static string csvGyroscopeOutputFile = "\\GyroscopeData.csv";
    private static string csvThermocoupleOutputFile = "\\ThermocoupleData.csv";
    private static string csvAltimeterOutputFile = "\\AltimeterData.csv";
    private static string csvGPSOutputFile = "\\GPSData.csv";

    private List<AccelerometerModel> accelerometerDataList = new List<AccelerometerModel>();
    private List<AltimeterModel> altimeterDataList = new List<AltimeterModel>();
    private List<GyroscopeModel> gyroscopeDataList = new List<GyroscopeModel>();
    private List<GPSModel> gpsDataList = new List<GPSModel>();
    private List<ThermocoupleModel> thermocoupleDataList = new List<ThermocoupleModel>();

    public string csvSessionFolderName { get; set; } = "";

    public CsvFileManager()
    {
      Initialize();
    }

    public void AddAccelerometerData(AccelerometerPacket packet)
    {
      if (!packet.ValidatePacketValues())
      {
        // Log error
        return;
      }
      accelerometerDataList.Add(new AccelerometerModel
      {
        TimeStamp_ms = packet.getTimeStamp_ms(),
        AccelerationX_g = packet.getAccelerationX_g(),
        AccelerationY_g = packet.getAccelerationY_g(),
        AccelerationZ_g = packet.getAccelerationZ_g()
      });
    }

    public void AddAltimeterData(AltimeterPacket packet)
    {
      if (!packet.ValidatePacketValues())
      {
        // Log error
        return;
      }
      altimeterDataList.Add(new AltimeterModel
      {
        TimeStamp_ms = packet.getTimeStamp_ms(),
        Altitude_m = packet.getAltitude_m()
      });
    }

    public void AddGyroscopeData(GyroscopePacket packet)
    {
      if (!packet.ValidatePacketValues())
      {
        // Log error
        return;
      }
      gyroscopeDataList.Add(new GyroscopeModel
      {
        TimeStamp_ms = packet.getTimeStamp_ms(),
        RotationX_dps = packet.getRotationX_dps(),
        RotationY_dps = packet.getRotationY_dps(),
        RotationZ_dps = packet.getRotationZ_dps()
      });
    }

    public void AddGPSData(GPSPacket packet)
    {
      if (!packet.ValidatePacketValues())
      {
        // Log error
        return;
      }
      gpsDataList.Add(new GPSModel
      {
        TimeStamp_ms = packet.getTimeStamp_ms(),
        LatitudeDirection = packet.getLatitudeDirection(),
        LatitudeDegrees = packet.getLatitudeDegrees(),
        LatitudeMinutes = packet.getLatitudeMinutes(),
        LongitudeDirection = packet.getLongitudeDirection(),
        LongitudeDegrees = packet.getLongitudeDegrees(),
        LongitudeMinutes = packet.getLongitudeMinutes()
      });
    }

    public void AddThermocoupleData(ThermocouplePacket packet)
    {
      if (!packet.ValidatePacketValues())
      {
        // Log error
        return;
      }
      thermocoupleDataList.Add(new ThermocoupleModel
      {
        TimeStamp_ms = packet.getTimeStamp_ms(),
        Temperature_C = packet.getTemperature_C()
      });
    }

    public void Initialize()
    {
      InitializeOutputDirectory();
      InitializeCsvFileHeaders();
    }

    private void InitializeOutputDirectory()
    {
      if (!Directory.Exists(csvBaseOutputPath + csvSessionFolderName))
      {
        Directory.CreateDirectory(csvBaseOutputPath + csvSessionFolderName);
      }
    }

    private static void InitializeCsvFileHeaders()
    {
      if (!File.Exists(csvBaseOutputPath + "\\AccelerometerData.csv"))
      {
        using (StreamWriter sw = new StreamWriter(csvBaseOutputPath + "\\AccelerometerData.csv"))
        {
          using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
          {
            cw.Context.RegisterClassMap<AccelerometerMap>();
            cw.WriteHeader<AccelerometerModel>();
            cw.NextRecord();
          }
        }
      }
      if (!File.Exists(csvBaseOutputPath + "\\AltimeterData.csv"))
      {
        using (StreamWriter sw = new StreamWriter(csvBaseOutputPath + "\\AltimeterData.csv"))
        {
          using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
          {
            cw.Context.RegisterClassMap<AltimeterMap>();
            cw.WriteHeader<AltimeterModel>();
            cw.NextRecord();
          }
        }
      }
      if (!File.Exists(csvBaseOutputPath + "\\GyroscopeData.csv"))
      {
        using (StreamWriter sw = new StreamWriter(csvBaseOutputPath + "\\GyroscopeData.csv"))
        {
          using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
          {
            cw.Context.RegisterClassMap<GyroscopeMap>();
            cw.WriteHeader<GyroscopeModel>();
            cw.NextRecord();
          }
        }
      }
      if (!File.Exists(csvBaseOutputPath + "\\GPSData.csv"))
      {
        using (StreamWriter sw = new StreamWriter(csvBaseOutputPath + "\\GPSData.csv"))
        {
          using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
          {
            cw.Context.RegisterClassMap<GPSMap>();
            cw.WriteHeader<GPSModel>();
            cw.NextRecord();
          }
        }
      }
      if (!File.Exists(csvBaseOutputPath + "\\ThermocoupleData.csv"))
      {
        using (StreamWriter sw = new StreamWriter(csvBaseOutputPath + "\\ThermocoupleData.csv"))
        {
          using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
          {
            cw.Context.RegisterClassMap<ThermocoupleMap>();
            cw.WriteHeader<ThermocoupleModel>();
            cw.NextRecord();
          }
        }
      }
    }

    public void WriteAccelerometerDataToCsvFile(List<AccelerometerModel> accelerometerData)
    {
      using (var writer = new StreamWriter(csvBaseOutputPath + csvSessionFolderName + csvAccelerometerOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<AccelerometerMap>();
        csv.WriteRecords(accelerometerData);
      }
    }

    public void WriteGyroscopeDataToCsvFile(List<GyroscopeModel> gyroscopeData)
    {
      using (var writer = new StreamWriter(csvBaseOutputPath + csvSessionFolderName + csvGyroscopeOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<GyroscopeMap>();
        csv.WriteRecords(gyroscopeData);
      }
    }

    public void WriteThermocoupleDataToCsvFile(List<ThermocoupleModel> thermocoupleData)
    {
      using (var writer = new StreamWriter(csvBaseOutputPath + csvSessionFolderName + csvThermocoupleOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<ThermocoupleMap>();
        csv.WriteRecords(thermocoupleData);
      }
    }

    public void WriteAltimeterDataToCsvFile(List<AltimeterModel> altimeterData)
    {
      using (var writer = new StreamWriter(csvBaseOutputPath + csvSessionFolderName + csvAltimeterOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<AltimeterMap>();
        csv.WriteRecords(altimeterData);
      }
    }

    public void WriteGPSDataToCsvFile(List<GPSModel> gpsData)
    {
      using (var writer = new StreamWriter(csvBaseOutputPath + csvSessionFolderName + csvGPSOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<GPSMap>();
        csv.WriteRecords(gpsData);
      }
    }

    public void WriteAccelerometerDataToCsvFile()
    {
      using (var writer = new StreamWriter(csvBaseOutputPath + csvSessionFolderName + csvAccelerometerOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<AccelerometerMap>();
        csv.WriteRecords(accelerometerDataList);
        accelerometerDataList.Clear();
      }
    }

    public void WriteGyroscopeDataToCsvFile()
    {
      using (var writer = new StreamWriter(csvBaseOutputPath + csvSessionFolderName + csvGyroscopeOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<GyroscopeMap>();
        csv.WriteRecords(gyroscopeDataList);
        gyroscopeDataList.Clear();
      }
    }

    public void WriteThermocoupleDataToCsvFile()
    {
      using (var writer = new StreamWriter(csvBaseOutputPath + csvSessionFolderName + csvThermocoupleOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<ThermocoupleMap>();
        csv.WriteRecords(thermocoupleDataList);
        thermocoupleDataList.Clear();
      }
    }

    public void WriteAltimeterDataToCsvFile()
    {
      using (var writer = new StreamWriter(csvBaseOutputPath + csvSessionFolderName + csvAltimeterOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<AltimeterMap>();
        csv.WriteRecords(altimeterDataList);
        altimeterDataList.Clear();
      }
    }

    public void WriteGPSDataToCsvFile()
    {
      using (var writer = new StreamWriter(csvBaseOutputPath + csvSessionFolderName + csvGPSOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<GPSMap>();
        csv.WriteRecords(gpsDataList);
        gpsDataList.Clear();
      }
    }

    public void WriteDataFiles()
    {
      WriteAccelerometerDataToCsvFile();
      WriteGyroscopeDataToCsvFile();
      WriteThermocoupleDataToCsvFile();
      WriteAltimeterDataToCsvFile();
      WriteGPSDataToCsvFile();
    }
  }
}
