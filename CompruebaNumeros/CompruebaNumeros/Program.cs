using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ejercicio de comprobar si 2 números introducidos son iguales
namespace CompruebaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.Write("Introduzca el primer numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine(num1+" y "+num2+" son iguales");
            }
            else
            {
                if (num1>num2)
                {
                    Console.WriteLine(num1 + " es mayor que " + num2);
                }
                else
                {
                    Console.WriteLine(num1 + " es menor que " + num2);
                }
                
            }
        }
    }
}
