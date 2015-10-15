using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello there.  What's your name?");
            // Get user name input
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Hi, " + name);
            // Lowercase everything
            name = name.ToLower();

            System.Console.WriteLine("What's your birthday? ex: 09/20");
            // Get user birthday input
            string bdayString = System.Console.ReadLine();

            // Store letters that require an
            string vowels = "halfnorsemix";

            // Choose correct article in cheer for all letters
            foreach (char letter in name)
            {
                if (Char.IsLetter(letter))
                {
                    if (vowels.Contains(letter))
                    {
                        System.Console.WriteLine("Give me an... " + letter);
                    }
                    else
                    {
                        System.Console.WriteLine("Give me a...  " + letter);
                    }
                }
            }
            // Capitalize final name cheer.
            System.Console.WriteLine(name.ToUpper() + " is.. GRAND!");      
          
            // Parse user input date string into a month and day int
            int mon = Int32.Parse(bdayString.Substring(0, 2));
            int day = Int32.Parse(bdayString.Substring(3, 2));

            // Create birthday DateTime with user provided ints and current year
            DateTime userBday = new DateTime(DateTime.Now.Year, mon, day);

            // Create current DateTime object without time by using Today instead of Now
            DateTime now = DateTime.Today;

            // Compare the birthday to now to determine if it is currently
            // the user's birthday or how the time to birthday should be calculated
            int result = DateTime.Compare(userBday, now);
            if(result == 0)
            {
                System.Console.WriteLine("Happy Birthday " + name + " !");
            }
            if(result > 0)
            {
                TimeSpan elapsed = userBday.Subtract(now);
                double daysAgo = elapsed.TotalDays;
                System.Console.WriteLine("It is " + daysAgo.ToString("0") + " days until your next birthday.");
            }
            if(result < 0)
            {
                TimeSpan elapsed = now.AddYears(1).Subtract(userBday);
                double daysAgo = elapsed.TotalDays;
                System.Console.WriteLine("It is " + (daysAgo.ToString("0")) + " days until your next birthday.");
            }
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
