using System;

namespace GC_Deliverable_One
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("VACATION DECISIONS");

            //Vacation type selection
            Console.WriteLine("What kind of trip would you like to go on, musical, tropical, or adventurous? ");
            string vacationType = Console.ReadLine();
            string message = "";


            if (vacationType == "musical")
                message = "New Orleans";
            else if (vacationType == "tropical")
                message = "a beach vacation in Mexico";
            else if (vacationType == "adventurous")
                message = "whitewater rafting in the Grand Canyon";
            else
                message = "[invalid Entry]";


            //Group size
            Console.WriteLine("How many are in your group? ");
            int groupSize = Convert.ToInt32(Console.ReadLine());
            string suggestion = "";


            if (groupSize <= 2)
                suggestion = "first class flight";
            else if (groupSize <= 5)
                suggestion = "helicopter";
            else
                suggestion = "charter flight";

            string Result = "Since you're a group of " + groupSize + " going on a(n) " + vacationType + " vacation, you should take a " + suggestion + " to " + message + ".";
            Console.WriteLine(Result);

            //String s1 = "Since you're a group of ";
            //String s2 = "going on a ";
            //String s3 = "vacation, you should take a ";
            //string s4 = "to ";

            //var Result = String.Concat(s1, groupSize, s2, vacationType, s3, suggestion, s4, message);
            //Console.WriteLine(Result);
        }
    }
}
