using static System.Console;


namespace Herencia
{
    class Gorila : Mamiferos
    {
        public Gorila(String nombreGorila, int cantidadDeOjos): base(nombreGorila, cantidadDeOjos)
        {

        }
       public void Trepar()
       {
           WriteLine("Soy capaz de trepar");
       } 
    }
}