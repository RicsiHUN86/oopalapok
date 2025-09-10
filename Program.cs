using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace oopgyak
{
    public class szemely
    {

        private string nev;
        private int kor;

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public int Kor
        {
            get { return kor; }
            set
            { kor = value;
            }
        }

        /*public szemely(string Nev, int Kor)
        {
            nev = Nev;
            kor = Kor;
        }
        public string Kir()
        {
            return $"A tanulo neve: {nev} és {kor} éves!";
        }*/

        public override string ToString()
        {
            return $"A tanulo neve: {nev} és kora {kor}!";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            szemely tanulo1 = new szemely();
            tanulo1.Nev = "Jani";
            tanulo1.Kor = 15;
            Console.WriteLine(tanulo1);
            

            
        }
    }
}
