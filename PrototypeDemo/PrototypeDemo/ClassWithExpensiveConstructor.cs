using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDemo
{
    public class ClassWithExpensiveConstructor : ICloneable
    {
        ReferencedClass rc = new ReferencedClass();
        public ClassWithExpensiveConstructor() {
            Console.WriteLine("Looooooooooooooooooooong initialization");
        }

        public object Clone()
        {
            var result = (ClassWithExpensiveConstructor)this.MemberwiseClone();
            result.rc = (ReferencedClass)rc.Clone();
            return result;
        }
    }
}
