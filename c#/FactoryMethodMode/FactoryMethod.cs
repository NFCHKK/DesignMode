using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMode
{
    interface FactoryMethod
    {
        DoGoodWork CreateDoGoodWorkPerson(string name);
    }

    class StudentFactory:FactoryMethod
    {
        private Student myStudent;
        public DoGoodWork CreateDoGoodWorkPerson(string name)
        {
            myStudent = new Student(name);
            return myStudent;
        }
    }

    class VolunterFactory:FactoryMethod
    {
        private Volunter myVolunter;
        public DoGoodWork CreateDoGoodWorkPerson(string name)
        {
            myVolunter = new Volunter(name);
            return myVolunter;
        }
    }
}
