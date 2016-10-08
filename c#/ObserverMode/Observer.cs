using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverMode
{
    class StockObserver
    {
        private string name;
        private Subject sub;

        public StockObserver(string strname, Subject sub)
        {
            this.name = strname;
            this.sub = sub;
        }

        public void CloseStockObserver()
        {
            Console.WriteLine("{0} {1} close stock screen continue to work", sub.subState, name);
        }
    }

    class NBAObserver
    {
        private string name;
        private Subject sub;

        public NBAObserver(string strname, Subject sub)
        {
            this.name = strname;
            this.sub = sub;
        }

        public void CloseNBAObserver()
        {
            Console.WriteLine("{0} {1} close NBA screen continue to work", sub.subState, name);
        }
    }
}
