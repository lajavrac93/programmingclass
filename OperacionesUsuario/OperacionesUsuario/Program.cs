using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacionesUsuario
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
            //se calcula y muestra el resultado 
            Console.WriteLine("El resultado de la suma es: " + (num1 + num2));
            Console.WriteLine("El resultado de la multiplicación es: " + (num1 * num2));
            Console.WriteLine("El resultado de la resta es: " + (num1 - num2));
            Console.WriteLine("El resultado de la división es: " + (num1 / num2));
            Console.WriteLine("El resto de la división es: " + (num1 % num2));
        }
    }
}
