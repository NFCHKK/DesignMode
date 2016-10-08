using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Requested schoolGirl = new Requested("Lucy");
            Proxy schoolBoy = new Proxy(schoolGirl);

            schoolBoy.SayHello();
            schoolBoy.SendFlower();
            schoolBoy.SendCake();

            Console.ReadKey();
        }
    }
}
