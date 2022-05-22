namespace clases;

class Empleados
{
    public Empleados(String nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }

    public String getInfo()
    {
        return $"Info del empleado\nNombre: {nombre}\nEdad: {edad}\n";
    }
    private String nombre;
    private int edad;
}


