namespace Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double coefA, coefB, coefC;
            bool segonGrau;

            
            segonGrau = coefA >= 0 && (Math.Pow(coefB, 2.0) - 4 * coefA * coefC) == 0;

            double puntX, puntY, radi;
            bool dintre;

            dintre = DistanciaPuntOrigen(puntX, puntY) <= radi;
        }
        /// <summary>
        /// Calcula la distancia des del punt d'origen
        /// </summary>
        /// <param name="x">Valor X</param>
        /// <param name="y">Valor Y</param>
        /// <returns></returns>
        static double DistanciaPuntOrigen(double x, double y)
        {
            double distancia;

            distancia = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

            return distancia;
        }
    }
}
