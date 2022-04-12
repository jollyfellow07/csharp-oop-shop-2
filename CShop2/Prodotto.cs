using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop2
{
    internal class Prodotto
    {
        public int codice;
        public string nome;
        public string descrizione;
        public double prezzo;
        public double iva;

        public Prodotto()
        {

        }

        public Prodotto(string nome, string descrizione, double prezzo, double iva)
        {

            this.nome = nome;
            this.descrizione = descrizione;
            this.prezzo = prezzo;
            this.iva = iva;
            Random codiceRandom = new Random();
            codice = codiceRandom.Next(100000000);

        }

        /* METODO: ASSEGNO AL CODICE*/
        public int GetCodice()
        {
            return codice;
        }

        /*bonus*/
        public virtual string padleft()
        {

            string strvalue = Convert.ToString(codice).PadLeft(8, '0');
            return strvalue;
        }

        /*STAMPA TUTTE LE CARATTERISTICHE DEL MIO PRODOTTO*/
        public override string ToString()
        {
            string rappresentazioneInStringa = "";
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            rappresentazioneInStringa += "\n**************PRODOTTO***************\n";
            rappresentazioneInStringa += "Il nome del prodotto è: " + this.nome + "\n";
            rappresentazioneInStringa += "La descrizione del mio prodotto: " + this.descrizione + "\n";
            rappresentazioneInStringa += "il codice è: " + padleft() + "\n";
            rappresentazioneInStringa += "il prezzo senza iva è: " + this.prezzo + "€" + "\n";
            rappresentazioneInStringa += "L'iva del prodotto è: " + this.iva + "%" + "\n";
            rappresentazioneInStringa += "Il prezzo del prodotto con iva è: " + CalcoloPrezzoConIva() + "€" + "\n";
            rappresentazioneInStringa += "**************************************" + "\n";
            return rappresentazioneInStringa;
        }

        /*Metodo che stampa codice e nome*/
        public virtual void NomeEsteso()
        {
            Console.Write(padleft() + " - " + nome);
        }
        /*METODO: PER CALCOLARE IL PREZZO CALCOLATO CON IVA*/

        public double CalcoloPrezzoConIva()
        {
            double prezzoFinale;
            if (iva == 22)
            {
                prezzoFinale = prezzo * 1.22;

            }
            else if (iva == 5)
            {
                prezzoFinale = prezzo * 1.05;

            }
            else
            {
                prezzoFinale = prezzo * 1.10;
            }
            prezzoFinale = Math.Round(prezzoFinale, 2);
            return prezzoFinale;
        }




    }
}
