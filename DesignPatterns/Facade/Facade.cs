using DesignPatterns.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    class Facade
    {
        private FormeSquare _Square;
        private FormeCircle _Circle;
        private FormeTriangle _Triangle;

        public Facade()
        {
            _Square = new FormeSquare();
            _Circle = new FormeCircle();
            _Triangle = new FormeTriangle();
        }

        public void CallAllDraw()
        {
            _Square.DrawSquare();
            _Circle.DrawCircle();
            _Triangle.DrawTriangle();
        }

    }
}
