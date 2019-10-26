using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class FactoryTestFonction
    {
        public static void FactoryDesign()
        {
            var factory = new ShapeFactory(); //creation of a shapeFactory
            IShape aSquare = factory.GetShape("Square");
            IShape aCircle = factory.GetShape("Circle");
            IShape aTriangle = factory.GetShape("Triangle");
            List<IShape> shapeList = new List<IShape>();
            shapeList.Add(aSquare);
            shapeList.Add(aCircle);
            shapeList.Add(aTriangle);

            foreach (var shape in shapeList)
            {
                shape.Draw();

            }

            Console.ReadKey();
        }
    }
}
