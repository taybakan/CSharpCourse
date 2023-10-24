using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager = new ProductManager();

            customerManager.Add();
            customerManager.Update();
            productManager.Add();
            productManager.Update();


            Customer customer = new Customer();
            customer.City = "Ankara";
            customer.Id = 1;
            customer.FirstName = "Engin";
            customer.LastName = "Demiroğ";

            Customer customer2 = new Customer
            {
                Id = 2,
                City = "İstanbul",
                FirstName = "Cemal",
                LastName = "Aybakan"
            };

            Console.WriteLine(customer2.FirstName);
            Console.ReadLine();
        }
    }
}
