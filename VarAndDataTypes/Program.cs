using System;

namespace VarAndDataTypes
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string Course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string Page = Console.ReadLine();
            int PageNumber = Convert.ToInt32(Page);
            Console.WriteLine("Do you need help with anything? Please answer /"True / " or " / false / "");
        }
    }
}
