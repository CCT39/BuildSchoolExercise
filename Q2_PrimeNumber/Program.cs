using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2_PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int max = 200;

            int[] primes = new int[max + 1];
            if (max > 1)
                primes[2] = 2;

            //參考埃拉托斯特尼的篩法尋找質數，若其為合數則將陣列的對應位置設為0
            for (int i = 3; Math.Pow(i, 2) <= max; i++)
            {
                for (int j = 2; j <= i; j++) //先找出小於等於sqrt(max)的質數
                {
                    if (i % j == 0 && i != j)
                    {
                        primes[i] = 0;
                        break;
                    }
                    else
                        primes[i] = i;
                }                
            }

            //用已知的質數檢查大於sqrt(max)的數是否是質數
            for (int k = Convert.ToInt32(Math.Sqrt(max)) + 1; k < max + 1; k++)
            {
                for (int p = 1; p <= Math.Sqrt(max); p++)
                {
                    if (primes[p] > 0)
                    {
                        if (k % p <= 0)
                        {
                            primes[k] = 0;
                            break;
                        }                            
                        else
                            primes[k] = k;
                    }
                }
            }

            //寫出篩出的質數
            for (int r = 0; r < max + 1; r++)
            {
                if (primes[r] > 0)
                    Console.WriteLine(primes[r]);
            }

            Console.ReadLine();
        }
    }
}
