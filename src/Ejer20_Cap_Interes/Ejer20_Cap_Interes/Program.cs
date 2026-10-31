//Interes Compuesto Juan Galindez
//Variables
double TasaInteres, CapInicial, MesesInteres, CapFinal, InteresGanado;
//Ingreso de datos
Console.Write("Ingrese por favor el capital inicial ");
CapInicial = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese ahora la tasa de interes ");
TasaInteres = Convert.ToDouble(Console.ReadLine());
Console.Write("Por ultimo ingrese los meses de interes ");
MesesInteres = Convert.ToDouble(Console.ReadLine());
//Proceso y salidas
CapFinal = CapInicial * Math.Pow(1 + (TasaInteres / 100), MesesInteres);
Console.WriteLine($"El capital final es: {CapFinal}");
InteresGanado = CapFinal - CapInicial;
Console.WriteLine($"El interes ganado es: {InteresGanado}");