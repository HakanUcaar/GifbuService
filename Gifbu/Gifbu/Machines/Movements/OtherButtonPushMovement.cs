using Dakota.Machine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gifbu.Machines.Movements
{
    public class OtherButtonPushMovement : AbstractMovement
    {
        public OtherButtonPushMovement(IMachine Machine) : base(Machine, "OtherUserPressed")
        {
            OnReceiveData += ReceiveData; 
        }

        public async void ReceiveData(IMachine Sender, object Data)
        {
            Console.WriteLine(Sender.Name + " Okunan Veri : ButonAPushed");
            Gifbulib.WebSocketClient.SendData(Data.ToString());            
        }
    }
}
