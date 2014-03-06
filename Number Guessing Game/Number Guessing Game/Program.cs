using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Number_Guessing_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int guess, h = 100, l = 0, c;
            while (true)
            { 
                guess = (h + l) / 2;
                Console.WriteLine("Is your number {0}?  (h, l, c) : ", guess);
                
                input = Console.ReadLine();

                if (input == "h")
              {
                l = guess + 1;
              }
                if(input == "l")
              {
                h = guess - 1;
              }
 
                 if(input == "c")
              {
                    break;
              }
            }
        }
    }
}
