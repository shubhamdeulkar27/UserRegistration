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

        //FUNCTION TO VALIDATE MOBILE NUMBER
        public static void validateMobileNumber(string mobileNumber)
        {
            Regex patternMobileNumber = new Regex(@"^([0-9]{2}[ ]{1}[0-9]{10})$");
            if (patternMobileNumber.IsMatch(mobileNumber))
            {
                Console.WriteLine("Mobile Number is Valid");
            }
            else
            {
                Console.WriteLine("Mobile Number is Not Valid");
            }
        }

        //FUNCTION TO VALIDATE PASSWORD
        public static void validatePassword(string password) 
        {
            Regex patternPassword = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])(.{8,})$");
            if (patternPassword.IsMatch(password))
            {
                Console.WriteLine("Password Is Valid");
            }
            else
            {
                Console.WriteLine("Password Is Not Valid");
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
            Console.WriteLine("Enter Mobile Number");
            string mobileNumber = Console.ReadLine();
            Console.WriteLine("Enter The Password");
            string password = Console.ReadLine();

            //VALIDATING INPUT DATA
            Program.validateName(firstName,lastName);
            Program.validateEmail(email);
            Program.validateMobileNumber(mobileNumber);
            Program.validatePassword(password);
        }
    }
}
