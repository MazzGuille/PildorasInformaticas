namespace Herencia
{
    class Humano : Mamiferos
    {
        public Humano( String nombreHumano, int cantidadDeOjos) : base(nombreHumano, cantidadDeOjos)
        {

        }
        public override void Pensar()
        {
            WriteLine("Soy capaz de pensar instintiva y logicamente");
            
        }
    }
}