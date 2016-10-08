using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Director myDirector = new Director();
            //具体对象的模块建造
            ProductBuilder wHello = new Build_HELLO();
            ProductBuilder wApply = new Build_APPLY();

            //指挥建造对象
            myDirector.BuildWorld(wHello);
            myDirector.BuildWorld(wApply);

            WordProduct myHello = wHello.GetResult();
            WordProduct myApply = wApply.GetResult();

            myHello.Display();
            myApply.Display();

            Console.ReadKey();
        }
    }
}
