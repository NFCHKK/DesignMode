using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeMode
{
    class subSystemOne
    {
        public void SubOperation()
        {
            Console.WriteLine("Sub-operation one\n");
        }
    }

    class subSystemtwo
    {
        public void SubOperation()
        {
            Console.WriteLine("Sub-operation two\n");
        }
    }

    class subSystemthree
    {
        public void SubOperation()
        {
            Console.WriteLine("Sub-operation three\n");
        }
    }
    class Facade
    {
        subSystemOne one;
        subSystemtwo two;
        subSystemthree three;

        public Facade()
        {
            one = new subSystemOne();
            two = new subSystemtwo();
            three = new subSystemthree();
        }
        public void Operation1()
        {
            one.SubOperation();
            two.SubOperation();
        }

        public void Operation2()
        {
            one.SubOperation();
            three.SubOperation();
        }
    }
}
