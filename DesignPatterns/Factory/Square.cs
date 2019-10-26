using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Factory
{
    class Square : IShape
    {

        public void Draw()
        {
            Console.WriteLine("A Square Shape");
        }
    }
}
