using static System.Console;


namespace Herencia
{
    class Humano : Mamiferos
    {
        public Humano( String nombreHumano, int cantidadDeOjos) : base(nombreHumano, cantidadDeOjos)
        {

        }
        public void Pensar()
        {
            WriteLine("Soy capaz de pensar");
        }
    }
}