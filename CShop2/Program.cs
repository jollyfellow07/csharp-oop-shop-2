
using CShop2;

Prodotto mela = new Prodotto("MELA", "questa mela è rossa", 0.20, 5);
int codice = mela.GetCodice();
Console.WriteLine(mela.ToString());

/**********************************************************************************************************************/

Acqua sorgesana = new Acqua("Sorgesana", "Acqua naturale povera di sodio", 15, 5, 6.8, "Monte Terminio");

try 
{ 
sorgesana.BeviAcqua();
}catch(ArgumentOutOfRangeException e)
{
    Console.WriteLine("il parametro, " + e.ParamName + " ha detto: " + e.Message);
}catch(Exception e)
{
    Console.WriteLine(e.Message);
}
sorgesana.SvuotaAcqua();

try
{
    sorgesana.AggiungiAcqua();
}catch (ArgumentOutOfRangeException e)
{
    Console.WriteLine("il parametro " + e.ParamName + " ha detto: " + e.Message);
}

try
{
Acqua.ConvertiInGalloni();
}catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine("il parametro " + ex.ParamName + " ha detto: " + ex.Message);
    Console.ReadKey();
}
Console.WriteLine(sorgesana.ToString());

/**********************************************************************************************************************/

Frutta arancie = new Frutta();
try
{
    arancie.ComposizioneSacchetto();
}catch(ArgumentNullException e)
{
    Console.WriteLine(e.ParamName + e.Message);
}catch (OverflowException e)
{
    Console.WriteLine(e.Message);
}catch (FormatException e)
{
    Console.WriteLine(e.Message);
}

/**********************************************************************************************************************/

Elettrodomestico lavatrice = new Elettrodomestico("LAVATRICE", " bianca", 100, 22, "A", 34.6, 50, 20);
Console.WriteLine(lavatrice.ToString());

/**********************************************************************************************************************/

CiboInScatola fagioli = new CiboInScatola("Bellotti", "Legumi pieni di sostanze nutrienti", 3, 22, "fagioli");
try {
fagioli.AggiungiCibo();
}catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine("il parametro " + ex.ParamName + " ha detto: " + ex.Message);
}

Console.WriteLine(fagioli.ToString());

