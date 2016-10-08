using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Boss boss = new Boss();
            boss.subState = "I am back";
            StockObserver LiMing = new StockObserver("LiMing", boss);

            boss.update += new EventObserver(LiMing.CloseStockObserver);

            boss.Notify();

            Console.ReadKey();
        }
    }
}
