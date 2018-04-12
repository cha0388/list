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
            //設名為rand的亂數
            Random rand = new Random();

            //產生名為number的list
            List<int> numbers = new List<int>();

            //在number裡加入數字1-42
            for (int i = 1; i <= 43; i++)
            {
                numbers.Add(i);
            }

            //執行六次
            for (int i = 0; i < 6; i++)
            {
                //產生名為r的數(範圍:1-number的數量)
                int r = rand.Next(1, numbers.Count);

                //寫下number中的第r個數字
                Console.WriteLine(numbers[r]);

                //刪除已寫過的數字
                numbers.RemoveAt(r);
            }
        
            Console.ReadLine();
        }
    }
}
