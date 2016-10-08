using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMode
{
    abstract class DoGoodWork
    {
        public abstract void DoWork();
    }

    class Student:DoGoodWork
    {
        private string myName;
        public Student(string name)
        {
            myName = name;
        }
        public override void DoWork()
        {
            Console.WriteLine("Hi I am a student, my name is {0}, I am learing LiFeng to do good work", myName);
        }
    }

    class Volunter:DoGoodWork
    {
        private string myName;
        public Volunter(string name)
        {
            myName = name;
        }

        public override void DoWork()
        {
            Console.WriteLine("Hi I am a volunter, my name is {0}, I am learing LiFeng to do good work", myName);
        }
    }
}
