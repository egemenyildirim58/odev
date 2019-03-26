using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Faktoriyel : IComparable
    {
        /*int sayi;
        public Faktoriyel(int sayi)
        {
            this.sayi = sayi;
        }*/
        public void Order(int sayi)
        {
            int fakt = 1;
            for (int i = 1; i <= sayi ; i++)
            {
                fakt = fakt * i;
            }
            Console.WriteLine("Girilen degerin faktoriyeli = {0}", fakt);
        }

    }
}
