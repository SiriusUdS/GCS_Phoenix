using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Exception
{
  internal class NoSerialPortConnectedException : System.Exception
  {
    public NoSerialPortConnectedException() { }

    public NoSerialPortConnectedException(string message) : base(message) { }

    public NoSerialPortConnectedException(string message, System.Exception inner) : base(message, inner) { }
  }
}
