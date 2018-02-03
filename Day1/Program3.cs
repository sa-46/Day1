using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program3
    {
        static void Main()
        {
            Console.Write("Enter your salary: ");
            string salaryString = Console.ReadLine();

            //convert text contained in salaryString into salary variable
            double salary = Double.Parse(salaryString);

            //calculate the tax - assume 10% tax rate
            double tax = 0.0567891 * salary;

            Console.WriteLine("Your tax is ${0:0,000.00} from your salary of {1:#.##} ",tax, salary);
            Console.WriteLine("Your tax is {0:C} from your salary of {1:C} ", tax, salary);
        }
    }

    class Program4
    {
        static void Main()
        {

        }
    }
}
