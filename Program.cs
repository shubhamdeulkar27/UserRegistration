using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();

            Regex patternName = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            if (patternName.IsMatch(firstName) && patternName.IsMatch(lastName))
            {
                Console.WriteLine(" Name Is Valid ");
            }
            else
            {
                Console.WriteLine("Name Is Not Valid");
            }
        }
    }
}
