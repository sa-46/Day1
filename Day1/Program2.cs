using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    class Program2
    {
        static void Main()
        {
            string name; //we declare a variable called 'name' with datatype 'string'
            string city;

            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
            Console.Write("Where are your from? ");
            city = Console.ReadLine();

            //wait for user to key in a value and press Enter
            //and assign the value into a variable called 'name'

            Console.Write("1. Hello ");
            Console.WriteLine(name);

            Console.WriteLine("2. Hello " + name);

            Console.Write("3. Hello " + name + "\n");

            Console.WriteLine("4. Hello {0}, I know that your name is {0} " +
                " and I just want to you know that my name is not {0} !", name);

            Console.WriteLine("5. Hello " + name + ", I know that your name is " + name + 
                " and I just want to you know that my name is not " + name + " !");

            Console.WriteLine("6. From {3} {{ comes {4}.", name, city, name, city, name, city);
        }
    }
}
