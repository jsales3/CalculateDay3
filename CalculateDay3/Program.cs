using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateDay3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jovon Sales");
            Console.WriteLine("jsales3@kent.edu");

            DateTime myValue = DateTime.Now;

            Console.WriteLine("Enter your Birthdate in mm/dd/yyyy format:");

            string userValue = Console.ReadLine();

            while (true)
            {

                try
                {

                    DateTime myBirthday = DateTime.Parse(userValue);
                    TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
                    Console.WriteLine(myAge.TotalDays);

                    Console.ReadLine();
                    break;
                }

                catch (Exception) { }
                Console.WriteLine("The date you entered is incorrect");
                Console.WriteLine("Please enter a correct date");
                userValue = Console.ReadLine();
            }
        }
    }
}
