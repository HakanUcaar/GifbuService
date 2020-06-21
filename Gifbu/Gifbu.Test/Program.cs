using Gifbu.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gifbu.Test
{
    class Program
    {
        static void Main(string[] args)
        {

            //GifbuAppModel Model = new GifbuAppModel();
            //Model.ImagePath = @"C:\Users\V-hak\OneDrive\Masaüstü\Transparent gifs\meow.gif";
            //Model.Message = "Bokubok";
            //Model.Machine = new ArduinoSetttingModel();
            //Model.Machine.PortName = "3";
            //Model.Machine.Parity = System.IO.Ports.Parity.None;
            //Model.Machine.BaudRate = 9600;

            Gifbulib Test = new Gifbulib();
            var Result = Test.Connect("./data.json").Result;
            Console.WriteLine(Result);
            Console.ReadLine();
        }
    }
}
