﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TestApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть імя");
       string name = Console.ReadLine();
            if (name == "volodya")
            {
                Console.WriteLine("sviy");
            }
            else
            {
                Console.WriteLine("Chuziy");
            }
        }
    }
}
