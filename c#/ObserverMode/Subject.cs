using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ObserverMode
{
    delegate void EventObserver(); 
    interface Subject
    {
        void Notify();
        string subState
        {
            get;
            set;
        }
    }

    class Boss:Subject
    {
        public event EventObserver update;

        private string action;
        public void Notify()
        {
            update();
        }

        public string subState
        {
            get { return action;}
            set {action = value;}
         }
    }

    class Secretary:Subject
    {
        public event EventObserver update;
        private string action;
        public void Notify()
        {
            update();
        }

        public string subState
        {
            get { return action; }
            set { action = value; }
        }
    }
}
