using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDemo
{
    public class ReferencedClass : ICloneable
    {
        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
