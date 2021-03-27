using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad_13
{
    class Program
    {
        //Solicite el ingreso de dos frases y determine si tienen la misma longitud.
        static void Main(string[] args)
        {
            string Frase_1;
            string Frase_2;

            Console.Write("Por favor, ingrese la primera frase: ");
            Frase_1 = Console.ReadLine();
            Console.Write("Por favor, ingrese la segunda frase: ");
            Frase_2 = Console.ReadLine();
            Console.WriteLine("\r");

            if (Frase_1.Length == Frase_2.Length)
            {
                Console.WriteLine("Las frases ingresadas tienen la misma longitud de largo.");
            }
            else
            {
                Console.WriteLine("Las frases ingresadas no tienen la misma longitud de largo.");
            }
            Console.ReadKey();
        }
    }
}