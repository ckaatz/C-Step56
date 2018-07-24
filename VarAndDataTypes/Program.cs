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
            Console.WriteLine("Do you need help with anything? Please answer \"True\" or \"False\".");
            string NeedHelp = Console.ReadLine();
            bool RequestHelp = Convert.ToBoolean(NeedHelp);
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string Experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide?");
            string Feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string Hours = Console.ReadLine();
            int StudyHours = Convert.ToInt32(Hours);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
