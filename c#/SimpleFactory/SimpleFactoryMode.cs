using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactorySpace;
using CalculateSpace;

namespace MainProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory myCalcFac = new Factory();
            SuperCalc myCalc = myCalcFac.CreateCalc("+");
            double result = myCalc.AcceptInput(5.0, 9.0);
            Console.WriteLine("5.0 + 9.0 = {0}", result);
            Console.ReadKey();
        }
    }
}


