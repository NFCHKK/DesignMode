using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//假设 product 必须有A, B, C, D, E 5个字母构成
namespace BuilderMode
{
    //单词类
    class WordProduct
    {
        IList<string> myProduct = new List<string>();
        public void Add(string part)
        {
            myProduct.Add(part);
        }
        public void Display()
        {
            Console.Write("WorldProduct: \n建造\n");
            string tempstr = "World is: ";
            foreach(string part in myProduct)
            {
                Console.WriteLine(part);
                tempstr += part;
            }
            Console.WriteLine(tempstr);
            Console.WriteLine("\n");
        }
    }

  //单词建造类
   abstract class ProductBuilder
    {
       public WordProduct InnerProduct;
       public abstract void BuildPart1();
       public abstract void BuildPart2();
       public abstract void BuildPart3();
       public abstract void BuildPart4();
       public abstract void BuildPart5();
       public WordProduct GetResult()
       {
           return InnerProduct;
       }
    }

    class Build_HELLO:ProductBuilder
    {
        public Build_HELLO()
        {
            base.InnerProduct = new WordProduct();
        }
        public override void BuildPart1()
        {
            base.InnerProduct.Add("h");
        }
        public override void BuildPart2()
        {
            base.InnerProduct.Add("e");
        }
        public override void BuildPart3()
        {
            base.InnerProduct.Add("l");
        }
        public override void BuildPart4()
        {
            base.InnerProduct.Add("l");
        }
        public override void BuildPart5()
        {
            base.InnerProduct.Add("o");
        }
    }

    class Build_APPLY:ProductBuilder
    {
        public Build_APPLY()
        {
            base.InnerProduct = new WordProduct();
        }
        public override void BuildPart1()
        {
            base.InnerProduct.Add("A");
        }

        public override void BuildPart2()
        {
            base.InnerProduct.Add("p");
        }

        public override void BuildPart3()
        {
            base.InnerProduct.Add("p");
        }

        public override void BuildPart4()
        {
            base.InnerProduct.Add("l");
        }

        public override void BuildPart5()
        {
            base.InnerProduct.Add("y");
        }
    }


}
