using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_5.ChainOfResponsibility
{
    public abstract class Handler
    {
        protected Handler? NextHandler;
        public void SetNext(Handler next) => NextHandler = next;
        public abstract void HandleRequest(string request);
    }

}
