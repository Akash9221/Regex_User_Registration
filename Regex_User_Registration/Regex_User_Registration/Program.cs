using System;
using System.ComponentModel.DataAnnotations;

namespace Regex_User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Welcome to Regular Expression");
            //Console.WriteLine("Enter your first name");
            //string FirstName = Console.ReadLine(); // Creating user input for first name
            //Validation.FirstNameValidation(FirstName);//Calling method to validate firstname

           
            Console.WriteLine("Enter your Last name");
            string LName = Console.ReadLine(); //  input for last name
            Validation.LastNameValidation(LName);

        }
    }
}
