using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            do
            {
                Console.WriteLine("Ingrese una frase.");
                string frase = Console.ReadLine();
                Console.WriteLine("Para finalizar, debe ingresar la palabra: fin");
                palabra = Console.ReadLine();
            } while (palabra!= "fin");
        }
    }
}
