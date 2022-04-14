
using CShop2;


/*
 * IVE ACCETTATE:
 * 5% PER LA FRUTTA E L'ACQUA
 * 22% PER I PRODOTTI GENERICI E GLI ELETTRODOMESICI
 * 10% PER il CIBO IN SCATOLA
 * 
/********************************************** PRODOTTO GENERICO ************************************************************************/


Prodotto tavolo = new Prodotto("Tavolo", "questa mela è rossa", 28, 22);
int codice = tavolo.GetCodice();
Console.WriteLine(tavolo.ToString());





/********************************************** ACQUA ************************************************************************/

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

/********************************************* FRUTTIVENDOLO *************************************************************************/

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

/********************************************  ELETTRODOMESICO  **************************************************************************/



Elettrodomestico lavatrice = new Elettrodomestico("LAVATRICE", " bianca", 100, 22, "A", 34.6, 50, 20);
lavatrice.PremiPulsanteOnOff();
Console.WriteLine(lavatrice.ToString());
lavatrice.PremiPulsanteOnOff();



/***********************************************  CIBO IN SCATOLA  ***********************************************************************/


CiboInScatola fagioli = new CiboInScatola("Bellotti", "Legumi pieni di sostanze nutrienti", 3, 22, "fagioli");

Console.WriteLine(fagioli.ToString());

try 
{
   fagioli.AggiungiCibo();
}
catch(ArgumentOutOfRangeException ex)
{
    Console.WriteLine("il parametro " + ex.ParamName + " ha detto: " + ex.Message);
}
fagioli.GetGrammiAttuali();

