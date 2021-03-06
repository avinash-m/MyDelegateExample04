﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegateExample04
{
    public delegate int MyDelegate(int firstNumber, int secondNumber);

    class Program
    {
        static int x = 30;

        static int Add(int a, int b)
        {
            x = a + b;
            return x;
        }
        static int Sub(int a, int b)
        {
            x = a - b;
            return x;
        }

        static void Main(string[] args)
        {
            // without delegate
            x = 30;
            Add(10, x);
            Sub(10, x);
            Console.WriteLine("Without delegate x: "+ x);

            // with delegate
            x = 30;
            MyDelegate md = Add;
            md += Sub;
           
            Console.WriteLine(md(10, x)); // x = 10 + 30; x = 10 - 30
            Console.WriteLine("With delegate x: "+ x);

            md -= Add;
            Console.WriteLine(md(40, x)); //x = 40 -(-20)
            Console.WriteLine("x: " + x);

        }
    }
}
