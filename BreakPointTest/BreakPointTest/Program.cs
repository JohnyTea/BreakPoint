using System;

namespace BreakPointTest
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Zgadnij o jakiej liczbie myślę!");
            RandomNumber number = new RandomNumber();
            number.generateNumber();

            double guess = double.Parse(Console.ReadLine());
            double check = number.checkAnswear(guess);
            while (check != 0)
            { 
                
                if (check == -1)
                {
                    Console.WriteLine("To za mało");
                }
                else if (check == 1)
                {
                    Console.WriteLine("To za dużo");
                }
                guess = double.Parse(Console.ReadLine());
                check = number.checkAnswear(guess);
            }
            Console.WriteLine("Brawo Zgadłeś liczbę!");
        }
    }
}
