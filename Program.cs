 using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Projects;

namespace Projects
{
    internal class Program
    {
        static void Main()
        {
            Banking.Customer obj = new Banking.Customer (101, true, "Kunal", 1500000000000, Cities.Pune);  // This is read only no one can change it now
            Console.WriteLine("CustID: " + obj.CustID);

            if (obj.Status == true) {
                Console.WriteLine("Customer A/C Status is : Active");
            }
            else
            {
                Console.WriteLine("Customer A/C Status is : In-Active");
            }

            Console.WriteLine("Customer Name is : " + obj.CustName);
            obj.CustName += "Pawar";
            Console.WriteLine("Modified Name: " + obj.CustName);


            Console.WriteLine("Customer A/C Balance is: "+obj.Balance);
           // obj.Balance += 500;
            Console.WriteLine("Modified Name: " + obj.Balance); // if a\c status is flase it wont cange value
            obj.Balance = obj.Balance - 14700;
            Console.WriteLine("Modified Balance:" + obj.Balance);

            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("Current City: " + obj.City );
            obj.City = Cities.Hyderabad;
            Console.WriteLine("Modified: " + obj.City);

            Console.ReadLine();
        }
    }
}
