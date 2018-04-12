using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            List<int> numbers = new List<int>();

            for (int i = 1; i <= 43; i++)
            {
                numbers.Add(i);
            }
            for (int i = 0; i < 6; i++)
            {
                int r = rand.Next(1, numbers.Count);
                Console.WriteLine(numbers[r]);
                numbers.RemoveAt(r);
            }
        
            Console.ReadLine();
        }
    }
}
