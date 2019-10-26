using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade
{
    class FacadeTestFonction
    {
        public static void FacadeDesign()
        {
            Facade facade = new Facade(); 
            facade.CallAllDraw();       //ici on appel des fonctions qui n'ont pas le meme nom,
            //dans des classes differentes


            Console.ReadKey();
        }


    }
}
