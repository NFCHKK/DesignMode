using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Template obA = new ObjectA();
            obA.TemplateMethod();

            Template obB = new ObjectB();
            obB.TemplateMethod();

            Console.ReadKey();
        }
    }
}
