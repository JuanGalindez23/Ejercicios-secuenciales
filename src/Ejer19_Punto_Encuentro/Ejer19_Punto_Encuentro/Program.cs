//Punto de encuentro de dos vehiculos Juan Galindez
//variables
double V1, V2, Tiempo, Di, D1, D2;
//Ingreso de datos
Console.Write("Ingrese la distancia que separa a los vehiculos (km)");
Di = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la velocidad del vehiculo 1 (km/h)");
V1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese la velocidad del vehiculo 2 (km/h)");
V2 = Convert.ToDouble(Console.ReadLine());
//Proceso
Tiempo = Math.Truncate((Di / (V1 + V2) * 100)) / 100;
Console.WriteLine($"El tiempo transcurrido es: {Tiempo}");
D1= V1 * Tiempo;
Console.WriteLine($"La distancia recorrida por el vehiculo 1 es: {D1}");
D2 = V2 * Tiempo;
Console.WriteLine($"La distancia recorrida por el vehiculo 2 es: {D2}");