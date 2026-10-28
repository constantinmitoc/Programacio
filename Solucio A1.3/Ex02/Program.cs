namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escriu  un  programa  que  et  demani  per  teclat  els  valors  de  dos  punts  i  ens  mostri  el 
               valor  de  la  distància  entre  els  dos  punts.  El  càlcul  cal  fer-lo  dissenyant  una  funció 
               que  rebi  4  paràmetres  corresponents  a  les  coordenades  x  i  y  de  cada  punt i 
               ens retorni el valor de la distància entre el dos punts. 
             */

            double x1, x2, y1, y2, distancia;

            Console.WriteLine("Quina es la teva X1?");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quina es la teva X2?");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quina es la teva Y1?");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Quina es la teva Y2?");
            y2 = Convert.ToDouble(Console.ReadLine());

            distancia = DistanciaDosPunts(x1, x2, y1, y2);

            Console.WriteLine($"La distancia entre els teus dos punts es {distancia}");
        }
        /// <summary>
        /// Et calcula la distancia entre dos punts
        /// </summary>
        /// <param name="x1">El valor X1</param>
        /// <param name="x2">El valor X2</param>
        /// <param name="y1">El valor Y1</param>
        /// <param name="y2">El valor Y2</param>
        /// <returns></returns>
        static double DistanciaDosPunts(double x1, double x2, double y1, double y2)
        {
            double resultat;

            resultat = Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1), 2));

            return resultat;
        }
    }
}
