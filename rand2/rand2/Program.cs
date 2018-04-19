using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rand2
{
    class Program
    {
        static void Main(string[] args)
        {

            // 創造list
            List<int> numbers = new List<int>();

            // 加入數字
            for (int i = 1; i<=42; i++)
            {
                numbers.Add(i);
            }

            // 宣告隨機亂數
            Random rand = new Random();

            //輸出留個數字 并從list 移除。
            for(int i = 0; i <6; i++)
            {
                int r = rand.Next(1, numbers.Count);
                Console.Write(numbers[r] + " ");
                numbers.RemoveAt(r);
            }

            Console.ReadKey();
        }
    }
}
