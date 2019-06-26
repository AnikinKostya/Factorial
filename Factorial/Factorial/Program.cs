using System;


namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите число n: ");

            n = int.Parse(Console.ReadLine());

            int factorial = 1;   

            for (int i = 2; i <= n; i++) 
            {
                factorial = factorial * i;
            }

            Console.WriteLine(factorial);
            Console.ReadLine();
        }
    }
}
