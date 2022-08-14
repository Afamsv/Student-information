   using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Information_Display
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name");
            string Firstname = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(Firstname))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter your first name");
                    Console.ResetColor();
                }
                else if (Firstname.Any(char.IsDigit))
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Number is not accepted");
                    Console.ResetColor();
                }
                else if (Firstname.Length > 10)
                {
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("The alpabet that make up your firstname should not exceed 10");
                }
                else break;
                Firstname = Console.ReadLine();
            }
            
            Console.WriteLine("\nEnter your last name");
            string Lastname = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(Lastname))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter your last name");
                    Console.ResetColor();
                }
                else if (Lastname.Any(char.IsDigit))
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Number is not accepted");
                    Console.ResetColor();
                }
                else break;
                Lastname = Console.ReadLine();
            }

            Console.WriteLine("\nEnter you registration number");
            string Registrationnumber = (Console.ReadLine());
            while (true)
            {
                if (string.IsNullOrEmpty(Firstname))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter your registration number");
                    Console.ResetColor();
                }
                else break;
                Firstname = Console.ReadLine();
            }

            Console.WriteLine("\nEnter department");
            string Department = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(Department))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You did not enter anything");
                    Console.ResetColor();
                }
                else if (Department.Any(char.IsDigit))
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Number is not accepted");
                    Console.ResetColor();
                }
                else break;
                Department = Console.ReadLine();
            }

            Console.WriteLine("");

            Console.WriteLine("\nEnter your email");
            string Email = Console.ReadLine();

            Console.WriteLine("\nEnter your age");
            int? Age = Convert.ToInt32(Console.ReadLine());
            while (true)
            {
                if (Age == null)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter your real age");
                    Console.ResetColor();
                }
                else break;
                Age = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nEnter your School name.");
            string Schoolname = Console.ReadLine();
            while (true)
            {
                if (string.IsNullOrEmpty(Schoolname))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You did not enter anything");
                    Console.ResetColor();
                }
                else if (Schoolname.Any(char.IsDigit))
                {
                    Console.BackgroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine("Number is not accepted");
                    Console.ResetColor();
                }
                else break;
                Schoolname = Console.ReadLine();
            }

            Console.WriteLine("\nYour Detials: "); 
            
            
            Console.WriteLine($"Your name is: {Firstname} {Lastname}, \nReg No: {Department}, " +
                $"\nEmail: {Email}, \nAge: {Age}, \nSchool Name: {Schoolname}");
        }
    }
}
