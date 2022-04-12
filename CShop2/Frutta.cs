using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShop2
{
    internal class Frutta : Prodotto
    {
        public string[] pezziFrutta =  new String[5];


        public Frutta ()
        {
        }
        //METODO PER COMPORRE IL MIO SACCHETTO DI FRUTTA CON MASSIMO 5 PRODOTTI
        public void ComposizioneSacchetto()
        {
            Console.WriteLine("\nQuanti pezzi di frutta vuoi comprare?");
            int pezziDaAcquistare;
            do
            {
                Console.WriteLine("Inserisci un numero da 0 a 5");
                pezziDaAcquistare = int.Parse(Console.ReadLine());

            } while (pezziDaAcquistare > 5 && pezziDaAcquistare <= 0);

            for(int i = 0; i < pezziDaAcquistare; i++)
            {
                Console.WriteLine("inserisci il pezzo di frutta numero " + (i + 1) + " di " + pezziDaAcquistare +  " da acquistare");
                pezziFrutta[i]=Console.ReadLine();

            }
            //Stampa del mio array
            Console.Write("[");
            for (int i = 0; i < pezziFrutta.Length; i++)
            {
                Console.Write(pezziFrutta[i]);
                if (i < pezziDaAcquistare - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
        }
    }
}
