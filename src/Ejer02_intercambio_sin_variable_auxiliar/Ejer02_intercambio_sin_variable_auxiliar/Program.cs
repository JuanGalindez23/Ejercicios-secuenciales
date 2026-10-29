//Intercambiador sin variables auxiliares
//Variables
int A, B;

//Proceso
Console.Write("Ingrese la variable A ");
A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese la variable B ");
B = Convert.ToInt32(Console.ReadLine());
A = A + B;
B= A - B;
A = A - B;
//Salida
Console.WriteLine($"Las variables ya intercambiadas son: {A} y {B} ");