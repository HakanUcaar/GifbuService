using System;
using System.IO.Ports;

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
