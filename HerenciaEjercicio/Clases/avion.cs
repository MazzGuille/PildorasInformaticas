namespace clases
{
    class Avion : Vehiculo
    {
        public Avion()
        {
            Volar = volar;
            Aterrizar = aterrizar;
        }

        public override void Conducir()
        {
            WriteLine("Soy capaz de ir por los cielos");
        }
        public void Encender()
        {
            ArrancarMotor();
        }

        public void  Apagar()
        {
            PararMotor();
        }

        public String Volar
        {
            get{ return volar; }
            set{ volar = value; }
        }

        public String Aterrizar
        {
            get{ return aterrizar; }
            set{ aterrizar = value; }
        }

        private String volar = "Estamos volando";
        private String aterrizar = "Estamos Aterrizando";

    }
}