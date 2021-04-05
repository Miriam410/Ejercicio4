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
        // 4. Permita el ingreso de frases, finalizando cuando el usuario ingresa "fin". 
            string frase;
            do
            {
                Console.WriteLine("Ingrese una frase.");
                frase = Console.ReadLine();
                Console.WriteLine("Para finalizar, debe ingresar la palabra: fin");
            } while (frase!= "fin");
        }
    }
}
