﻿using System;

namespace DegerVeReferansTipleri
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 60;
            //sayi1 = 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] = 999

            //int, decimal, double, float, bool... => Değer tipleri
            //array, class, interface => Referans tipleri
            //arrayleri birbirine eşitlerken aslında birbirinin referanslarına eşitlediğimiz için sonuç böyle oluyor.
        }
    }
}
