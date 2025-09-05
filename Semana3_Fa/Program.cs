using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3_Fa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ejer2();
            Console.ReadKey(); //realizando detenimiento de consola
        }
        static void ejer1()
        {
            string  nombre , carrera;

            Console.Write("Ingrese su nombre:");
            nombre = Console.ReadLine();


            Console.Write("Ingrese su carrera:");
            carrera= Console.ReadLine();

            Console.WriteLine($"\n{nombre},bienvenido al curso FA de {carrera}");
        }

        static void ejer2()
        {
            Console.WriteLine("\"Anshe\"");
        }

        static void ejer3()
        {
            Console.WriteLine("Ingrese x:");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese y:");
            int y = Convert.ToInt32(Console.ReadLine());

            int sum = x + y;
            double divi =(double)x / (double)y;

            Console.Write("\nSuma : "+(x+y));
            Console.Write("Resta : " + (x - y));
            Console.Write("Multi : " + (x * y));
            Console.Write("Divi : " + (x / y));
        }
    }
}
