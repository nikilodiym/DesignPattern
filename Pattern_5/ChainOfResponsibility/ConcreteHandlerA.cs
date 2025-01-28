using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_5.ChainOfResponsibility
{
    public class ConcreteHandlerA : Handler
    {
        public override void HandleRequest(string request)
        {
            if (request == "A")
            {
                Console.WriteLine("ConcreteHandlerA handled the request");
            }
            else
            {
                NextHandler?.HandleRequest(request);
            }
        }
    }
}
