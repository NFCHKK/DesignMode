using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    class Person
    {
        private string myName;
        private string myCloth;
        public Person(string strname)
        {
            myName = strname;
            myCloth = "I am wearing : ";
        }

        public void DecorateMyself(string strCloth)
        {
            if (myCloth.Length != 0)
            {
                myCloth += "\n";
            }
            myCloth += strCloth;
            
        }
        public void show()
        {
           string strMe = "I am ";
            strMe += myName;
            Console.WriteLine(strMe);
            Console.WriteLine(myCloth);
        }
    }
}
