using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoDemo
{
    internal partial class Calc
    {
        private Stack<CalcMemento> history = new Stack<CalcMemento>();
        public double Result { get; private set; }
        public void Plus(double x) {
            var memento = new CalcMemento(Result);
            history.Push(memento);
            Result += x; 
        }

        public void Undo()
        {
            if(history.Count == 0) return;
            Result = history.Pop().Result;
        }
    }
}
