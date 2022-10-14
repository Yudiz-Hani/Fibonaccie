using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 1, b = 1, c;
            Console.WriteLine("Enter The Number till that you want to print fibonaccie: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Series are as below: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{a}");
                c=a+b;
                a=b;
                b=c;
            }
        }
    }
}
