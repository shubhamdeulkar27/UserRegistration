using System;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Program : IValidate
    {
        /// <summary>
        /// Function to validate first name and last name.
        /// Takes two arguments first name and last name.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public void ValidateName(string firstName, string lastName)
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

        /// <summary>
        /// Function to validate email id.
        /// Takes one argument email id.
        /// </summary>
        /// <param name="email"></param>
        public void ValidateEmail(string email)
        {
            Regex patternEmail = new Regex(@"^abc((\.[A-Z]+[a-z]*[0-9]*)|(\.[A-Z]*[a-z]+[0-9]*)|(\.[A-Z]*[a-z]*[0-9]+)?)?@bl\.co(\.[a-z]{2,})?$");

            if (patternEmail.IsMatch(email))
            {
                Console.WriteLine("Email Is Valid");
            }
            else
            {
                Console.WriteLine("Email Is Not Valid");
            }
        }

        /// <summary>
        /// Function to validate mobile number.
        /// Takes one argument mobile number.
        /// </summary>
        /// <param name="mobileNumber"></param>
        public void ValidateMobileNumber(string mobileNumber)
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

        /// <summary>
        /// Function to validate password.
        /// Takes one argument password.
        /// </summary>
        /// <param name="password"></param>
        public void ValidatePassword(string password) 
        {
            Regex patternPassword = new Regex(@"^(?=.*[A-Z])(?=.*[0-9])(?=[^@#$%^&+=]*[@#$%^&+=][^@#$%^&+=]*$)(.{8,})$");
            if (patternPassword.IsMatch(password))
            {
                Console.WriteLine("Password Is Valid");
            }
            else
            {
                Console.WriteLine("Password Is Not Valid");
            }
        }

        /// <summary>
        /// Main function takes input and store it to User object.
        /// Validate the data in User object.
        /// </summary>w
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            try
            {
                //TAKING INPUTS
                User user = new User();
                Console.WriteLine("Enter First Name");
                user.FirstName = Console.ReadLine();
                Console.WriteLine("Enter Last Name");
                user.LastName = Console.ReadLine();
                Console.WriteLine("Enter Email ID");
                user.Email = Console.ReadLine();
                Console.WriteLine("Enter Mobile Number");
                user.MobileNumber = Console.ReadLine();
                Console.WriteLine("Enter The Password");
                user.Password = Console.ReadLine();

                //VALIDATING INPUT DATA
                Program program = new Program();
                program.ValidateName(user.FirstName, user.LastName);
                program.ValidateEmail(user.Email);
                program.ValidateMobileNumber(user.MobileNumber);
                program.ValidatePassword(user.Password);
            }
            catch (System.FormatException exception)
            {
                Console.WriteLine(exception.Message);
            }

        }
    }
}
