using System.Text;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escriu  un  programa  per  convertir  "Dolars"  a  "Euros".  El  programa  ens  ha  de 
               demanar  quant  Euros  són  un  dólar,  i  la  quantitat  de  dolars  que  volem  convertir.  Feu 
               que  es  mostri  el  símbol  $  i  el  símbol  €  correctament.  Per  assolir  el  vostre 
               objectiu,  cal  dissenyar  una  funció  que  rebi  dos  paràmetres:  un  valor  real 
               corresponent  a  una  quantitat  en  euros  que  cal  convertir  (qtyEuros)  i  un 
               segon  valor  real  corresponent  a  l’equivalència  euro/dollar  (euro2Dollar).  La 
               funció  ha  de  retornar l’equivalent  de  qtyEuros  dollars  .  (suposarem  que 
               sempre  serà  una  lletra  minúscula)  i  retorni  el  valor  de  la  majúscula 
               corresponent.
             */
            Console.OutputEncoding = Encoding.UTF8;

            double conversio, dolars, resultat;
            
            Console.WriteLine("Quants euros son un dolar?");
            conversio = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quants dolars tens?");
            dolars = Convert.ToDouble(Console.ReadLine());

            resultat = DolarAEuro(dolars, conversio);
            Console.WriteLine($"{dolars}$ son {resultat}€ ");


        }
        /// <summary>
        /// Converteix els dolars a euros
        /// </summary>
        /// <param name="qtyEuros">La cantitat de dolars</param>
        /// <param name="euro2Dollar">El preu del dolar en euro</param>
        /// <returns></returns>
        static double DolarAEuro(double qtyEuros, double euro2Dollar)
        {
            double resultat;
            resultat = euro2Dollar * qtyEuros;

            return resultat;
        }
    }
}
