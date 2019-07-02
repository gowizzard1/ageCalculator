using System;
using System.Globalization;

namespace firstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDate = DateTime.Now;
            Console.WriteLine("What is your name?");
            string input = Console.ReadLine();
            Console.WriteLine("Good Evening " + input);
            Console.WriteLine("What is your Gender?");
            string gender = Console.ReadLine();
            if (gender == "male")
            {
                Console.WriteLine("How are you doing Handsome?");
            }
            else if (gender == "female")
            {
                Console.WriteLine("How is the going girl?");
            }
            else
            {
                Console.WriteLine("That gender is not known");
            }
            Console.WriteLine("What is your birthday? format dd/mm/yyyy");
            DateTime dob = Convert.ToDateTime(Console.ReadLine());
            int age = new DateTime(myDate.Subtract(dob).Ticks).Year - 1;
            DateTime PastYearDate = dob.AddYears(age);
            int Months = 0;
            for (int i = 1; i <= 12; i++)
            {
                if (PastYearDate.AddMonths(i) == myDate)
                {
                    Months = i;
                    break;
                }
                else if (PastYearDate.AddMonths(i) >= myDate)
                {
                    Months = i - 1;
                    break;
                }
            }
            int Days = myDate.Subtract(PastYearDate.AddMonths(Months)).Days;
            int Hours = myDate.Subtract(PastYearDate).Hours;
            int Minutes = myDate.Subtract(PastYearDate).Minutes;
            int Seconds = myDate.Subtract(PastYearDate).Seconds;
            Console.WriteLine("Your age is {0}", age);
        }
    }
}
