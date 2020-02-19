using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            Console.Write("Introduzca el numero: ");
            num1 = int.Parse(Console.ReadLine());
            if((num1 % 2)== 0)
            {
                Console.WriteLine("El " + num1 + " par");
            }
            else
            {
                Console.WriteLine("El " + num1 + " impar");
            }
        }
    }
}
