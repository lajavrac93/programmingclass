using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuFrases
{
    class Program
    {
        static void Main(string[] args)
        {
            int opt1;
            Console.WriteLine("1)Refran");
            Console.WriteLine("2)Chiste");
            Console.WriteLine("3)Insultar");
            Console.Write("Introduzca la opción a seleccionar: ");
            opt1 = int.Parse(Console.ReadLine());
            switch (opt1)
            {
                case 1:
                    Console.WriteLine("No por mucho madrugar amanece mas temprano");
                    break;
                case 2:
                    Console.WriteLine("Van dos y se cae el de en medio");
                    break;
                case 3:
                    Console.WriteLine("Itiota");
                    break;

                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
        }
    }
}
