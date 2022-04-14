using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop2
{
    internal class Elettrodomestico : Prodotto
    {
        private string classe;
        private double larghezza;
        private double altezza;
        private double profondita;
        private bool corrente = false;
        public Elettrodomestico (string nome, string descrizione, double prezzo, double iva, string classe, double larghezza, double altezza, double profondita) : base(nome, descrizione, prezzo, iva)
        {
            this.classe= classe;
            this.larghezza= larghezza;
            this.altezza= altezza;
            this.profondita= profondita;
        }

        public string GetConsumo()
        {
            return this.classe;
        }
        
        public void PremiPulsanteOnOff()
        {
            if(corrente == false)
            {
            corrente = true;
                Console.WriteLine("bzzzzz... " + nome + " si è acceso/a");
            }
            else
            {
                Console.WriteLine("poooooffff... " + nome + " si è spento/a");
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
            rappresentazioneInStringa += "La classe energetica è: " + this.classe + "\n";
            rappresentazioneInStringa += "Le dimensioni sono: " + this.altezza + " - " + this.larghezza + " - " +  this.profondita + "\n";
            rappresentazioneInStringa += "**************************************" + "\n";
            return rappresentazioneInStringa;
        }


    }
}
