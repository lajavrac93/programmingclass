using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumeroPositivoNegativoCero
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.WriteLine("Se informará sobre si el número introducido es positivo, negativo o 0");
            Console.Write("Introduzca el número: ");
            num1 = int.Parse(Console.ReadLine());
            if (num1 == 0)
            {
                Console.WriteLine("El número es 0");
            }else if(num1>0)
            {
                Console.WriteLine("El número es positivo");
            }
            else
            {
                Console.WriteLine("El número es negativo");
            }
        }
    }
}
