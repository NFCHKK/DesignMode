using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderMode
{
    class Director
    {
        public void BuildWorld(ProductBuilder pb)
        {
            pb.BuildPart1();
            pb.BuildPart2();
            pb.BuildPart3();
            pb.BuildPart4();
            pb.BuildPart5();
        }
    }
}
