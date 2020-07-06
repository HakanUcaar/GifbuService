using Dakota.Machine;
using System;

namespace Gifbu.Machines.Movements
{
    public class OtherButtonPushMovement : AbstractMovement
    {
        public OtherButtonPushMovement(IMachine Machine) : base(Machine, "OtherUserPressed")
        {
            OnReceiveData += ReceiveData; 
        }

        public void ReceiveData(IMachine Sender, object Data)
        {
            Console.WriteLine(Sender.Name + String.Format(" Okunan Veri : {0}",Data.ToString()));
            Gifbulib.WebSocketClient.SendData(Data.ToString());            
        }
    }
}
