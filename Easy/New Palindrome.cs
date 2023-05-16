using System;
 
namespace ConsoleApp1
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            for (var t = 0; t < n; t++) Palindrome();
        }
 
        private static void Palindrome()
        {
            var str = Console.ReadLine();
            for (var i = 0; i < str.Length/2 -1; i++)
            {
                if (str[i] == str[i + 1]) continue;
                Console.WriteLine("YES");
                return;
            }
            Console.WriteLine("NO");
        }
    }
}
