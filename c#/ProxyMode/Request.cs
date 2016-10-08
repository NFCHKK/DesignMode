using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyMode
{
    interface sendgift
    {
       void SayHello();
       void SendFlower();
       void SendCake();
    }

    //被请求者
    class Requested
    {
        public string strName;
        public Requested(string name)
        {
            strName = name;
        }
    }

    //请求者
    class Request:sendgift
    {
        private Requested myRequested;
        public Request(Requested Req)
        {
            myRequested = Req;
        }
        public void SayHello()
        {
            Console.WriteLine("Hi {0}", myRequested.strName);
        }
        public void SendFlower()
        {
            Console.WriteLine("Hi {0}, give you flower, hope you will like.", myRequested.strName);
        }
        public void SendCake()
        {
            Console.WriteLine("Hi {0}, give you cake, hope you will like it.", myRequested.strName);
        }
    }

    //代理
    class Proxy:sendgift
    {
        private Request myProxy;
        public Proxy(Requested Req)
        {
            myProxy = new Request(Req);
        }
        public void SayHello()
        {
            myProxy.SayHello();
        }
        public void SendFlower()
        {
            myProxy.SendFlower();
        }
        public void SendCake()
        {
            myProxy.SendCake();
        }
    }
}
