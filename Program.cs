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
            Regex patternFirstName = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            if (patternFirstName.IsMatch(firstName))
            {
                Console.WriteLine("First Name Is Valid ");
            }
            else
            {
                Console.WriteLine("First Name Is Not Valid");
            }
        }
    }
}
