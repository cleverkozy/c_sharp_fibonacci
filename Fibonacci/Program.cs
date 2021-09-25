using System;
using System.Linq;

namespace Fibonacci
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int number = Convert.ToInt32(Console.ReadLine());
            int[] arrayF = {0, 1};
            while (true)
            {
                int lastItem = arrayF[arrayF.Length - 1];
                int lastItem2 = arrayF[arrayF.Length - 2];
                if (lastItem + lastItem2 > number)
                {
                    break;
                }

                arrayF = arrayF.Concat(new[] {lastItem + lastItem2}).ToArray();
            }

            foreach (var item in arrayF)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}