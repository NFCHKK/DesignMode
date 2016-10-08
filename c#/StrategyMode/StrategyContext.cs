using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyAlgorithm;

namespace StrategyContext
{
    class ClassContext
    {
        public SuperAlgorithm m_InnerAlgorithm;

        public ClassContext(SuperAlgorithm Alg)
        {
            this.m_InnerAlgorithm = Alg;
        }

        public ClassContext CreateContext(SuperAlgorithm Alg)
        {
            this.m_InnerAlgorithm = Alg;
            return this;
        }

        public double GetResult(double Input1, double Input2)
        {
            return m_InnerAlgorithm.AcceptInput(Input1, Input2);
        }
    }
}
