using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifbu.Models
{
    public class ArduinoSetttingModel
    {
        public Guid Id { get; set; }
        public string PortName { get; set; }
        public int BaudRate { get; set; }
        public Parity Parity { get; set; }
    }
}
