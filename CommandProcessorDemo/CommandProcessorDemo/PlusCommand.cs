using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandProcessorDemo
{
    public class PlusCommand : ICommand<IFacade>
    {
        public bool IsCompensabe => true;

        public IFacade? Reciever { get; set; }

        public double X { get; set; }

        public void Compensate()
        {
            Reciever?.Minus(X);
            Reciever?.RemoveLastLogMessage();
            Reciever?.RemoveLastLogMessage();
        }

        public void Execute()
        {
            Reciever?.Plus(X);
        }
    }
}
