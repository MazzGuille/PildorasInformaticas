using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces.Clases
{
     class Perros : Mamiferos, IMamiferosTerrestres
    {
        public Perros(String nombrePerro, int cantidadDeOjos) : base(nombrePerro, cantidadDeOjos)
        {

        }
        public void Ladrar()
        {
            WriteLine("Estoy ladrando");            
        }

        public int NumeroPatas()
        {
            return 4;
        }
    }
}