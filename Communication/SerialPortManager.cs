using GCS_Phoenix.Exception;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Communication
{
  internal class SerialPortManager
  {
    private SerialPort _serialPort;

    public event EventHandler<byte[]>? DataReceived;

    public SerialPort Port { get => _serialPort; set => _serialPort = value; }

    public SerialPortManager(SerialSettings serialSettings)
    {
      _serialPort = new SerialPort(
        serialSettings.PortName,
        serialSettings.BaudRate,
        serialSettings.Parity,
        serialSettings.DataBits,
        serialSettings.StopBits
      );
      _serialPort.DataReceived += SerialPort_DataReceived;
    }

    public void Connect()
    {
      if (_serialPort is null)
      {
        throw new CannotConnectSerialPortException("Serial port is not selected.");
      }
      if (_serialPort.IsOpen)
      {
        return;
      }
      try
      {
        _serialPort.Open();
      } 
      catch (IOException e)
      {
        throw new CannotConnectSerialPortException(e.Message);
      }
    }

    public void Disconnect()
    {
      if (_serialPort == null)
      {
        throw new NoSerialPortConnectedException();
      }
      _serialPort.Close();
      _serialPort.Dispose();
    }

    public void Write(string data)
    {
      if (_serialPort is null)
      {
        throw new NoSerialPortConnectedException();
      }
      if (!_serialPort.IsOpen)
      {
        throw new SerialPortClosedException();
      }
      _serialPort.Write(data);
    }

    private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
    {
      int receivedData;
      receivedData = _serialPort.ReadByte();

      //AppendToSerialDataBox(receivedData.ToString());

      int packetSize = receivedData + 1;
      byte[] data = new byte[packetSize];
      data[0] = (byte)receivedData;

      for (int i = 1; i < packetSize; i++)
      {
        byte received = (byte)_serialPort.ReadByte();
        data[i] = received;
        DataReceived?.Invoke(this, data);
        //AppendToSerialDataBox(System.Text.Encoding.ASCII.GetString(_data));
      }
    }
  }
}
