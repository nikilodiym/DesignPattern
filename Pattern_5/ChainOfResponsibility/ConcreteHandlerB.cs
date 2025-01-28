using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_5.ChainOfResponsibility
{
    public class ConcreteHandlerB : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "B")
            {
                Console.WriteLine("ConcreteHandlerB handled the request");
            }
            else
            {
                NextHandler?.HandleRequest(request);
            }
        }
    }
}
