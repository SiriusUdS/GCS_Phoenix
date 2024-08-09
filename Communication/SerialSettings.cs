using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Communication
{
  internal class SerialSettings
  {
    private string _portName = String.Empty;
    private int _baudRate = 9600;
    private Parity _parity = Parity.None;
    private int _dataBits = 8;
    private StopBits _stopBits = StopBits.None;

    public string PortName { get => _portName; set => _portName = value; }
    public int BaudRate { get => _baudRate; set => _baudRate = value; }
    public Parity Parity { get => _parity; set => _parity = value; }
    public int DataBits { get => _dataBits; set => _dataBits = value; }
    public StopBits StopBits { get => _stopBits; set => _stopBits = value; }

    public SerialSettings() { }

    public SerialSettings(string portName, int baudRate)
    {
      _portName = portName;
      _baudRate = baudRate;
      _parity = Parity.None;
      _dataBits = 8;
      _stopBits = StopBits.One;
    }

    public SerialSettings(string portName, int baudRate, Parity parity, int dataBits, StopBits stopBits)
    {
      _portName = portName;
      _baudRate = baudRate;
      _parity = parity;
      _dataBits = dataBits;
      _stopBits = stopBits;
    }
  }
}
