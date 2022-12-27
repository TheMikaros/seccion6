using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 - Crear un programa que pida al usuario su nombre, y le diga "Hola" si se llama "Alejandro",
            //o bien le diga "No te conozco" si teclea otro nombre. tener en cuenta, que el la validación no
            //es case sensitive, es decir que si escriben "alejandro" ,"Alejandro", "aleJANdrO" serán valores validos.

            Console.WriteLine("Bienvenido (Proporciona tu nombre): ");

            string nombre = Console.ReadLine();

            string name = nombre.ToLower();  

            if(name == "alejandro")
            {
                Console.WriteLine($"Hola {nombre}");
            }
            else{
                Console.WriteLine($"No te conozco {nombre}");
            }
            Console.ReadLine();
        }
    }
}
