using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

namespace MetalappsAutomation
{
    public class Driver
    {
        static void Main(string[] args)
        {
            SalesDetails obj = new SalesDetails();
            Console.WriteLine("Enter sales id ");
            obj.SalesId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter customer name ");
            obj.CustomerName = Console.ReadLine();

            Console.WriteLine("Enter the number of units sold");
            obj.NoOfUnits = int.Parse(Console.ReadLine());
            Metalapps app = new Metalapps();
            app.CalculateNetAmount(obj);

            Console.WriteLine("Sales Bill ");
            Console.WriteLine("*****");
            Console.WriteLine("Sales Id : " + obj.SalesId);
            Console.WriteLine("Customer Name : " + obj.CustomerName);
            Console.WriteLine("Number of Units Sold : " + obj.NoOfUnits);
            Console.WriteLine("Net Amount : " + obj.NetAmount);


        }
    }
}