using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces.Clases
{
    class Caballos : Mamiferos, IMamiferosTerrestres, ISaltoConPatas
    {
        public Caballos(String nombreCaballo, int cantidadDeOjos) : base(nombreCaballo, cantidadDeOjos)
        {

        }
        public void Galopar()
        {
            WriteLine("Soy capaz de galopar");
        }

         int IMamiferosTerrestres.NumeroPatas()
        {
            return 4;
        }

        int ISaltoConPatas.NumeroPatas()
        {
            return 2;
        }
    }

}