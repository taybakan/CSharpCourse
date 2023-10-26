using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eat = new IEat[2]
            {
                new Manager(),
                new Worker()
            };

            foreach (var e in eat)
            {
                e.Eat();
            }
            Console.ReadLine();
        }
    }

    interface IWorker
    {
        void Work();
    }

    interface IEat
    {
        void Eat();
    }

    interface ISalary
    {
        void GetSalary();
    }

    class Manager : IWorker, ISalary, IEat
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void GetSalary()
        {
            Console.WriteLine("Getting Salary");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }

    class Worker : IWorker, IEat, ISalary
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }

        public void GetSalary()
        {
            Console.WriteLine("Getting Salary");
        }

        public void Work()
        {
            Console.WriteLine("Working");
        }
    }

    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Working");
        }
    }
}
