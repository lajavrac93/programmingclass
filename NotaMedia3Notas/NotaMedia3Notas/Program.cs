using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotaMedia3Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            float num1, num2, num3;
            Console.WriteLine("Se va a calcular la media de sus 3 notas");
            Console.Write("Introduzca la primera nota: ");
            num1 = float.Parse(Console.ReadLine());
            Console.Write("Introduzca la segunda nota: ");
            num2 = float.Parse(Console.ReadLine());
            Console.Write("Introduzca la tercera nota: ");
            num3 = float.Parse(Console.ReadLine());
            Console.WriteLine("la media es: "+((num1+num2+num3)/3f));
        }
    }
}
