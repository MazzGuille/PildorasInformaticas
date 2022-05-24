using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Interfaces.Clases
{
    class Ballenas : Mamiferos
    {
        public Ballenas(string nombre, int ojos) : base(nombre, ojos) //base llama al constructor de la clase padre
        {

        }

        public void Nadar()
        {
            WriteLine("Soy capaz de nadar");
        }
    }
}