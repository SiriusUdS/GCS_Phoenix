using System.Globalization;

using CsvHelper;

using GCS_Phoenix.Communication.Packet;
using GCS_Phoenix.Models.Sensors;

namespace GCS_Phoenix.Managers
{
  internal class CsvFileManager
  {
    private static string csvOutputPath = Directory.GetCurrentDirectory() + "\\Data";
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

    public CsvFileManager()
    {
      Initialize();
    }

    public void AddAccelerometerData(AccelerometerPacket packet)
    {
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
      altimeterDataList.Add(new AltimeterModel
      {
        TimeStamp_ms = packet.getTimeStamp_ms(),
        Altitude_m = packet.getAltitude_m()
      });
    }

    public void AddGyroscopeData(GyroscopePacket packet)
    {
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
      thermocoupleDataList.Add(new ThermocoupleModel
      {
        TimeStamp_ms = packet.getTimeStamp_ms(),
        Temperature_C = packet.getTemperature_C()
      });
    }

    public static void Initialize()
    {
      InitializeOutputDirectory();
      InitializeCsvFileHeaders();
    }

    private static void InitializeOutputDirectory()
    {
      if (!Directory.Exists(csvOutputPath))
      {
        Directory.CreateDirectory(csvOutputPath);
      }
    }

    private static void InitializeCsvFileHeaders()
    {
      if (!File.Exists(csvOutputPath + "\\AccelerometerData.csv"))
      {
        using (StreamWriter sw = new StreamWriter(csvOutputPath + "\\AccelerometerData.csv"))
        {
          using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
          {
            cw.Context.RegisterClassMap<AccelerometerMap>();
            cw.WriteHeader<AccelerometerModel>();
            cw.NextRecord();
          }
        }
      }
      if (!File.Exists(csvOutputPath + "\\AltimeterData.csv"))
      {
        using (StreamWriter sw = new StreamWriter(csvOutputPath + "\\AltimeterData.csv"))
        {
          using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
          {
            cw.Context.RegisterClassMap<AltimeterMap>();
            cw.WriteHeader<AltimeterModel>();
            cw.NextRecord();
          }
        }
      }
      if (!File.Exists(csvOutputPath + "\\GyroscopeData.csv"))
      {
        using (StreamWriter sw = new StreamWriter(csvOutputPath + "\\GyroscopeData.csv"))
        {
          using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
          {
            cw.Context.RegisterClassMap<GyroscopeMap>();
            cw.WriteHeader<GyroscopeModel>();
            cw.NextRecord();
          }
        }
      }
      if (!File.Exists(csvOutputPath + "\\GPSData.csv"))
      {
        using (StreamWriter sw = new StreamWriter(csvOutputPath + "\\GPSData.csv"))
        {
          using (CsvWriter cw = new CsvWriter(sw, CultureInfo.InvariantCulture))
          {
            cw.Context.RegisterClassMap<GPSMap>();
            cw.WriteHeader<GPSModel>();
            cw.NextRecord();
          }
        }
      }
      if (!File.Exists(csvOutputPath + "\\ThermocoupleData.csv"))
      {
        using (StreamWriter sw = new StreamWriter(csvOutputPath + "\\ThermocoupleData.csv"))
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

    public static void WriteAccelerometerDataToCsvFile(List<AccelerometerModel> accelerometerData)
    {
      using (var writer = new StreamWriter(csvOutputPath + csvAccelerometerOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<AccelerometerMap>();
        csv.WriteRecords(accelerometerData);
      }
    }

    public static void WriteGyroscopeDataToCsvFile(List<GyroscopeModel> gyroscopeData)
    {
      using (var writer = new StreamWriter(csvOutputPath + csvGyroscopeOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<GyroscopeMap>();
        csv.WriteRecords(gyroscopeData);
      }
    }

    public static void WriteThermocoupleDataToCsvFile(List<ThermocoupleModel> thermocoupleData)
    {
      using (var writer = new StreamWriter(csvOutputPath + csvThermocoupleOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<ThermocoupleMap>();
        csv.WriteRecords(thermocoupleData);
      }
    }

    public static void WriteAltimeterDataToCsvFile(List<AltimeterModel> altimeterData)
    {
      using (var writer = new StreamWriter(csvOutputPath + csvAltimeterOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<AltimeterMap>();
        csv.WriteRecords(altimeterData);
      }
    }

    public static void WriteGPSDataToCsvFile(List<GPSModel> gpsData)
    {
      using (var writer = new StreamWriter(csvOutputPath + csvGPSOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<GPSMap>();
        csv.WriteRecords(gpsData);
      }
    }

    public void WriteAccelerometerDataToCsvFile()
    {
      using (var writer = new StreamWriter(csvOutputPath + csvAccelerometerOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<AccelerometerMap>();
        csv.WriteRecords(accelerometerDataList);
        accelerometerDataList.Clear();
      }
    }

    public void WriteGyroscopeDataToCsvFile()
    {
      using (var writer = new StreamWriter(csvOutputPath + csvGyroscopeOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<GyroscopeMap>();
        csv.WriteRecords(gyroscopeDataList);
        gyroscopeDataList.Clear();
      }
    }

    public void WriteThermocoupleDataToCsvFile()
    {
      using (var writer = new StreamWriter(csvOutputPath + csvThermocoupleOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<ThermocoupleMap>();
        csv.WriteRecords(thermocoupleDataList);
        thermocoupleDataList.Clear();
      }
    }

    public void WriteAltimeterDataToCsvFile()
    {
      using (var writer = new StreamWriter(csvOutputPath + csvAltimeterOutputFile))
      using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
      {
        csv.Context.RegisterClassMap<AltimeterMap>();
        csv.WriteRecords(altimeterDataList);
        altimeterDataList.Clear();
      }
    }

    public void WriteGPSDataToCsvFile()
    {
      using (var writer = new StreamWriter(csvOutputPath + csvGPSOutputFile))
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
