using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Fibonacci : IComparable 
    {
        public void Order(int sayi)
        {
            int s1 = 0, s2 = 1, snew = 0;
            if (sayi == 1)
                Console.WriteLine("Fibonacci Sayisi = 0");
            else if (sayi == 2)
                Console.WriteLine("Fibonacci Sayisi = 1");
            else
            {
                for (int i = 2; i < sayi; i++)
                {
                    snew = s1 + s2;
                    s1 = s2;
                    s2 = snew;
                }
                Console.WriteLine("Fibonacci Sayisi = {0}", snew);
            }
        }
    }
}
