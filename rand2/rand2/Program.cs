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

            // 讓使用者輸入最高跟最低的亂數限制
            Console.WriteLine("請輸入最低的亂數限制: ");
            int mincount = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入最高的亂數限制: ");
            int maxcount = int.Parse(Console.ReadLine());

            // 讓使用者輸入需要多少的亂數
            Console.WriteLine("請輸入需要多少亂數：");
            int randcount = int.Parse(Console.ReadLine());
            Console.WriteLine("▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆我是分割線▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆▆");

            // 加入數字
            for (int i = mincount; i<=maxcount; i++)
            {
                numbers.Add(i);
            }

            // 宣告隨機亂數
            Random rand = new Random();

            // 輸出留個數字 并從list 移除。
            for(int i = 0; i <randcount; i++)
            {
                int r = rand.Next(1, numbers.Count);
                Console.Write(numbers[r] + " ");
                numbers.RemoveAt(r);
            }

            Console.ReadKey();
        }
    }
}
