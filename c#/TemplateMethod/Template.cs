using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    public abstract class Template
    {
        public abstract void Operation1();
        public abstract void Operation2();

        public void TemplateMethod()
        {
            Operation1();
            Operation2();
            Console.WriteLine("Already done the operation\n");
        }
    }

    public class ObjectA:Template
    {
        public override void Operation1()
        {
            Console.WriteLine("This is objectA.Operation1()");
        }

        public override void Operation2()
        {
            Console.WriteLine("This is objectA.Operation2()");
        }
    }

    public class ObjectB:Template
    {
        public override void Operation1()
        {
            Console.WriteLine("This is objectB.Operation1()");
        }

        public override void Operation2()
        {
            Console.WriteLine("This is objectB.Operation2()");
        }
    }
}
