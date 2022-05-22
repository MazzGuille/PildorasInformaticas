using System.Reflection.Metadata;
using clases;
using static System.Console;



    


Clear();



int[] miMatriz;   //decalaracion
miMatriz = new int[4]; //iniciacion

int[] miMatriz2 = new int[4]; //decalaracion e iniciaion juntos

int[] miMatriz3 = { 1, 2, 3, 4 }; //decalaracion, iniciaion y declaracion de valores juntos

int[] miMatriz4 = new int[4] { 1, 2, 3, 4 }; //decalaracion, iniciaion y declaracion de valores juntos y se limitan las posiciones del array.


//WriteLine($"{miMatriz[3]} {miMatriz[0]} {miMatriz[2]} {miMatriz[1]}");
//WriteLine($"{miMatriz3[0]} {miMatriz3[1]} {miMatriz3[2]} {miMatriz3[3]}");


Empleados Ana = new Empleados("Ana", 27); // Aca creamos el objeto "Ana"

Empleados[] arrayEmpleados = new Empleados[3];

arrayEmpleados[0] = new Empleados("Guille", 35); //Aca creamos un objeto a la misma vez que lo almacenamos como indice [0] del array.

arrayEmpleados[1] = Ana; //Aca declaramos que el objeto ya creado, en la linea 20, llamado "Ana" quede en la posicion[1] del array.

arrayEmpleados[2] = new Empleados("July", 33);

int[] numeros = new int[4]; //ver arrays metodos linea 93 hasta la 142 STARTS

numeros[0] = 7; 
numeros[1] = 9; 
numeros[2] = 15; 
numeros[3] = 3;

ProcesaDatos(numeros);

foreach (int i in numeros)  
{
    WriteLine(i);
}  

int[] arrayElementos = LeerDatos();

WriteLine("Imprimiendo desde el main");

foreach (int i in arrayElementos) WriteLine(i); //ver arrays metodos linea 93 hasta la 142 ENDS


//-------------------------------------ARRAY DE TIPOS O CLASES ANONIMAS----------------------------------------//
var personas = new[]
{
    new{Nombre = "July", Edad = 33},
    new{Nombre = "Annabella", Edad = 2},
    new{Nombre = "Guillermo", Edad = 35,}
};

WriteLine(personas[1]);


//-------------------------------------------------------------ARRAY IMPLICITO--------------------------------------//
var datos = new[] { "Juan", "Perez", "España" };

var valores = new[] { 15, 28, 35, 40.25 };
WriteLine($"Cantidad de posiciones 1: {valores.Length}");


//---------------------------------------------------------BUCLE FOR-------------------------------------------------//

/*
for(int i = 0; i < 10; i++)
{
   // codigo(puede ser lo corto o lo largo que necesites)
}
*/

for (int i = 0; i < arrayEmpleados.Length; i++)
{
    WriteLine(arrayEmpleados[i].getInfo());
}

//---------------------------------------------------------BUCLE FOR-EACH-------------------------------------------------//

foreach (double var in valores)
{
    WriteLine(var);
}

foreach (var variable in personas)
{
    WriteLine($"{variable.Edad} {variable.Nombre}");
}


//-------------------------------------------------------------------ARRAYS POR APRAMETROS-----------------------------//

static void ProcesaDatos(int[] datos)
{
    foreach (int i in datos)
    {
        WriteLine(i);
    }

    for(int i = 0; i < 4; i++)
    {
        datos[i]+=10;
    }
}


static int[] LeerDatos()
{
    WriteLine("¿Cuantos elementos quieres que tenga el array?");

    String respuesta = ReadLine();

    int numElementos = Convert.ToInt32(respuesta);

    int[] datos = new int[numElementos];

    for (int i = 0; i < datos.Length; i++)
    {
        WriteLine($"Introduce el dato para la posicion {i}");

        respuesta = ReadLine();

        int datosElemento = Convert.ToInt32(respuesta);

        datos[i] = datosElemento;
    }

    return datos;
}





WriteLine("Press any key to exit");
ReadKey();
Clear();







