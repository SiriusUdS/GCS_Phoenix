using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Exception
{
  internal class CannotConnectSerialPortException : System.Exception
  {
    public CannotConnectSerialPortException() { }

    public CannotConnectSerialPortException(string message) : base(message) { }

    public CannotConnectSerialPortException(string message, System.Exception inner) : base(message, inner) { }
  }
}
