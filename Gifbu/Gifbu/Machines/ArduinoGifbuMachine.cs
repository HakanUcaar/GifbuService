using Dakota.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gifbu.Machines.Movements;

namespace Gifbu.Machines
{
    public class ArduinoGifbuMachine : AbstractMachine
    {
        public ArduinoGifbuMachine(string Name) : base(new Guid().ToString(), Name)
        {
            NewMovement<OtherButtonPushMovement>();
        }
    }
}
