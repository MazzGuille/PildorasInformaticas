namespace clases
{
    class Vehiculo
    {
        protected void ArrancarMotor()
        {
            WriteLine("El motor ha encendido");
        }

        protected void PararMotor()
        {
            WriteLine("El motor se ha detenido");
        }

        public virtual void Conducir()
        {
            WriteLine("Puedo conducir cualquier vehiculo");
        }
    }
}