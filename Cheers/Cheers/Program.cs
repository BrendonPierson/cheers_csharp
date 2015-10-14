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
            bool firstChar = true;

            foreach (char letter in name)
            {
                if (vowels.Contains(letter))
                {
                    if (firstChar)
                    {
                        System.Console.WriteLine("Give me an " + letter.ToString().ToUpper() + "!");
                        firstChar = false;
                    } else
                    {
                        System.Console.WriteLine("Give me an " + letter + "!");
                    }
                } 
                else
                {
                    if (firstChar)
                    {
                        System.Console.WriteLine("Give me a " + letter.ToString().ToUpper() + "!");
                        firstChar = false;
                    }
                    else
                    {
                        System.Console.WriteLine("Give me a " + letter + "!");
                    }
                }
            }
            System.Console.WriteLine("Yay " + name.First().ToString().ToUpper() + name.Substring(1) + "!");
            System.Console.WriteLine("Press any key to exit.");
            System.Console.ReadKey();
        }
    }
}
