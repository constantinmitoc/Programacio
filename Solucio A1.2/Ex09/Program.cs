using Microsoft.VisualBasic;

namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  per  convertir  una  quantitat  de  polzades  a  metres.  Cal  tenir  en 
            compte que una polzada són  2,54 cm. 
            */
            const double CONVERSIO = 2.54 / 100;
            double polzades, resultat;

            Console.WriteLine("Quantes polzades tens?");
            polzades = Convert.ToDouble(Console.ReadLine());

            resultat = polzades * CONVERSIO;
            
            Console.WriteLine($"{polzades} polzades son {resultat} metres");


        }
    }
}
