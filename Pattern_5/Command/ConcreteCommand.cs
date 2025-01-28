using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_5.Command
{
    public class ConcreteCommand : ICommand
    {
        private readonly Receiver _receiver;
        public ConcreteCommand(Receiver receiver) => _receiver = receiver;
        public void Execute() => _receiver.PerformAction();
    }
}
