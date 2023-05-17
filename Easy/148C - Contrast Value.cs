using System;
 
namespace ConsoleApp1
{
    internal abstract class Program
    {
        private static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            for (var t = 0; t < n; t++) Console.WriteLine(BFinder());
        }
 
        private static int BFinder()
        {
            var n = Convert.ToInt32(Console.ReadLine());
            var arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            var i = 0;
            for (; i < n-1; i++)
            {
                if (arr[i] == arr[i+1])
                    continue;
                break;
            }
            if (i == n-1)
                return 1;
            
            var sign = arr[i + 1] > arr[i];
            var count = 1;
            for (; i < n-1; i++)
            {
                if (arr[i] == arr[i + 1])
                    continue;
                var currentSign = arr[i + 1] > arr[i];
                if (sign == currentSign)
                    continue;
                count++;
                sign = currentSign;
            }
 
            return ++count;
        }
    }
}
