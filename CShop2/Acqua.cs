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
        private readonly double ph;
        private readonly string sorgente;


        public Acqua(string nome, string descrizione, double prezzo, double iva, double ph, string sorgente) : base(nome, descrizione, prezzo, iva)
        {
            
            this.ph = ph;
            this.sorgente = sorgente;

        }
       
        public string GetSorgente()
        {
            return sorgente;
        }
        public double GetPH()
        {
            return ph;
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
                Console.WriteLine("Mi dispiace la bottiglia non dispone di tutta quest'acqua, bevendo hai finito tutta l'acqua.");
                litri = 0;
                Console.WriteLine("i litri ora sono " + litri);
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

        public override void NomeEsteso()
        {
            base.NomeEsteso();
            Console.WriteLine (" - " +this.ph + " - " + this.sorgente  ) ;
        }

        public static void ConvertiInGalloni()
        {
            double gallone = 3.785;
            double litriToGallone = 0;

            if (litri > 0)
            {
                litriToGallone = gallone * litri;
                litriToGallone = Math.Round(litriToGallone, 3);
                Console.WriteLine("i tuoi litri (" + litri + ")  in galloni sono: " + litriToGallone);
            }
            
            else
            {
                litriToGallone = litriToGallone / litri;
                litriToGallone = Math.Round(litriToGallone, 3);
                Console.WriteLine("i tuoi litri (" + litri + ") in galloni sono: " + litriToGallone);
            }
        }

        public override string ToString()
        {
            string rappresentazioneInStringa = "";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            rappresentazioneInStringa += "\n**************PRODOTTO***************\n";
            rappresentazioneInStringa += "Il nome del prodotto è: " + this.nome + "\n";
            rappresentazioneInStringa += "La descrizione del mio prodotto: " + base.descrizione + "\n";
            rappresentazioneInStringa += "il codice è: " + padleft() + "\n";
            rappresentazioneInStringa += "il prezzo senza iva è: " + base.prezzo + "€" + "\n";
            rappresentazioneInStringa += "L'iva del prodotto è: " + base.iva + "%" + "\n";
            rappresentazioneInStringa += "Il prezzo del prodotto con iva è: " + CalcoloPrezzoConIva() + "€" + "\n";
            rappresentazioneInStringa += "il PH di quest'acqua è :  " + this.ph + "\n";
            rappresentazioneInStringa += "La sorgente di quest'acqua è: " + this.sorgente + "\n";
            rappresentazioneInStringa += "i litri attualmente contenuti sono:  " + litri + "\n";
            rappresentazioneInStringa += "**************************************" + "\n";
            return rappresentazioneInStringa;
        }

    }
}
