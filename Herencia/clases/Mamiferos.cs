namespace Herencia
{
    class Mamiferos
    {
        //public Mamiferos()
        //{

        //}

        public Mamiferos(String nombre, int ojos)
        {
            nombreSerVivo = nombre;
            numeroDeOjos = ojos;
        }
        protected void Respirar()
        {
            WriteLine("Soy capaz de respirar");
        }

        public virtual void Pensar()
        {
            WriteLine("Pensamiento basico e instintivo");
        }

        public void CuidarCrias()
        {
            WriteLine("Cuido de mis crias hasta que se valgan por si mismos");
        }

        public void getNombre()
        {
            WriteLine($"El nombre del ser vivo es: {nombreSerVivo}");
        }

        public void getOjos()
        {
            WriteLine($"El ser vivo tiene {numeroDeOjos} ojos");
        }

        private String nombreSerVivo;

        private int numeroDeOjos;
    }
}