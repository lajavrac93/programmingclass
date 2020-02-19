using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaExamen
{
    class Program
    {
        static void Main(string[] args)
        {
            int noteUsu;
            do
            {
                Console.WriteLine("Introduzca su nota: ");
                noteUsu = int.Parse(Console.ReadLine());
                if (noteUsu > 10 || noteUsu < 0)
                {
                    Console.WriteLine("Nota introducida no valida, introduzca una valida");
                }
            } while (noteUsu > 10 || noteUsu < 0);
            if (noteUsu < 5)
            {
                    Console.WriteLine("Insuficiente");

            }else if(noteUsu == 5)
                {
                    Console.WriteLine("Suficiente");
                }
                else if(noteUsu < 7)
                {
                    Console.WriteLine("Bien");
                }
                else if(noteUsu < 9)
                {
                    Console.WriteLine("Notable");
                }
                else
                {
                    Console.WriteLine("Sobresaliente");
                }

        }
    }
}
