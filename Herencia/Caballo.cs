using static System.Console;


namespace Herencia 
{
    class Caballo : Mamiferos
    {
        public Caballo(String nombreCaballo, int cantidadDeOjos): base(nombreCaballo, cantidadDeOjos)
        {

        }
        public void Galopar()
        {
            WriteLine("Soy capaz de galopar");
        }
    }
}