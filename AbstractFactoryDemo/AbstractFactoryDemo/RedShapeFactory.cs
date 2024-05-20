using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class RedShapeFactory : IShapeFactory
    {
        public ICircle CreateCircle()
        {
            return new RedCircle();
        }

        public ISquare CreateSquare()
        {
            return new RedSquare();
        }
    }
}
