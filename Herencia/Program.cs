

Clear();

Perro perro1 = new("Negrita", 2);

Caballo caballo1 = new("Pony", 2);

Humano humano1 = new("Guille", 2);

Gorila gorila1 = new("Tarzan", 2);

Mamiferos humano3 = new Mamiferos("July", 2); // solo accedes a los metodos de mamiferos, los de humano no estan accesibles.

Humano humano2 = new("Bella", 2);

humano3 = humano2;

Mamiferos[] lab = new Mamiferos[6];
lab[0] = humano1;
lab[1] = humano2;
lab[2] = humano3;
lab[3] = perro1;
lab[4] = caballo1;
lab[5] = gorila1;

for(int i = 0; i < 6; i++)
{
    lab[i].Pensar();
}



/*
Write("Como se llama el Perro-1?\n"); 
perro1.getNombre();
Write("Cuantos ojos tiene el Perro-1?\n");
perro1.getOjos();
Write("Que acciones puede realizar?\n");
perro1.CuidarCrias();
perro1.Respirar();
perro1.Ladrar();
WriteLine();

Write("Como se llama el Humano-1?\n"); 
humano1.getNombre();
Write("Cuantos ojos tiene el Humano-1?\n");
humano1.getOjos();
Write("Que acciones puede realizar?\n");
humano1.CuidarCrias();
humano1.Respirar();
humano1.Pensar();
WriteLine();

Write("Como se llama el Caballo-1?\n"); 
caballo1.getNombre();
Write("Cuantos ojos tiene el Caballo-1?\n");
caballo1.getOjos();
Write("Que acciones puede realizar?\n");
caballo1.CuidarCrias();
caballo1.Respirar();
caballo1.Galopar();
WriteLine();

Write("Como se llama el Gorila-1?\n"); 
gorila1.getNombre();
Write("Cuantos ojos tiene el Gorila-1?\n");
gorila1.getOjos();
Write("Que acciones puede realizar?\n");
gorila1.CuidarCrias();
gorila1.Respirar();
gorila1.Trepar();
WriteLine();
*/
WriteLine("El programa ha finalizado, presiona cualquier tecla para continuar");
ReadKey();
Clear();


