using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorMode
{
    abstract class DecorateCloth
    {
        public Person myPeople;
        public virtual void SetPerson(Person People)
        {
            if (People != null)
            {
                myPeople = People;
            }
        }
        abstract public void Decorate(DecorateCloth DecorateObject);
        abstract public void show();
    }

    class T_Shirt:DecorateCloth
    {
        public override void Decorate(DecorateCloth DecorateObject)
        {
            base.myPeople = DecorateObject.myPeople;
            base.myPeople.DecorateMyself("T-shit");
        }
        public override void show()
        {
            base.myPeople.show();
        }
    }

    class Hat:DecorateCloth
    {
        public override void Decorate(DecorateCloth DecorateObject)
        {
            base.myPeople = DecorateObject.myPeople;
            base.myPeople.DecorateMyself("Hat");
        }
        public override void show()
        {
            base.myPeople.show();
        }
    }

    class Pants:DecorateCloth
    {
        public override void Decorate(DecorateCloth DecorateObject)
        {
            base.myPeople = DecorateObject.myPeople;
            base.myPeople.DecorateMyself("Pants");
        }
        public override void show()
        {
            base.myPeople.show();
        }
    }

    class Sneaker:DecorateCloth
    {
        public override void Decorate(DecorateCloth DecorateObject)
        {
            base.myPeople = DecorateObject.myPeople;
            base.myPeople.DecorateMyself("Sneaker");
        }
        public override void show()
        {
            base.myPeople.show();
        }
    }
}
