using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkatTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Trojkat x;
            x = new Trojkat(2, 1, 2.5);
            Console.WriteLine(x); //bez zawartości drukuje tylko jakiego typu jest x czyli TrojkatTest
            Console.WriteLine(x.Obwod() );//funkcja Obwod
            Console.WriteLine(x.Obwód);// properties get Obwód
            // x.C = 4; // przypisanie 4 do c
            Console.WriteLine(x.Obwód);
            Console.WriteLine(x.Pole); //NaN rozwiązanie to nie jest liczba not a number


            var y = new Trojkat();
            Console.WriteLine(y);
        }
        
      
    }
}
