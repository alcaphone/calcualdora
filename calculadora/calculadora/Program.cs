using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, a,o;
            Console.WriteLine("=====calculetor basic=======");
            Console.WriteLine("ingrese un numer");
            x = int.Parse(Console .ReadLine ());
            Console.WriteLine("ingrese oto numer");
            y = int.Parse(Console.ReadLine());

            int resta = x - y;
            Console.WriteLine("hola mundo   "+resta );

            int suma = x + y;
            Console.WriteLine("la suam es "+ suma);





            int dividir = x / y;
            Console.WriteLine("la divicion es "+ dividir );
            Console.ReadKey();

            
        }
    }
}
