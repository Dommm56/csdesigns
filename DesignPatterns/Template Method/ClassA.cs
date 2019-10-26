using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template_Method
{
    class ClassA : AbstractClassOperations
    {
        protected override void Operation2()
        {
            Console.WriteLine("Operation 2 of Class A");
        }

        protected override void Operation4()
        {
            Console.WriteLine("Operation 4 of Class A");
        }
    }
}
