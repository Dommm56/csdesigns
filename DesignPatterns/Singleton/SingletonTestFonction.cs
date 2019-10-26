using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    class SingletonTestFonction
    {
        
        public static void SingletonDesign()
        {
            SingletonClass leSingleton = SingletonClass.SingleInstance;

            SingletonClass leSingleton2 = SingletonClass.SingleInstance;

            SingletonClass leSingleton3 = SingletonClass.SingleInstance;

            Console.ReadKey();
        }
    }
}
