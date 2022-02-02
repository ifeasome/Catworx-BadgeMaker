using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to import API data for badges? type Y or N");
            string response = Console.ReadLine();

            if (response == "Y")
            {
                List<Employee> employees = PeopleFetcher.GetFromAPI();
                Util.MakeCSV(employees);
                Util.MakeBadges(employees);

            }
            else if (response == "N")
            {
                List<Employee> employees = PeopleFetcher.GetEmployees();
                Util.MakeCSV(employees);
                Util.MakeBadges(employees);
            }
            else 
            {
                Console.Write("Try a valid response");
            }
            
        }

    }

}