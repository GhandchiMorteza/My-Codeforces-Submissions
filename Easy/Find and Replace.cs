using System;
using System.Collections.Generic;
 
namespace ConsoleApp1
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            for (var t = 0; t < n; t++) Alternating();
        }
 
        private static void Alternating()
        {
            var visited = new List<char>();
            var n = Convert.ToInt32(Console.ReadLine());
            var input = Console.ReadLine();
            for (var i = 0; i < n; i++)
            {
                var character = input[i];
                if (visited.Contains(character))
                    continue;
                var index = i + 1;
                var check = i % 2;
                while ((index = input.IndexOf(character, index)) != -1)
                {
                    if (index % 2 != check)
                    {
                        Console.WriteLine("NO");
                        return;
                    }
 
                    index++;
                }
            }
 
            Console.WriteLine("YES");
        }
    }
}
