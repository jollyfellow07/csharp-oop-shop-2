using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop2
{
    internal class Acqua : Prodotto
    {
        private static double litri = 1.5;
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
                
                litri = litri - bere;
                litri = Math.Round(litri, 1);
                Console.WriteLine("hai bevuto " + bere + " litri e ti restano " + litri);

            }
            else
            {
                Console.WriteLine("Mi dispiace la bottiglia non dispone di tutta quest'acqua");
            }
            litri = Math.Round(litri, 1);
            return litri;
        }

        public double AggiungiAcqua()
        {
            Console.Write("Di quanti litri vuoi riempire la bottiglia?  ");
            double aggiungi = double.Parse(Console.ReadLine());
            
            litri = litri + aggiungi;
            if(litri > 1.5)
            {
                litri = 1.5;
                Console.WriteLine("Mi dispiace hai fatto un strabocco");
                Console.WriteLine("la quantita di acqua disponibile nella bottiglia è " + litri);
            }
            else
            {
                litri = Math.Round(litri, 1);
                Console.WriteLine("I litri disponibili ora sono:  " + litri);
            }
            litri = Math.Round(litri, 1);
            return litri;
        }

        public double SvuotaAcqua()
        {
            litri = 0;
            return litri;
        }





    }
}
