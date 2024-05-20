using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class ShapesClient
    {
        private IShapeFactory shapeFactory;

        public ShapesClient(IShapeFactory shapeFactory)
        {
            this.shapeFactory = shapeFactory;
        }

        public void UseShapes()
        {
            Console.WriteLine(shapeFactory.CreateCircle());
            Console.WriteLine(shapeFactory.CreateSquare());
        }
    }
}
