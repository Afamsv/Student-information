using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Student_Information_Display
{
    public static class Application
    {
        public static void run()
        {
            Console.WriteLine("Enter your first name");
            string fn = Console.ReadLine();          
            string firstName = Validation.CheckFirstName(fn);
            Validation.CheckFirstName(firstName);
            Validation.DisplayInfo();
            Console.WriteLine($"Your first name is {firstName}");
            Console.ResetColor();

            Console.WriteLine("\nEnter your last name");
            string lname = Console.ReadLine();
            string lastName = Validation.CheckSecondNmae(lname, firstName);
            Validation.DisplayInfo();
            Console.WriteLine($"Your Last Name is {lastName}");
            Console.ResetColor();

            Console.WriteLine("Select your Gender: \n 1. male \n 2. Female \n 3. Prefer not to say");
            var gender = Console.ReadLine();
            Validation.CheckGender(gender);
            var selectGender = Validation.SelectGender(gender);
            Validation.DisplayInfo();
            Console.WriteLine($"Your gender is {selectGender}");
            Console.ResetColor();

            Console.WriteLine("\nEnter you registration number");
            string rn = (Console.ReadLine());
            string registrationNumber = Validation.CheckRegNumber(rn);
            Validation.DisplayInfo();
            Console.WriteLine($"Your Last Name is {registrationNumber}");
            Console.ResetColor();

            Console.WriteLine("\nEnter department");
            string dpt = Console.ReadLine();
            string department = Validation.Department(dpt);
            Validation.DisplayInfo();
            Console.WriteLine($"Your department is {department}");
            Console.ResetColor();

            Console.WriteLine("\nEnter your email");
            string mail = Console.ReadLine();
            string email = Validation.EmailChecker(mail);
            Validation.DisplayInfo();
            Console.WriteLine($"Your email is {email}");
            Console.ResetColor();

            Console.WriteLine("\nEnter your age");
            int a = Convert.ToInt32(Console.ReadLine());
            int age = Validation.Age(a);
            Validation.DisplayInfo();
            Console.WriteLine($"Your age is {age}");
            Console.ResetColor();

            Console.WriteLine("Enter birthday in the format dd/mm/yyyy");
            var birthday = Console.ReadLine();
            DateTime result;
            while (!DateTime.TryParse(birthday, out result))
            {
                Validation.InvalidEntry("birthday");
                birthday = Console.ReadLine();
            }

            Console.WriteLine("\nEnter your School name.");
            string sName = Console.ReadLine();
            string schollName = Validation.SchoolName(sName);
            Validation.DisplayInfo();
            Console.WriteLine($"Your school name is {schollName}");

            Console.WriteLine("\nYour Detials: ");

            //var gottenData = new Register
            //{
            //    FirstName = firstName,
            //    lastName = lastname,
            //    Registrationnumber = registrationnumber,
            //    Department = department,
            //    Email = email,
            //    Age = age,
            //    SchoolName = schoolname,
            //};

            Console.WriteLine($"Your name is: {firstName} {lastName} \nReg No: {department} " +
                $"\nEmail: {email} \nAge: {age} \nSchool Name: {schollName}");
        }
    }
}
