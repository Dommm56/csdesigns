using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class ShapeFactory
    {

        public IShape GetShape(String aShape)
        {
            switch (aShape)
            {
                case "Square": return new Square();

                case "Circle": return new Circle();

                case "Triangle": return new Triangle();

                default: return null;
            }
        }
        

}
}
