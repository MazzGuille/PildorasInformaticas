using System;
/*
checked
{
    
int numero = int.MaxValue;
 
int resultado = numero + 20;
 
Console.WriteLine(resultado);

}
int numero2 = int.MaxValue;
 
int resultado2 = numero2 + 20;
 
Console.WriteLine(resultado2);
*/

//LANZAMIENTO DE EXCEPCIONES


var repeat = true;
while (repeat == true)
{
    Console.WriteLine("Introduce un número de mes");
    int mes = Convert.ToInt32(Console.ReadLine());
    if (mes == 1 || mes == 2 || mes == 3 || mes == 4 || mes == 5 || mes == 6 || mes == 7 || mes == 8 || mes == 9 || mes == 10 || mes == 11 || mes == 12)
    {
        repeat = false;
    }
    try
    {
        Console.WriteLine(NombreDelMes(mes));
    }
    catch (Exception e)
    {
        Console.WriteLine($"Ha ocurrido un error: {e.Message}\n Intentalo nuevamente");
        repeat = true;
    }   
}


Console.WriteLine("aqui sigue la ejecucion del programa");





static string NombreDelMes(int mes)
{

    switch (mes)
    {
        case 1:
            return "Enero";
        case 2:
            return "Febrero";
        case 3:
            return "Marzo";
        case 4:
            return "Abril";
        case 5:
            return "Mayo";
        case 6:
            return "Junio";
        case 7:
            return "Julio";
        case 8:
            return "Agosto";
        case 9:
            return "Septiembre";
        case 10:
            return "Octubre";
        case 11:
            return "Noviembre";
        case 12:
            return "Diciembre";
        default:
            throw new ArgumentOutOfRangeException();
    }
}