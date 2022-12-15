using System;
using System.ComponentModel.DataAnnotations;

namespace Regex_User_Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //UR1
            //Console.WriteLine("Welcome to Regular Expression");
            //Console.WriteLine("Enter your first name");
            //string FirstName = Console.ReadLine(); // Creating user input for first name
            //Validation.FirstNameValidation(FirstName);//Calling method to validate firstname

            //UR2
            //Console.WriteLine("Enter your Last name");
            //string LName = Console.ReadLine(); //  input for last name
            //Validation.LastNameValidation(LName);

            //UR3
            //Console.WriteLine("\n\nEnter your email name : ");
            //string email = Console.ReadLine(); 
            //bool checkEmail = UR3_Email_Validation.EmailValidation(email); //Calling method to check email 
            //Console.ReadLine();

            //UR4
            //Console.Write("Enter The Mobile Number:");
            //String mob = Console.ReadLine();

            //if (UR4_Mobile_Number_Validation.validate(mob))
            //{
            //    Console.WriteLine("Valid Data");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Data");
            //}

            ////UR5
            //Console.Write("Enter The Password:");
            //String pass = Console.ReadLine();

            //if (UR5_Rule.validate(pass))
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //UR6
            //Console.Write("Enter The Password:");
            //String pass = Console.ReadLine();

            //if (UR6_Rule1.validate(pass))
            //{
            //    Console.WriteLine("Valid");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid");
            //}

            //UR7
            Console.Write("Enter The Password:");
            String pass = Console.ReadLine();

            if (UR7_Rule2.validate(pass))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
