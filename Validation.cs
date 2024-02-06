using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Student_Information_Display
{
    public static class Validation
    {
        public static Gender SelectGender(string gender)
        {
            switch (gender)
            {
                case "1":
                    return Gender.Male;
                case "2":
                    return Gender.Female;
                case "3":
                    return Gender.PrefertNotToSay;
                default:
                    return Gender.SelectGender;
            }
        }

        public static string CheckGender(string gender)
        {
            while (gender != "1" && gender != "2" && gender != "3")
            {
                Validation.InvalidEntry(gender);
                Console.ResetColor();
                gender = Console.ReadLine();
            }

            return gender;
        }

        public static string CheckFirstName(string firstname)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(firstname))
                {
                   Validation.EmptyPrompt(firstname);
                }
                else if (firstname.Any(char.IsDigit))
                {
                    Validation.IsDigit(firstname);
                }
                else if (firstname.Length > 10)
                {
                    Validation.GreaterThanTen(firstname);
                }
                else break;
                firstname = Console.ReadLine();
            }
            
            return firstname;
        }
        public static string CheckSecondNmae(string lastName, string firstName)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(lastName))
                {
                    Validation.EmptyPrompt(lastName);
                }
                else if (lastName.Any(char.IsDigit))
                {
                    Validation.IsDigit(lastName);
                }
                else if (lastName == firstName)
                {
                    Validation.NameComparism(firstName, lastName);
                }
                else break;

                lastName = Console.ReadLine();
            }


            return lastName;
        }

        public static string CheckRegNumber(string regnumber)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(regnumber))
                {
                    Validation.EmptyPrompt(regnumber);
                }
                else if (regnumber.Length > 10)
                {
                    Validation.GreaterThanTen(regnumber);
                }
                else break;

                regnumber = Console.ReadLine();
            }

            return regnumber;
        }

        public static string Department(string department)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(department))
                {
                    Validation.EmptyPrompt(department);
                }
                else if (department.Any(char.IsDigit))
                {
                    Validation.IsDigit(department);
                }
                else break;

                department = Console.ReadLine();
            }

            return department;
        }

        public static string EmailChecker(string email)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(email))
                {
                    Validation.EmptyPrompt("email");
                }
                else if (!Validation.IsValidEmail(email))
                {
                    Validation.EmailPrompt("email");
                }
                else break;
                Console.ResetColor();
                email = Console.ReadLine();
            }

            return email;
        }

        public static int Age(int age)
        {
            while (true)
            {
                if (age <= 0 || age >= 80)
                {
                    Validation.AgeLimitation(age);
                }
                else if (age == 18)
                {
                    Validation.UnderAge(age);
                }
                else if (age > 10)
                {
                    Validation.UnderAge(age);
                }
                else break;
                age = Convert.ToInt32(Console.ReadLine());
            }

            return age;
        }

        public static string SchoolName(string schoolname)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(schoolname))
                {
                    Validation.EmptyPrompt(schoolname);
                }
                else if (schoolname.Any(char.IsDigit))
                {
                    Validation.IsDigit(schoolname);
                }
                else break;
                schoolname = Console.ReadLine();
            }

            return schoolname;
        }

        public static void NameComparism(string f, string s)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"{s} cannot be samething as the {f}");
            Console.ResetColor();
        }

        public static void EmptyPrompt(string field)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine($"{field} cannot be empty, Please re-enter {field}");
            Console.ResetColor();
        }

        public static void IsDigit(string field)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine($"{field} cannot contain numbers, Pls re-enter {field}");
            Console.ResetColor();
        }

        public static void GreaterThanTen(string field)
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{field} cannot be greater than ten characters, Pls re-enter {field}");
            Console.ResetColor();
        }

        public static void EqaulString()
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("Your lastname cannot be same thing with your firstname");
            Console.ResetColor();
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                return Regex.IsMatch(email, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
            }
            catch
            {
                return true;
            }
        }

        public static void EmailPrompt(string email)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter a valid email");
        }

        public static void EmailCounter(string email)
        {
            while (true)
            {
                if (string.IsNullOrEmpty(email))
                {
                    EmailCounter(email);
                }
            }
        }

        public static void AgeLimitation(int field)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{field} age cannot be less than one year and cannot be more than eighty years");
            Console.ResetColor();
        }

        public static void DisplayInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public static void UnderAge(int field)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{field} cannot be less than eighten years");
            Console.ResetColor();
        }

        public static void InvalidEntry(string gender)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Invalid Selection");
        }
    }
}
