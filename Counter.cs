﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statickaVarijabla
{
    class PrvaKlasa
    {
        private static int counter = 0;
        private string naziv;
        public PrvaKlasa(string naziv) {
            counter++;
            this.naziv = naziv;
        }

        public static int GetCounter() { return counter; }

        public string GetNaziv() { return naziv; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa("Prvi");
            Console.WriteLine(x.GetNaziv());
            Console.WriteLine("Vrijednost: " + PrvaKlasa.GetCounter());

            PrvaKlasa y = new PrvaKlasa("Drugi");
            Console.WriteLine(y.GetNaziv());
            Console.WriteLine("Vrijednost: " + PrvaKlasa.GetCounter());

            PrvaKlasa z = new PrvaKlasa("Treći");
            Console.WriteLine(z.GetNaziv());
            Console.WriteLine("Vrijednost: " + PrvaKlasa.GetCounter());

            //Console.WriteLine ("Vrijednost: " + PrvaKlasa.GetCounter());

            Console.ReadKey();
        }
    }
}
