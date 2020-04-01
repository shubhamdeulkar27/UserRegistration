using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program
    {
        //FUNCTION TO VALIDATE FIRST AND LAST NAME
        public static void validateName(string firstName, string lastName)
        {
            Regex patternName = new Regex(@"^[A-Z]{1}[a-z]{2,}$");
            
            if (patternName.IsMatch(firstName) && patternName.IsMatch(lastName))
            {
                Console.WriteLine("Name Is Valid");
            }
            else
            {
                Console.WriteLine("Name Is Not Valid");
            }
        }

        //FUNCTION TO VALIDATE EMAIL
        public static void validateEmail(string email)
        {
            Regex patternEmail = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");

            if (patternEmail.IsMatch(email))
            {
                Console.WriteLine("Email Is Valid");
            }
            else
            {
                Console.WriteLine("Email Is Not Valid");
            }
        }

        static void Main(string[] args)
        {
            //TAKING INPUTS
            Console.WriteLine("Enter First Name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Email ID");
            string email = Console.ReadLine();
            
            //VALIDATING FIRST NAME AND LAST NAME
            Program.validateName(firstName,lastName);
            Program.validateEmail(email);
        }
    }
}
