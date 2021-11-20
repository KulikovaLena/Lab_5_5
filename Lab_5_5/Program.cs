using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Vvedite znachenie");
            n = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if ((i+j)%2==1)
                    {
                        a[i, j] = 0;
                    }
                    else
                    {
                        a[i, j] = 1;
                    }
                    Console.Write("{0,4} ", a[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
