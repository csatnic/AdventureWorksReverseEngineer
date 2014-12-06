using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdventureWorksPowerTools.Models;

namespace AdventureWorksPowerTools
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new AdventureWorksContext())
            {
                var customers = ctx.Customers.Where(c => c.PersonID != null).Take(10);

                foreach (var customer in customers)
                {
                    Console.WriteLine(string.Format("Customer ID: {0} - First Name: {1} - Last Name: {2}",
                        customer.CustomerID,
                        customer.Person.FirstName,
                        customer.Person.LastName));
                }
            }

            Console.ReadLine();
        }
    }
}
