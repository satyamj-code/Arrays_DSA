using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_DSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 2, 5, 6, 7, 8, 9, 33, 123 };
            var result = TwoSum(arr, 4);
            if (result != null)
            {
                Console.WriteLine($"Indices: {result[0]}, {result[1]}");
            }
            else
            {
                Console.WriteLine("No two sum solution found.");
            }
            Console.ReadLine();
        }
        private static int[] TwoSum(int[] x, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();
            for (int i = 0; i < x.Length; i++)
            {
                int diff = target - x[i];
                if (map.TryGetValue(diff, out var index))
                {
                    return new int[] { index, i }; 
                }
                if (!map.ContainsKey(x[i]))
                {
                    map[x[i]] = i;
                }
            }

            return null;
        }
    }
}
