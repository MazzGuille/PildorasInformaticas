Auto carro1 = new();
Avion avion1 = new();
Persona persona1 = new();

carro1.Encender();
WriteLine(carro1.AndarPorLaCiudad);
carro1.Apagar();
WriteLine();
avion1.Encender();
WriteLine(avion1.Volar);
WriteLine(avion1.Aterrizar);
avion1.Apagar();
WriteLine();
persona1.QuePuedesHacer();
carro1.Conducir();
avion1.Conducir();
