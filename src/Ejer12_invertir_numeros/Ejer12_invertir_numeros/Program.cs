//Invertir numeros Juan Galindez
//Variables
int num, numinv, unidades, decenas;
//Ingreso de datos
Console.Write("Ingrese el numero que desee invertir ");
num = Convert.ToInt32(Console.ReadLine());
//Proceso
decenas = num / 10;
unidades = num % 10;
numinv = (unidades *  10) + decenas;
//Salida 
Console.WriteLine($"Su numero invertido es: {numinv} ");