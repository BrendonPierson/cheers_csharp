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
            name = name.ToLower();
            System.Console.WriteLine("Hi, " + name);

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
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
