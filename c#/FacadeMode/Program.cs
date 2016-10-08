using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Facade ExternalOper = new Facade();

            ExternalOper.Operation1();
            ExternalOper.Operation2();

            Console.ReadKey();
            
        }
    }
}
