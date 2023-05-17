using System;
using System.Linq;
 
 
namespace ConsoleApp1
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
            Array.Sort(arr);
            Array.Reverse(arr);
            
            var sum = arr.Sum();
            var currentSum = 0;
            for (var i = 0; i < n; i++)
            {
                currentSum += arr[i];
                if (sum - currentSum >= currentSum) continue;
                Console.WriteLine(i+1);
                return;
            }
        }
    }
}
