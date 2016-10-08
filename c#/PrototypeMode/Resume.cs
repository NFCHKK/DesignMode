using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMode
{
    class workExperiance:ICloneable
    {
        public string strCompanyName;
        public string strWorkDate;

        public object Clone()
        {
            return (object)this.MemberwiseClone();
        }
    }
    class Resume:ICloneable
    {
        public string strName;
        public string strSex;
        public string strAge;
        public workExperiance myWork;
        public Object Clone()
        {
            return (object)this.MemberwiseClone();
        }

        public void SetName(string name)
        {
            strName = name;
        }

        public void SetSex(string sex)
        {
            strSex = sex;
        }

        public void SetAge(string age)
        {
            strAge = age;
        }

        public void SetWork(workExperiance work)
        {
            myWork = work;
        }

        public void Display()
        {
            Console.WriteLine("Name: {0} \nSex: {1} \nAge: {2} ", strName, strSex, strAge);
            Console.WriteLine("Work experiance: {0} {1}", myWork.strCompanyName, myWork.strWorkDate);
            Console.WriteLine("\n");
        }
    }
}
