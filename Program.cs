using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopgyak
{
    public class szemely
    {
        private string nev;
        private int kor;

        public szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }
        public string Kir()
        {
            return $"A tanulo neve: {nev} és {kor} éves!";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            szemely tanulo1 = new szemely("Jani", 55);
            Console.WriteLine(tanulo1.Kir());
            szemely tanulo2 = new szemely("Peti", 25);
            Console.WriteLine(tanulo2.Kir());
        }
    }
}
