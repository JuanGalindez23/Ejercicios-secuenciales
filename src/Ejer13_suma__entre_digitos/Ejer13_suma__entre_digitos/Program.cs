//Suma entre digitos Juan Galindez
//Variables
int num, unidad, decena, centena, suma;
//Ingreso de datos
Console.Write("Ingrese el numero deseado: ");
num = Convert.ToInt32(Console.ReadLine());
//Proceso
centena = num / 100;
decena = num / 10 % 10;
unidad  = num % 10;
suma = centena + decena + unidad;
//salida
Console.WriteLine($"La suma entre los digitos del numero ingresado es : {suma}");