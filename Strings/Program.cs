using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            string sentence = "Je m'appelle Cemal";

            var result = sentence.Length;
            Console.WriteLine(result);

            var result2 = sentence.Clone();
            sentence = "Je m'appelle Tolga";

            bool result3 = sentence.EndsWith("a");
            bool result4 = sentence.StartsWith("J");

            var result5 = sentence.IndexOf("Jee");
            var result6 = sentence.IndexOf(" ");
            var result7 = sentence.LastIndexOf(" ");

            var result8 = sentence.Insert(0, "Salut, ");
            var result9 = sentence.Substring(3, 4);
            var result10 = sentence.ToLower();
            var result11 = sentence.ToUpper();
            var result12 = sentence.Replace(" ", "-");
            var result13 = sentence.Remove(2, 5);

            Console.ReadLine();
        }

        private static void Intro()
        {
            string city = "Ankara";
            //Console.WriteLine(city[0]);

            foreach (var item in city)
                Console.WriteLine(item);

            string city2 = "İstanbul";
            string city3 = city + city2;
            Console.WriteLine(city3);

            Console.WriteLine(String.Format("{0} {1}", city, city2));
        }
    }
}
