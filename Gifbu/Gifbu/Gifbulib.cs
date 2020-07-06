using Dakota.Client.WebSoket;
using Dakota.Receiver.SerialPort;
using Gifbu.Machines;
using Gifbu.Models;
using Newtonsoft.Json;
using System.IO;
using System.IO.Ports;
using System.Threading.Tasks;

namespace Gifbu
{
    public class Gifbulib
    {
        public static GifbuAppModel GifbuModel = null;
        public static SerialPortReceiver Receiver = new SerialPortReceiver(new ArduinoGifbuMachine("Gifbu Arduino Cihazı"));
        public static WebSocketClient WebSocketClient = new WebSocketClient();

        public async Task<object> Connect(string input)
        {
            return await Task.Run(() =>
            {
                GifbuModel = JsonConvert.DeserializeObject<GifbuAppModel>(File.ReadAllText(input));

                WebSocketClient.URI = "ws://localhost:13100";
                WebSocketClient.Connect();                

                Receiver.DisConnect();
                Receiver.PortName = "COM"+GifbuModel.Machine.PortName;
                Receiver.BaudRate = GifbuModel.Machine.BaudRate;
                Receiver.Parity = GifbuModel.Machine.Parity;
                Receiver.DataBits = 8;
                Receiver.StopBits = StopBits.One;
                Receiver.Handshake = Handshake.None;
                return Receiver.Connect();

            });
        }
    }
}
