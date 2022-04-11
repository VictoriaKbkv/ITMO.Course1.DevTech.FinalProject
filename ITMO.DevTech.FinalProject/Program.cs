using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITMO.DevTech.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов последовательности");
            int n = Convert.ToInt32(Console.ReadLine());
            double[] M = new double[n];
            Console.WriteLine("Введите элементы последовательности");
            for (int i = 0; i < n; i++)
            {
                M[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int First = 0; First < n - 1; First++)
            {
                int Min = First;
                for (int Current = First + 1; Current < n; Current++)
                {
                    if (M[Current] < M[Min])
                    {
                        Min = Current;
                    }
                }
                double Temp = M[First];
                M[First] = M[Min];
                M[Min] = Temp;
            }
            Console.WriteLine("Результат сортировки элементов песледовательности");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(M[i]);
            }
        }
    }   
}
