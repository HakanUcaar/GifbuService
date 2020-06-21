using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gifbu.Models
{
    public class GifbuAppModel
    {
        public string Message { get; set; }
        public string ImagePath { get; set; }
        public ArduinoSetttingModel Machine { get; set; }
    }
}
