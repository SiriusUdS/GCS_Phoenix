using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GCS_Phoenix.Exception
{
  internal class SerialPortClosedException : System.Exception
  {
    public SerialPortClosedException() { }

    public SerialPortClosedException(string message) : base(message) { }

    public SerialPortClosedException(string message, System.Exception inner) : base(message, inner) { }
  }
}
