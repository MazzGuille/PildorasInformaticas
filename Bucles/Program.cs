/*
Los bucles se dividen en 2 categorias:
Determinados:
    - for
    -foreach
Indeterminados:
    - while
    - do while
*/

Char[] specialChar = new Char[] { '.', ',', '!', '?', ':', ';', '-', '_', '+', '=', '*', '%', '$', '#', '@', '&', '^', '~', '`', '<', '>', '/', '|', '\\', '{', '}', '[', ']', '(', ')', '"', '\'' };



//Console.WriteLine(specialChar.Length);

var repeat = true;
while (repeat == true)
{
    Console.WriteLine("Dime tu nombre");
    string nombre = Console.ReadLine();

   if(nombre.Contains(specialChar[0]) || nombre.Contains(specialChar[1]) || nombre.Contains(specialChar[2]) || nombre.Contains(specialChar[3]) || nombre.Contains(specialChar[4]) || nombre.Contains(specialChar[5]) || nombre.Contains(specialChar[6]) || nombre.Contains(specialChar[7]) || nombre.Contains(specialChar[8]) || nombre.Contains(specialChar[9]) || nombre.Contains(specialChar[10]) || nombre.Contains(specialChar[11]) || nombre.Contains(specialChar[12]) || nombre.Contains(specialChar[13]) || nombre.Contains(specialChar[14]) || nombre.Contains(specialChar[15]) || nombre.Contains(specialChar[16]) || nombre.Contains(specialChar[17]) || nombre.Contains(specialChar[18]) || nombre.Contains(specialChar[19]) || nombre.Contains(specialChar[20]) || nombre.Contains(specialChar[21]) || nombre.Contains(specialChar[22]) || nombre.Contains(specialChar[23]) || nombre.Contains(specialChar[24]) || nombre.Contains(specialChar[25]) || nombre.Contains(specialChar[26]) || nombre.Contains(specialChar[27]) || nombre.Contains(specialChar[28]) || nombre.Contains(specialChar[29]) || nombre.Contains(specialChar[30]) || nombre.Contains(specialChar[31]) || nombre.Contains(specialChar[31]))
    {
        Console.WriteLine("El nombre no puede contener caracteres especiales");
        repeat = true;
    }
    
      else if (nombre.Contains("1") || nombre.Contains("2") || nombre.Contains("3") || nombre.Contains("4") || nombre.Contains("5") || nombre.Contains("6") || nombre.Contains("7") || nombre.Contains("8") || nombre.Contains("9") || nombre.Contains("0"))
    {
        Console.WriteLine("El nombre no puede contener numeros");
        repeat = true;
    }

    else if (nombre == string.Empty)
    {
        Console.WriteLine("El nombre no puede estar vacio");
        repeat = true;
    }


    else if (nombre.Length < 3)
    {
        Console.WriteLine("El nombre debe tener al menos 3 caracteres");
        repeat = true;
    }

    else
    {
        Console.WriteLine($"El nombre ingresado es: {nombre} ¿Es correcto? (si/no)");
        string respuesta = Console.ReadLine();
        respuesta = respuesta.ToLower();
        if (respuesta == "si")
        {
            repeat = false;
        }
        else
        {
            repeat = true;
        }

    }
}
Console.WriteLine("Nombre registrado satisfactoriamente, gracias.");
