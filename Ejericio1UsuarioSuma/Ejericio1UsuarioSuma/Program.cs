using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejericio1UsuarioSuma
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //se establecen las variables
            int num1, num2;
            //se informa al usuario y se le pide que introducir
            Console.WriteLine("Se va a realizar la suma de dos numeros enteros");
            Console.WriteLine("introduzca el primer número");
            //se lee el numero introducido
            num1 = int.Parse(Console.ReadLine());
            //se pide el segundo numero
            Console.WriteLine("introduzca el segundo número");
            //Se lee el segundo numero
            num2 = int.Parse(Console.ReadLine());
            //se muestra el resultado 
            Console.WriteLine("El resultado es: " + (num1 + num2));

        }
    }
}
