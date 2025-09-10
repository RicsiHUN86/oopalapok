using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopgyak
{
    public class szemely
    {
        public string nev = "Ádám";
        public int kor = 34;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            szemely tanulo1 = new szemely();
            Console.WriteLine($"A tanulo neve: {tanulo1.nev} és {tanulo1.kor} éves!");
        }
    }
}
