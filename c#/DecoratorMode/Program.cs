using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    class Program
    {
        static void Main(string[] args)
        {
            Person MyClassmate = new Person("小明");
            Hat HistHat = new Hat();
            T_Shirt HisShirt = new T_Shirt();
            Pants HisPants = new Pants();
            Sneaker HisSneaker = new Sneaker();
            HistHat.SetPerson(MyClassmate);
            HistHat.Decorate(HistHat);
            HisShirt.Decorate(HistHat);
            HisPants.Decorate(HisShirt);
            HisSneaker.Decorate(HisPants);
            HisSneaker.show();
            Console.ReadKey();
        }
    }
}
