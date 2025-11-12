using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Game
{
    public class GameBoard
    {
        public string GetWord(int number)
        {
            // FizzBuzz: Divisible by both 3 and 5 (must check first)
            if (number % 15 == 0)
            {
                return "FizzBuzz";
            }
            
            // Fizz: Divisible by 3 only
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            
            // Buzz: Divisible by 5 only
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            
            // Return the number as string
            return number.ToString();
        }
    }
}
