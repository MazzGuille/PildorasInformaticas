Random numero = new Random();

int aleatorio = numero.Next(0, 100);

int minunumero;

int intentos = 0;

Console.WriteLine("Introduce un número entre 0 y 100");


do
{
    intentos++;

    try
    {

        minunumero = int.Parse(Console.ReadLine());
    }
   
    catch (Exception e) when (e.GetType()!=typeof(FormatException))
    {
        Console.WriteLine("Has ingresado un valor fuera de rango, se fijara el numero a -1, intenta de nuevo por favor.");
        Console.WriteLine(e.Message);
        minunumero = -1;
    }

     catch(FormatException e)
    {
        Console.WriteLine("Has introducido texto, se fijara el numero a -1, intenta de nuevo por favor.");
        Console.WriteLine(e.Message);
        minunumero = -1;
    }
    
    if (minunumero > aleatorio) Console.WriteLine("El número es más pequeño");

    if (minunumero < aleatorio) Console.WriteLine("El número es más grande");

} while (minunumero != aleatorio);

Console.WriteLine($"Correcto! Has necesitado {intentos} intentos para acertar");

Console.WriteLine("A partir de esta linea continua el programa");