System.IO.StreamReader archivo = null;
try
{
    string linea;

    int contador = 0;

    string path = @"C:\Users\HP-ProBook 6460B\Desktop\programing\tarea.txt";

    archivo = new System.IO.StreamReader(path);

    while ((linea = archivo.ReadLine()) != null)
    {
        Console.WriteLine(linea);
        contador++;
    }
}

catch (Exception e)
{
    Console.WriteLine("Error: " + e.Message);
}


finally
{
    if (archivo != null)
    {
        archivo.Close();
    }

    Console.WriteLine("El archivo se ha cerrado correctamente");

}


