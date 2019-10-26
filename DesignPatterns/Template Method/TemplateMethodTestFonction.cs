using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Template_Method
{
    class TemplateMethodTestFonction
    {
        public static void TemplateMethodDesign()
        {
            AbstractClassOperations classA = new ClassA();
            classA.TemplateMethod();

            AbstractClassOperations classB = new ClassB();
            classB.TemplateMethod();


            Console.ReadKey();
        }

    }
}
