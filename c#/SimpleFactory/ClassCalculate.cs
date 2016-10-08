using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSpace
{
    abstract class SuperCalc 
    {
        public abstract double AcceptInput(double OperandA, double OpearandB); 
    }

    class AddCalc: SuperCalc
    {
        public override double AcceptInput(double OperandA, double OperandB)
        {
            return OperandA + OperandB;
        }
    }

    class MinusCalc:SuperCalc
    {
        public override double AcceptInput(double OperandA, double OperandB)
        {
            return OperandA - OperandB;
        }
    }

    class MultiCalc:SuperCalc
    {
        public override double AcceptInput(double OperandA, double OperandB)
        {
            return OperandA * OperandB;
        }
    }

    //Ignore OperandB = 0
    class DiviCalc:SuperCalc
    {
        public override double AcceptInput(double OperandA, double OperandB)
        {
            return OperandA / OperandB;
        }
    }
}
