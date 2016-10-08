using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateSpace;

namespace FactorySpace
{
    class Factory
    {
        public SuperCalc CreateCalc(string strCalcType)
        {
            SuperCalc InnerCalc = null;
            switch(strCalcType)
            {
                case "+":
                    InnerCalc = new AddCalc();
                    break;
                case "-":
                    InnerCalc = new MinusCalc();
                    break;
                case "*":
                    InnerCalc = new MultiCalc();
                    break;
                case "/":
                    InnerCalc = new DiviCalc();
                    break;
                default:
                    break;
            }
            return InnerCalc;
        }
    }
}
