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
<<<<<<< HEAD
         int secretNum = 95, guessNum;

         Console.WriteLine("Guess a number between 0 and 100: ");
         guessNum = Int32.Parse(Console.ReadLine());

         if (secretNum == guessNum)
            Console.WriteLine("Great guess,you win!");

         else if (secretNum > guessNum)
            Console.WriteLine("Sorry too high!");

         else if (secretNum < guessNum)
            Console.WriteLine("Sorry too low!");

         else
            Console.WriteLine("You can play again later.");




=======
         int secretNum = 95, guessNum1 , guessNum2;

         Console.WriteLine("Guess a number between 0 and 100: ");
         guessNum1 = Int32.Parse(Console.ReadLine());

         Console.WriteLine("Guess a number between 0 and 100: ");
         guessNum2 = Int32.Parse(Console.ReadLine());


         if (secretNum == guessNum1 && secretNum == guessNum2 )
            Console.WriteLine("Great guess,you win!");

         else if (secretNum > guessNum1 || secretNum > guessNum2)
            Console.WriteLine("Sorry too high!");

         else if (secretNum < guessNum1 || secretNum < guessNum2)
            Console.WriteLine("Sorry too low!");

         else 
            Console.WriteLine("You can play again later.");

                 
>>>>>>> origin/LGRN424-patch-1
         Console.ReadLine();
        
      }
   }
}

