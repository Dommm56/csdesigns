using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template_Method
{
    abstract class AbstractClassOperations
    {
        protected void Operation1() => Console.WriteLine("Operation 1");

        protected abstract void Operation2();

        protected void Operation3() => Console.WriteLine("Operation 3");

        protected abstract void Operation4();

       public void TemplateMethod()
        {
            Operation1();
            Operation2(); //to be defined in subclass
            Operation3();
            Operation4();//to be defined in subclass
        }

    }
}
