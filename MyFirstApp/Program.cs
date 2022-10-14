using System;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, a = 0, b = 1, c;
            Console.WriteLine("Enter The Number till that you want to print fibonaccie: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Series are as below: ");
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 2; i < n; i++)
            {
                c=a+b;
                Console.WriteLine($"{c}");
                a=b;
                b=c;
            }
        }
    }
}
