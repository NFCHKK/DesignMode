using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Resume myResume1 = new Resume();
            myResume1.SetName("Danny");
            myResume1.SetSex("man");
            myResume1.SetAge("26");
            
            workExperiance FirstWork = new workExperiance();
            FirstWork.strWorkDate = "2010-2011";
            FirstWork.strCompanyName = "Google";

            workExperiance SecondWork = new workExperiance();
            SecondWork.strWorkDate = "2011-2012";
            SecondWork.strCompanyName = "Microsoft";

            myResume1.SetWork(FirstWork);

            myResume1.Display();

            Resume myResume2 = (Resume)myResume1.Clone();
            myResume2.SetWork(SecondWork);
            myResume2.Display();

            Console.ReadKey();
        }
    }
}
