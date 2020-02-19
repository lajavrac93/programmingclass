using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasSwitch
{
    class Program
    {
        static void Main(string[] args)
        {
            int noteUsu;

            Console.WriteLine("Introduzca su nota: ");
            noteUsu = int.Parse(Console.ReadLine());

            switch (noteUsu)
            {
                case 10:
                case 9:
                    Console.WriteLine("Sobresaliente");
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Notable");
                    break;
                case 6:
                    Console.WriteLine("Bien");
                    break;
                case 5:
                    Console.WriteLine("Suficiente");
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Insuficiente");
                    break;
                default:
                    Console.WriteLine("Valor no valido para nota");
                    break;
            }




        }   
    }
}
