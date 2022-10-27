using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入層數（1-9）");

            int input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            for (int i = input; i > 0; i--)
            {
                int numOfSpaces = input - i;

                for (int j = 1; j <= numOfSpaces; j++)
                {
                    Console.Write(" ");
                }
                
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i);
                }
                
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
