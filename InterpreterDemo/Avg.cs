using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpreterDemo
{
    public class Avg : IExpression
    {
        public Avg(IEnumerable<IExpression> operands)
        {
            Operands = operands;
        }

        public IEnumerable<IExpression> Operands { get; init; }

        public TypedValue Interpret(IDictionary<string, TypedValue> context)
        {
            var interpretedOperands = Operands.Select(o => o.Interpret(context));
            var returnInt = interpretedOperands.All(o => o.Type == "int");
            if(returnInt)  
                return new TypedValue(interpretedOperands.Select(o => (int)o.Value).Sum() / Operands.Count(), "int");
            return new TypedValue(interpretedOperands.Select(o => (double)o.Value).Sum() / Operands.Count(), "float");
        }
    }
}
