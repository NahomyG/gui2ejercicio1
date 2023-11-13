using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guia2ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa cuatro numeros");

            Console.WriteLine("Escribe tu primer numero: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe tu segundo numero: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el tercer numero: ");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Escribe el cuarto numero: ");
            double num4 = Convert.ToDouble(Console.ReadLine());

            double suma = num1 + num2;

            double producto = num3 + num4;

            Console.WriteLine("El resultado del primer numero y segundo numero es: " + suma);
            Console.WriteLine("El resultado del tercer numero con el cuarto numero es: " + producto);
            Console.WriteLine("Gracias por usar el sistema (~°o°)~ ");

            Console.ReadLine();
        }
    }
}
