using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASLKeyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("typing...");
                var test = new Keyboard();
                test.SendInput(Keyboard.ScanCodeShort.KEY_0);
                Thread.Sleep(1000);
            }
        }
    }
}
