using System.Text;

namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  per  convertir  "Dolars"  a  "Euros".  El  programa  ens  ha  de  demanar 
            quant  Euros  són  un  dólar,  i  la  quantitat  de  dolars  que  volem  convertir.  Feu  que  es 
            mostri el símbol $ i el símbol € correctament.  
            */
            Console.OutputEncoding = Encoding.UTF8;

            double conversio, dolars, resultat;

            Console.WriteLine("Quants euros son un dolar?");
            conversio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quants dolars hi ha?");
            dolars = Convert.ToDouble(Console.ReadLine());

            resultat = conversio * dolars;

            Console.WriteLine($"{dolars}$ son {resultat}€");

            
        }
    }
}
