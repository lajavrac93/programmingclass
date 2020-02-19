using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuePuedoHacer
{
    class Program
    {
        static void Main(string[] args)
        {
            int edadUsuario;
            Console.Write("Introduzca su edad: ");
            edadUsuario = int.Parse(Console.ReadLine());
            if (edadUsuario < 18)
            {
                Console.WriteLine("Eres menor de edad");
            }
            else if(edadUsuario<65)
            {
                Console.WriteLine("Eres mayor de edad");
            }
            else
            {
                Console.WriteLine("Eres jubilado");
            }
            
        }
    }
}
