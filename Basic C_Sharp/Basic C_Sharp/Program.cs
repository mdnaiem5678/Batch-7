using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = "";
            string Age = " ";
            string Address = " ";
            string Contact = " ";

            Console.WriteLine("Enter Your name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Your Name is : " + Name);

            Console.WriteLine("Enter Your Age : ");
            Age = Console.ReadLine();
            Console.WriteLine("Your Age is : " + Age);

            Console.WriteLine("Enter your Address: ");
            Address = Console.ReadLine();
            Console.WriteLine("Your Address is: " + Address);

            Console.WriteLine("Enter Your Contact: ");
            Contact = Console.ReadLine();
            Console.WriteLine("Your Contact is: " + Contact);
            Console.ReadKey();

        }
    }
}
