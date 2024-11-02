using System;

namespace DecisionTreeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to this decision tree!!!");

            // گره اول: سؤال اولیه
            Console.WriteLine("are you happy in your way of living?");
            string response = Console.ReadLine().ToLower();

            if (response == "yes")
            {
                // گره دوم: گزینه‌های بعدی برای پاسخ "بله"
                Console.WriteLine("do have any passion in your life?");
                string answer1 = Console.ReadLine().ToLower();

                if (answer1 == "yes")
                {
                    Console.WriteLine("continue on your way:)))))");
                }
                else
                {
                    Console.WriteLine("why didnt you find that? do you wanna live or just being alive?");
                }
            }
            else if (response == "no")
            {
                // گره دوم: گزینه‌های بعدی برای پاسخ "خیر"
                Console.WriteLine("Do you have any value for yourself?");
                string xxx = Console.ReadLine().ToLower();

                if (xxx == "yes")
                {
                    Console.WriteLine("thats a good step,try new things and make wonderful experience to figure out {what do you live for?} ");
                }
                else
                {
                    Console.WriteLine("not glad to hear that:) find your lifestyle to be sure you are walking in the right way!!!");
                }
            }
            else
            {
                Console.WriteLine("plese answer just with yes or no.");
            }
        }
    }
}