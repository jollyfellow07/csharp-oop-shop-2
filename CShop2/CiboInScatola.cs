using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop2
{
    internal class CiboInScatola : Prodotto
    {
        private readonly string materiale=("Alluminio");
        private static double caricoMaxContenitore = 300;
        private static double caricoAttualeContenitore = 0;
        private string cibo;

        public CiboInScatola(string nome, string descrizione, double prezzo, double iva, string cibo) : base(nome, descrizione, prezzo, iva)
        { 
        this.cibo=cibo;
        }
        public string GetCibo()
        {
            return cibo;
        }
        public double AggiungiCibo()
        {
            Console.Write("Quanti grammi di " + cibo + " vuoi inserire?" );
            double aggiungi = double.Parse(Console.ReadLine());

            caricoAttualeContenitore = caricoAttualeContenitore + aggiungi;
            if (caricoAttualeContenitore > caricoMaxContenitore)
            {
                caricoAttualeContenitore = 300;
                Console.WriteLine("Mi dispiace hai fatto uno strabocco");
                Console.WriteLine("la quantita di acqua disponibile nella scatola è  " + caricoAttualeContenitore);
            }
            else
            {
                caricoAttualeContenitore = Math.Round(caricoAttualeContenitore, 1);
                Console.WriteLine("i grammi di cibo all'interno ora sono:  " + caricoAttualeContenitore);
            }
            caricoAttualeContenitore = Math.Round(caricoAttualeContenitore, 1);
            return caricoAttualeContenitore;
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
            rappresentazioneInStringa += "il cibo inserito in questa scatola è :  " + this.cibo + "\n";
            rappresentazioneInStringa += "i grammi all' interno della scatola sono: " + caricoAttualeContenitore+ "\n";
            rappresentazioneInStringa += "il materiale del contenitore è:  " + materiale + "\n";
            rappresentazioneInStringa += "**************************************" + "\n";
            return rappresentazioneInStringa;
        }

    }
}
