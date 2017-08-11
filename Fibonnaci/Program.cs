using System;

namespace Fibonnaci
{
     class Program
     {
          static void Main(string[] args)
          {
               //Variables
               int pos, fibNumber;

               //Get the position in the Fibonacci sequence from the user
               Console.Write("Enter a position in the Fibonacci sequence: ");
               string input = Console.ReadLine();

               //Input validation
               while (int.TryParse(input, out pos) == false || pos < 0)
               {
                    Console.Write("Error! Position must be a positive integer: ");
                    input = Console.ReadLine();
               }

               //Retrieve the number at that position in the Fibonacci sequence
               fibNumber = GetFibonacciNumber(pos);

               //Output
               Console.WriteLine("Position {0} is the value {1} in the Fibonacci sequence.", pos, fibNumber);
          }
          
          //Receives a position in the Fibonnaci sequence from the user,
          //and returns the number at that position in the sequence.
          //Returns 0 if a negative parameter is passed.
          public static int GetFibonacciNumber(int position)
          {
               int firstNumber = 0, secondNumber = 1, fibonacciNumber;
               fibonacciNumber = firstNumber + secondNumber;
               
               //Special cases: 0 and 1
               if (position <= 0)
                    return 0;
               if (position == 1)
                    return 1;

               //Positions 2 and higher
               else
               {
                    for (int i = 0; i < position - 2; i++)
                    {
                         firstNumber = secondNumber;
                         secondNumber = fibonacciNumber;
                         fibonacciNumber = firstNumber + secondNumber;
                    }
               }

               return fibonacciNumber;
          }
     }
}
