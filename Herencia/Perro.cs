using static System.Console;


namespace Herencia
{
    class Perro : Mamiferos
    {
         public Perro(String nombrePerro, int cantidadDeOjos): base(nombrePerro, cantidadDeOjos)
        {

        }
        public void Ladrar()
        {
            WriteLine("Estoy ladrando");
        }
    }
}