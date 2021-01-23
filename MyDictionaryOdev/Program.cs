using System;
using System.Collections.Generic;

namespace MyDictionaryOdev
{
    class Program
    {
       
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenci = new MyDictionary<int, string>();
            ogrenci.Add(2, "Almima");
            ogrenci.Add(3, "Erdem");
            ogrenci.Add(4, "Osman");
            ogrenci.Add(5, "Ali");

            ogrenci.Yazdir();

        }
    }
}
