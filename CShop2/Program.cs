// See https://aka.ms/new-console-template for more information
using CShop2;

Prodotto mela = new Prodotto("MELA", "questa mela è rossa", 0.20, 5);
int codice = mela.GetCodice();
Console.WriteLine(mela.ToString());


Acqua sorgesana = new Acqua("acqua", "sorgesana", 0.22, 5, 7, "Monte Terminio");
sorgesana.NomeEsteso();
sorgesana.BeviAcqua();
Acqua.ConvertiInGalloni();
Console.WriteLine(sorgesana.ToString());

Frutta arancie = new Frutta();
arancie.ComposizioneSacchetto();


Elettrodomestico lavatrice = new Elettrodomestico("LAVATRICE", " bianca", 100, 22, "A", 34.6, 50, 20);
Console.WriteLine(lavatrice.ToString());

CiboInScatola fagioli = new CiboInScatola("Bellotti", "Legumi pieni di sostanze nutrienti", 3, 22, "fagioli");
fagioli.AggiungiCibo();
Console.WriteLine(fagioli.ToString());

