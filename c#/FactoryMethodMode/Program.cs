using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodMode
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryMethod myFactory = new StudentFactory();
            DoGoodWork myStudent = myFactory.CreateDoGoodWorkPerson("LiuXiao");
            myStudent.DoWork();
            Console.ReadKey();
        }
    }
}
