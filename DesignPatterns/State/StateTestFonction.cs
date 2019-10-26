using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.State
{
    class StateTestFonction
    {
        public static void StateDesign()
        {
            Console.WriteLine("Etat 1 a 2:");
            State1 etat1 = new State1();
            Context context = new Context(etat1);
            context.Request();
            etat1.SimulateConnectionLoss();
            context.Request();

            Console.WriteLine("Etat 2 a 1:");
            State2 etat2 = new State2();
            Context context2 = new Context(etat2);
            context2.Request();
            etat2.SimulateConnectionLoss();
            context2.Request();


            Console.ReadKey();
        }

    }
}
