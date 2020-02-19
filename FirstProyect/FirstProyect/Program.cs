using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProyect
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mostrar por consola texto
            Console.WriteLine("Hello world");
            int x = 10;
            //declaración de variable de tipo integer llamada "y"
            int y;
            //inicialización de ña variable llamada "y" con el valor 4
            y = 20;
            //Mostrar por consola resultado de suma
            Console.WriteLine(x+y);
            
            //declaración e inicialización de floating points
            float flo1 = 3.14f;
            float flo2 = 6.96f;
            
            //declaración e inicialización de doubles
            double doub1 = 3.14d;
            double doub2 = 6.96d;
            
            //declaración e inicialización de caracteres
            char letterA = 'a';
            char letterB = 'b';
            
            //declaración e inicialización de cadena de caracteres
            string fraseA = "hola mundo";
            string fraseB = "adios mundo";
            
            //declaración e inicialización boleana
            bool option1 = true;
            bool option2 = true;
            


            //casting
            y = (int)doub1;

            //pausa para que no se cierre la consola hasta pulsar una tecla
            Console.ReadKey();
        }
    }
}
