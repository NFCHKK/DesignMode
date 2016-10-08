using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyAlgorithm
{
    abstract class SuperAlgorithm
    {
       public abstract double AcceptInput(double Input1, double Input2);
    }

    class AddAlgorithm:SuperAlgorithm
    {
        public override double AcceptInput(double Input1, double Input2)
        {
            return Input1 + Input2;
        }
    }

    class MinusAlgorithm:SuperAlgorithm
    {
        public override double AcceptInput(double Input1, double Input2)
        {
            return Input1 - Input2;
        }
    }

    class MultiAlgorithm:SuperAlgorithm
    {
        public override double AcceptInput(double Input1, double Input2)
        {
            return Input1 * Input2;
        }
    }

    class DiviAlgorithm:SuperAlgorithm
    {
        public override double AcceptInput(double Input1, double Input2)
        {
            return Input1 / Input2;
        }
    }
}
