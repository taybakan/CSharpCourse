using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Hello World!");

            int number1 = 10; //32 bit
            Console.WriteLine("Number1 is {0}", number1);

            long number2 = 2147483648; //64 bit
            Console.WriteLine("Number2 is {0}", number2);

            short number3 = 32767; //16 bit
            Console.WriteLine("Number3 is {0}", number3);

            byte number4 = 255; // 8 bit, unsigned
            Console.WriteLine("Number4 is {0}", number4);

            bool condition = true;
            if (condition)
                Console.WriteLine("Condition is true");
            else
                Console.WriteLine("Condition is false");

            char character = 'A';
            Console.WriteLine("Character is: {0}\nThe ASCII value of the character is: {1}", character, (int)character);

            double number5 = 10.4;
            Console.WriteLine("Number5 is: {0}", number5);

            decimal number6 = 10.4m;
            Console.WriteLine("Number6 is: {0}", number6);

            Console.WriteLine((int)Days.Friday);

            var number7 = 10;
            Console.WriteLine("Number7 is: {0}", number7);

            Console.ReadLine();
        }
    }

    enum Days
    {
        Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday
    }
}
