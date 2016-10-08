using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyAlgorithm;
using StrategyContext;

namespace StrategyAlgorithm
{
    class StrategyMode
    {
        static void Main(string[] args)
        {
            ClassContext myComtext = null;
            Console.WriteLine("Please Input the first Number: ");
            string strInputNumber1 = Console.ReadLine();
            Console.WriteLine("Please Input your Operator( +, -, *, /): ");
            string strOperator = Console.ReadLine();
            Console.WriteLine("Please Input your second number: ");
            string strInputNumber2 = Console.ReadLine();

            switch(strOperator)
            {
                case "+":
                    myComtext = new ClassContext(new AddAlgorithm());
                    break;
                case "-":
                    myComtext = new ClassContext(new MinusAlgorithm());
                    break;
                case "*":
                    myComtext = new ClassContext(new MultiAlgorithm());
                    break;
                case "/":
                    myComtext = new ClassContext(new DiviAlgorithm());
                    break;
                default:
                    break;
            }
            double result = myComtext.GetResult(Convert.ToDouble(strInputNumber1), Convert.ToDouble(strInputNumber2));
            Console.WriteLine("{0} {1} {2} = {3}", strInputNumber1, strOperator, strInputNumber2, result);
            Console.ReadKey();

        }
    }
}
