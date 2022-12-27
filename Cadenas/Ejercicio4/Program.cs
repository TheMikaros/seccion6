using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el primer número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el tercer número:");
            int numero3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduce el cuarto número:");
            int numero4 = int.Parse(Console.ReadLine());

            StringBuilder sb = new StringBuilder();
            sb.Append("El primer número introducido es el ");
            sb.Append(numero1);
            sb.Append(", después han introducido el ");
            sb.Append(numero2);
            sb.Append(" y ");
            sb.Append(numero3);
            sb.Append(" y por último el ");
            sb.Append(numero4);

            string frase = sb.ToString();
            Console.WriteLine(frase);

            Console.ReadLine();
        }
    }
}
