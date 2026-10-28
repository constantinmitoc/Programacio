using System.Text;

namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Escriu  un  programa  per  calcular  la  nòmina  d'un  treballador:  L’usuari  ens  ha 
                d’entrar  el  nombre  total  d'hores  treballades,  el  sou  brut  per  cada  hora  
                treballada  i  el percentatge d'impost aplicat al sou brut total, el programa ha d'informar de: 
                    a. Sou brut total 
                    b. Retenció d’impostos
                    c. Sou net (sou brut menys els impostos) 
             */
            Console.OutputEncoding = Encoding.UTF8;

            double souXhora, souBrut, retencio, souNet;
            int horesTreball, xcentRetencio;

            Console.WriteLine("Quant es el teu sou per hora?");
            souXhora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Quantes hores has acumulat?");
            horesTreball = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quin percentatge d'impostos et retenen?");
            xcentRetencio = Convert.ToInt32(Console.ReadLine());

            souBrut = SouBrutTotal(souXhora, horesTreball);
            retencio = Retencio(xcentRetencio, souBrut);
            souNet = SouNetTotal(retencio, souBrut);

            Console.WriteLine($"El teu sou brut es de {souBrut}€, i aplicant un {xcentRetencio}% de" +
                $" retencio et queda un sou net de {souNet}€");

        }
        /// <summary>
        /// Dona el sou brut total a partir de les hores i el sou per hora
        /// </summary>
        /// <param name="souPerHora">Sou per hora</param>
        /// <param name="horesTreballades">Hores treballades</param>
        /// <returns></returns>
        static double SouBrutTotal(double souPerHora, int horesTreballades)
        {
            double souBrut;

            souBrut = souPerHora * horesTreballades;

            return souBrut;
        }
        /// <summary>
        /// Calcula la retencio d'un sou brut
        /// </summary>
        /// <param name="percent">Percent de retencio</param>
        /// <param name="souBrut">El sou brut total</param>
        /// <returns></returns>
        static double Retencio(double percent, double souBrut)
        {

            double retencio;

            retencio = (percent / 100) * souBrut;

            return retencio;
        }
        /// <summary>
        /// Calcula el sou net a partir de la retencio ja aplicada i el sou brut
        /// </summary>
        /// <param name="retencioAplicada">La retencio aplicada</param>
        /// <param name="souBrut">El sou brut total</param>
        /// <returns></returns>
        static double SouNetTotal(double retencioAplicada, double souBrut)
        {

            double souNet;

            souNet = souBrut - retencioAplicada;

            return souNet;
        }
                    
    }
}
