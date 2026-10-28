namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Escriu  un  programa  per  mostrar  el  volum  d’una  esfera  de  radi  r  i
                l’àrea  i  el perímetre  del  seu  cercle  inscrit.  Per  fer.ho,  dissenyeu 
                tres  funcions,  cadascuna rep  el  radi  i  cadascuna  retorna  el  resultat
                de  cada  càlcul.  S’ha  de  retornar  un valor arrodonit amb dues xifres decimals.
             */

            double radi, volum, perimetre, area;

            Console.WriteLine("Dona'm el radi de la teva esfera i et calculare el volum de l'esfera i" +
                "el area i perimetre del teu cercle inscrit");
            radi = Convert.ToDouble(Console.ReadLine());

            volum = VolumEsfera(radi);
            area = AreaCercle(radi);
            perimetre = PerimetreCercle(radi);

            Console.WriteLine($"El volum de la teva esfera es {volum:F2}, l'area del cercle inscrit es" +
                $" {area:F2} i el perimetre es {perimetre:F2}");

        }
        /// <summary>
        /// Calcula el volum de l'esfera
        /// </summary>
        /// <param name="radi">El radi de l'esfera</param>
        /// <returns></returns>
        static double VolumEsfera(double radi)
        {
            double area;

            area = (4.0/3.0) * Math.PI * Math.Pow(radi, 3);

            return area;
        }
        /// <summary>
        /// Calcula l'area del cercle inscrit
        /// </summary>
        /// <param name="radi">El radi de l'esfera</param>
        /// <returns></returns>
        static double AreaCercle(double radi)
        {
            double area;

            area = (Math.PI) * (Math.Pow(radi, 2));

            return area;
        }
        /// <summary>
        /// Calcula el perimetre del cercle inscrit
        /// </summary>
        /// <param name="radi">El radi de l'esfera</param>
        /// <returns></returns>
        static double PerimetreCercle(double radi)
        {
            double perimetre;

            perimetre = 2 * Math.PI * radi;

            return perimetre;
        }
    }
}
