﻿using System;
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
            int x, y, a;
            Console.WriteLine("ingrese un numer");
            x = int.Parse(Console .ReadLine ());
            Console.WriteLine("ingrese oto numer");
            y = int.Parse(Console.ReadLine());
            a = x + y;
            Console.WriteLine("hola mundo   "+a );
            Console.ReadKey();


        }
    }
}
