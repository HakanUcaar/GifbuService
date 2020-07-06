using Dakota.Machine;
using System;
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
