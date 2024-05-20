using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class BlueShapeFactory : IShapeFactory
    {
        public ICircle CreateCircle()
        {
            return new BlueCircle();
        }

        public ISquare CreateSquare()
        {
            return new BlueSquare();
        }
    }
}
