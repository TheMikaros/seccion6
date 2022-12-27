using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercici2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un programa que pida una palabra, y la escriba a su inversa ,
            //por ejemplo si se introduce Paris, devolverá "Sirap".

            Console.WriteLine("Dame una palabra");
            string word = Console.ReadLine();
            char[] array = word.ToCharArray();
            Array.Reverse(array);
            word = new string(array);

            Console.WriteLine(word);

            Console.ReadLine();
           
        }
    }
}
