using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriticarAltura
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Serás criticado en función de tu altura");
            Console.Write("Introduzca su altura: ");
            num = int.Parse(Console.ReadLine());
            if (num <= 0)
            {
                Console.WriteLine("No existes");
            }
            if (num >0&&num <= 100)
            {
                Console.WriteLine("Espero que seas muy menor de edad");
            }else 
            if (num >100 && num <= 150)
            {
                Console.WriteLine("Enano");
            }
            if (num > 150 && num < 170)
            {
                Console.WriteLine("Alto Enano");
            }
            if (num >= 170 && num <= 180)
            {
                Console.WriteLine("Eres normal segun la mayoría (al menos en altura)");
            }
            if (num > 180 && num <= 230)
            {
                Console.WriteLine("Eres alto");
            }
            if (num > 230 && num <= 270)
            {
                Console.WriteLine("Eres gigantesco");
            }
            if (num > 270)
            {
                Console.WriteLine("Eres inhumanamente alto");
            }
        }
    }
}
