using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces.Clases
{
    class Gorilas : Mamiferos, IMamiferosTerrestres
    {
        public Gorilas(String nombreGorila, int cantidadDeOjos): base(nombreGorila, cantidadDeOjos)
        {

        }
       public void Trepar()
       {
           WriteLine("Soy capaz de trepar");
       } 

       public override void Pensar()
       {
           WriteLine("Tengo un pensamiento instintivo avanzado");
       }

       public int NumeroPatas()
       {
           return 2;
       }
    }
}