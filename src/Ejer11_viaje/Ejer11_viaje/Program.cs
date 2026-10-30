//Galones, rendimiento y precio Juan Galindez
//Variables
double vel, tiempo, dist, galon, rend, pgalon;
//Ingreso de datos
Console.Write("Ingrese la velocidad en km/h ");
vel = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese el tiempo en minutos ");
tiempo = Convert.ToDouble(Console.ReadLine());
Console.Write("Ingrese los galones consumidos ");
galon = Convert.ToDouble(Console.ReadLine());
//Proceso
dist = vel * (tiempo/60);
rend = dist / galon;
pgalon = galon * 15.933;
//Salida
Console.WriteLine($"La distancia recorrida en km es: {dist}");
Console.WriteLine($"el rendimiento en km/g es: {rend}");
Console.WriteLine($"El precio por galon es: {pgalon} pesos colombianos"); 