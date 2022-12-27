using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crea un programa que pida una frase de al menos 20 caracteres y al menos 4 palabras por consola
            //y se muestre la siguiente información de esa cadena (usa funciones para cada caso) , se deberá
            //validar que la cadena tiene al menos 20 caracteres y la frase consta al menos de 4 palabras
            //            *longitud de la cadena
            //            * pinta la cadena, remplazando la letra "a" por "x", la "A" podrá ser mayúscula o minúscula
            //            en cuyo caso si es "a" se cambiara por una "x" y si es "A" se cambiara por una "X"
            //            * pinta la cadena en mayúsculas
            //*pinta la cadena en minúsculas
            //*pinta la cadena, removiendo las 3 primeras letras
            //*pinta la cadena, extrayendo las letras en las posiciones de la 5 a la 10
            //* invierte la cadena
            //*escribe el numero de palabras que tiene la frase
            //*escribe únicamente la tercera palabra

            string frase = "";

            while (true)
            {
                Console.WriteLine("Introduce una frase de al menos 20 caracteres y al menos 4 palabras:");
                frase = Console.ReadLine();

                if (ValidarFrase(frase))
                {
                    // La frase cumple los requisitos, se sale del bucle
                    break;
                }

                Console.WriteLine("La frase no cumple los requisitos, inténtalo de nuevo.");
            }

            Console.WriteLine("Longitud de la cadena: " + LongitudCadena(frase));
            Console.WriteLine("Cadena con remplazo de a por x: " + RemplazarAporX(frase));
            Console.WriteLine("Cadena en mayúsculas: " + EnMayusculas(frase));
            Console.WriteLine("Cadena en minúsculas: " + EnMinusculas(frase));
            Console.WriteLine("Cadena sin las 3 primeras letras: " + QuitarPrimerasLetras(frase, 3));
            Console.WriteLine("Cadena extrayendo las letras de la posición 5 a la 10: " + ExtraerLetras(frase, 5, 10));
            Console.WriteLine("Cadena invertida: " + InvertirCadena(frase));
            Console.WriteLine("Número de palabras: " + NumeroPalabras(frase));
            Console.WriteLine("Tercera palabra: " + TerceraPalabra(frase));
            Console.ReadLine();
        }//end main

        static bool ValidarFrase(string frase)
        {
            return frase.Length >= 20 && frase.Split(' ').Length >= 4;
        }

        static int LongitudCadena(string frase)
        {
            return frase.Length;
        }

        static string RemplazarAporX(string frase)
        {
            return frase.Replace('a', 'x').Replace('A', 'X');
        }

        static string EnMayusculas(string frase)
        {
            return frase.ToUpper();
        }

        static string EnMinusculas(string frase)
        {
            return frase.ToLower();
        }

        static string QuitarPrimerasLetras(string frase, int numeroLetras)
        {
            return frase.Substring(numeroLetras);
        }

        static string ExtraerLetras(string frase, int bloque1, int bloque2)
        {
            return $"{frase.Substring(0, bloque1)} {frase.Substring(bloque2)}";
        }

        static string InvertirCadena(string frase)
        {
            char[] array = frase.ToCharArray();
            Array.Reverse(array);
            return new string(array);
        }

        static int NumeroPalabras(string frase)
        {
            return frase.Split(' ').Length;
        }

        static string TerceraPalabra(string frase)
        {
            return frase.Split(' ')[2];
        }

    }
}
