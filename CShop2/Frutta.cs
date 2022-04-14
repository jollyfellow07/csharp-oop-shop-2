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
            Console.WriteLine("\nQuanti frutti vuoi comprare? [il sacchetto può contenere massimo 5 frutti]");
            int pezziDaAcquistare = -1;

            do
            {
                Console.WriteLine("Inserisci un numero da 0 a 5");
                try
                {
                    pezziDaAcquistare = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Non hai inserito un input corretto!");
                }
            } while (pezziDaAcquistare > 5 || pezziDaAcquistare < 0);

            for (int i = 0; i < pezziDaAcquistare; i++)
            {
                Console.WriteLine("inserisci la frutta numero " + (i + 1) + " di " + pezziDaAcquistare +  " da acquistare e inserire nel sacchetto");
                pezziFrutta[i]=Console.ReadLine();

            }
            
            Console.WriteLine("Il tuo sacchetto contiene questi frutti: ");
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
