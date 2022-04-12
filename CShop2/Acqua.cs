﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop2
{
    internal class Acqua : Prodotto
    {
        private static double litri=1.5;
        public static readonly double ph;
        public static readonly string sorgente;

        public Acqua(string name, string descrizione, double prezzo, double iva) : base(name, descrizione, prezzo, iva)
        {
        }

        public double BeviAcqua()
        {
            Console.Write("Quanti litri vuoi bere? ");
            double bere = double.Parse(Console.ReadLine());
            if (bere <= litri)
            {
                 litri = litri - bere ;
                Console.WriteLine("hai bevuto " + bere + " litri e ti restano " + litri);

            }else
            {
                Console.WriteLine("Mi dispiace la bottiglia non dispone di tutta quest'acqua");
            }
            return litri;
        }

       



    }
}