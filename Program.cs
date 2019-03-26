using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Faktoriyel f = new Faktoriyel();
            f.Order(6);

            Permutasyon p = new Permutasyon();
            p.Order(5, 2);

            Kombinasyon k = new Kombinasyon();
            k.Order(5, 2);

            Fibonacci fib = new Fibonacci();
            fib.Order(8);
            

            Console.ReadLine();
        }
    }
}
