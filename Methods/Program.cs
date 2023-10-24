﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Add();

            var result = Add2(5, 4);
            Console.WriteLine(result);
            result = Add2(5);
            Console.WriteLine(result);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add3(ref number1, number2);

            Console.WriteLine(number1);
            Console.ReadLine();
        }

        static void Add()
        {
            Console.WriteLine("Added!");
        }

        static int Add2(int number1, int number2 = 30)
        {
            return number1 + number2;
        }

        static int Add3(ref int number1, int number2)
        {
            number1 += 10;
            return number1 + number2;
        }
    }
}
