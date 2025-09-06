using System;

namespace Precio
{
    class Program
    {
        static void Main(string[] args)
        {
            int precio, cantidad;
            string linea;

            Console.WriteLine("Ingrese el precio");
            linea = Console.ReadLine();
            precio = int.Parse(linea);

            Console.WriteLine("Ingrese la cantidad");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);

            int total = precio * cantidad;

            Console.WriteLine("Total:");
            Console.WriteLine(total);
            Console.ReadKey();
        }
    }
}
