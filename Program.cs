using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace J2P_CH3a
{
   class Program
   {
      static void Main(string[] args)
      {
         int secretNum = 5, guessNum;

         Console.WriteLine("Guess a number between 0 and 10: ");
         guessNum = Int32.Parse(Console.ReadLine());

         if (secretNum == guessNum)
            Console.WriteLine("Great guess,you win!");

         else if (secretNum > guessNum)
            Console.WriteLine("Sorry too high!");

         else if (secretNum < guessNum)
            Console.WriteLine("Sorry too low!");

         else
            Console.WriteLine("You can play again later.");




         Console.ReadLine();
        
      }
   }
}

