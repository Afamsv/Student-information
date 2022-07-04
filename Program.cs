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
            string FN;
            Console.WriteLine("Enter your first name");
            FN = Console.ReadLine();

            Console.WriteLine();

            string LN;
            Console.WriteLine("Enter your last name");
            LN = Console.ReadLine();
            
            Console.WriteLine();

            //string Name;
            //Console.WriteLine("Enter your name");
            //Name = Console.ReadLine();

            //Console.WriteLine("");

            long Reg;
            Console.WriteLine("Enter reg number");
            Reg = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("");

            string Department;
            Console.WriteLine("Enter department");
            Department = Console.ReadLine();

            Console.WriteLine("");

            string Email;
            Console.WriteLine("Enter your email");
            Email = Console.ReadLine();

            Console.WriteLine("");

            int Age;
            Console.WriteLine("Enter your age");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            string SchoolName;
            Console.WriteLine("Enter your School name.");
            SchoolName = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine("Your Detials: "); 
            
            //Console.WriteLine("Your name is: {0}, \nReg No: {1}, \nDepartment: {2}, \nEmail: {3}, \nAge: {4}, \nSchool Name: {5}", FN + " " + LN, Reg, Department, Email, Age, SchoolName);
            Console.WriteLine($"Your name is: {FN} {LN}, \nReg No: {Department}, \nEmail: {Email}, \nAge: {Age}, \nSchool Name: {SchoolName}");
            //Console.WriteLine("Reg No: {0}", Reg);
            //Console.WriteLine("Department: {0}", Department);
            //Console.WriteLine("Email: {0}", Email);
            //Console.WriteLine("Age: {0}", Age);
            //Console.WriteLine("School Name: {0}", SchoolName);
        }
    }
}
