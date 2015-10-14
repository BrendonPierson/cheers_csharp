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
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Hi, " + name);
            name = name.ToLower();

            System.Console.WriteLine("What's your birthday? ex: 09/20");
            string bdayString = System.Console.ReadLine();

            string vowels = "aeiouh";

            foreach (char letter in name)
            {
                if (vowels.Contains(letter))
                {
                    System.Console.WriteLine("Give me an.. " + letter);              
                } 
                else
                {
                    System.Console.WriteLine("Give me a.. " + letter);
                }
            }
            System.Console.WriteLine(name.ToUpper() + " is.. GRAND!");
      
          
            
            int mon = Int32.Parse(bdayString.Substring(0, 2));
            int day = Int32.Parse(bdayString.Substring(3, 2));

            DateTime userBday = new DateTime(DateTime.Now.Year, mon, day);

            DateTime now = DateTime.Now;

            
            int result = DateTime.Compare(userBday, now);

            if(result == 0)
            {
                System.Console.WriteLine("Happy Birthday " + name + " !");
            }
            if(result > 0)
            {
                TimeSpan elapsed = userBday.Subtract(now);
                double daysAgo = elapsed.TotalDays;
                System.Console.WriteLine("It is " + daysAgo.ToString("0") + " days until your birthday.");
            }
            if(result < 0)
            {
                TimeSpan elapsed = now.AddYears(1).Subtract(userBday);
                double daysAgo = elapsed.TotalDays;
                System.Console.WriteLine("It is " + (daysAgo.ToString("0")) + " days until your birthday.");
            }
            
            

            

            
            
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
