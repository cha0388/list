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

            for (int i = 0; i < 6; i++)
            {
                int r0 = rand.Next(1, 43);
                int r1 = rand.Next(1, 43);
                int r2 = rand.Next(1, 43);
                int r3 = rand.Next(1, 43);
                int r4 = rand.Next(1, 43);
                int r5 = rand.Next(1, 43);

                Console.WriteLine("{0:00} {1:00} {2:00} {3:00} {4:00} {5:00}", r0, r1, r2, r3, r4, r5);
            }

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
