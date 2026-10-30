//Unidad, centena, decena, unidad de un numero Juan Galindez
//variables
int num, millar, centena, decena, unidad;
//Ingreso de datos
Console.Write("Ingrese un numero de 4 cifras ");
num = Convert.ToInt32(Console.ReadLine());
//Proceso
millar = num / 1000;
centena = num / 100 % 10;
decena = num / 10 % 10;
unidad = num % 10;
//Salida
Console.WriteLine($"Las cifras por separado del numero ingresado son: {millar}, {centena}, {decena}, {unidad}");