namespace clases
{
    class Auto : Vehiculo
    {
        public Auto()
        {
            AndarPorLaCiudad = andarPorLaCiudad;
        }

        public override void Conducir()
        {
            WriteLine("Soy capaz de conducir por la ciudad");
        }

        public void  Encender()
        {
            ArrancarMotor();
        }

        public void  Apagar()
        {
            PararMotor();
        }

        public String AndarPorLaCiudad
        {
            get { return andarPorLaCiudad; }
            set { andarPorLaCiudad = value; }
        }
        private String andarPorLaCiudad = "Tamos paseando";
        
    }
}