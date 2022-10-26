using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_LoopWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一段中文字");
            
            string input = Console.ReadLine();
            string[] splitted = new string[input.Length];

            //把輸入的中文字串分成一個一個字
            for (int i = 0; i < input.Length; i++)
            {
                splitted[i] = input.Substring(i, 1);
            }

            //計算頭尾有多少成對的字，若無成對則直接結束檢查
            int countPairs = 0;
            for (int j = 1; j <= input.Length / 2; j++)
            {
                if (splitted[j - 1] == splitted[input.Length - j])
                    countPairs += 1;
                else
                    break;
            }

            if (countPairs == input.Length / 2)
                Console.WriteLine("是回文");
            else
                Console.WriteLine("不是回文");

            Console.ReadLine();
        }
    }
}
