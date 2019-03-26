using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab
{
    class Permutasyon : Faktoriyel
    {
        /*int sayi1, sayi2;                             // hocanın istediği bu kısım mı anlamadım onu alttaki daha mantıklı geldi bide 
        public Permutasyon(int ustsinir, int altsinir)
        {
            sayi1 = ustsinir;
            sayi2 = altsinir;
        }*/
        public void Order(int ustsinir, int altsinir)
        {
            double sonuc;
            int s1fakt = 1, s2fakt = 1;
            for (int i = 1; i <= ustsinir; i++)             // bölümün üst kısmı
                s1fakt = s1fakt * i;

            for (int i = 1; i <= ustsinir - altsinir; i++) // bölümün alt kısmı
                s2fakt = s2fakt * i;

            sonuc = s1fakt / s2fakt;
            Console.WriteLine("Permütasyon Sonucu = {0}", sonuc);
        }
    }
}
