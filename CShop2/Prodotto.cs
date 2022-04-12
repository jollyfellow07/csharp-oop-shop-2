using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop2
{
    internal class Prodotto
    {
        private int codice;
        public string nome;
        private string descrizione;
        private double prezzo;
        private double iva;

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
        public void stampa()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("\n**************PRODOTTO***************");
            Console.WriteLine("Il nome del prodotto è: " + nome);
            Console.WriteLine("La descrizione del mio prodotto: " + descrizione);
            Console.WriteLine("il codice è: " + padleft());
            Console.WriteLine("il prezzo senza iva è: " + prezzo + "€");
            Console.WriteLine("L'iva del prodotto è: " + iva + "%");
            Console.WriteLine("Il prezzo del prodotto con iva è: " + CalcoloPrezzoConIva() + "€");
            Console.WriteLine("**************************************");
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
