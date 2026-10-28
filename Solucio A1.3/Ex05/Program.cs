namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escriu  un  programa  per  convertir  una  quantitat  de  polzades  a  metres.  Cal  tenir  en 
               compte  que  una  polzada  són  2,54  cm.  Per  assolir  el  vostre  objectiu,  cal 
               dissenyar  una  funció  que  rebi  un  paràmetre  corresponent  a  una  quantitat  de 
               polzades.  La  funció  ha  de  retornar  els  metres  equivalents  a  les  polzades 
               donades arrodonit amb dues xifres decimals.
             */

            double polzades, metres;

            Console.WriteLine("Quantes polzades tens?");
            polzades = Convert.ToDouble(Console.ReadLine());

            metres = PolzadesAMetres(polzades);

            Console.WriteLine($"{polzades} son {metres:F2} metres");

        }
        /// <summary>
        /// Transforma polzades a metres
        /// </summary>
        /// <param name="polzades">Les polzades</param>
        /// <returns></returns>
        static double PolzadesAMetres(double polzades)
        {
            const double POLZADESMETRE = 2.54 / 100;
            double resultat;
            resultat = POLZADESMETRE * polzades;

            return resultat;

            
        }
    }
}
