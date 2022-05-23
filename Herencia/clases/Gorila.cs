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

       public override void Pensar()
       {
           WriteLine("Tengo un pensamiento instintivo avanzado");
       }
    }
}