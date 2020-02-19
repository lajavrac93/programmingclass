using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeroMultiploSegundo
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1, num2;
            Console.WriteLine("¿El primer número es multiplo del segundo?");
            Console.Write("Introduzca el primer número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el segundo número: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 % num2 == 0)
            {
                Console.WriteLine(num1 + " es multiplo de " + num2);
            }
            else
            {
                Console.WriteLine(num1 + " no es multiplo de " + num2);
            }
        }
    }
}
