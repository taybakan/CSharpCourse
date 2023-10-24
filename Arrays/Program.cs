using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = new string[3];
            students[0] = "Cemal";
            students[1] = "Mustafa";
            students[2] = "Fatih";

            string[] students2 = { "Bilal", "Tolga", "Senem" };
            //students2[3] = "Yusuf";

            foreach (var student in students2)
            {
                Console.WriteLine(student);
            }

            string[,] regions= new string[5,3]
            {
                {"İstanbul", "İzmit", "Tekirdag"},
                {"Ankara", "Konya", "Kırıkkale"},
                {"Antalya", "Adana", "Mersin"},
                {"Samsun", "Ordu", "Giresun"},
                {"İzmir", "Muğla", "Afyonkarahisar"}
            };

            for (int i = 0; i <= regions.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= regions.GetUpperBound(1); j++)
                    Console.WriteLine(regions[i,j]);
            }

            Console.ReadLine();
        }
    }
}
