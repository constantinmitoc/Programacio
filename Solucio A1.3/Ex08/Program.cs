namespace Ex08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Escriu  un  programa  per  mostrar  l'hora  en  format  hh:mm:ss  a  partir  d'una
                quantitat de  segons  donada  com  a  entrada.  Per  exemple,  si  l'entrada  és 
                4000,  la  sortida  ha  de ser  01:04:40.  Per  fer.ho,  dissenyeu  una  funció  que
                rebi  un  enter corresponent a la quantitat de segons i retorni l’string en el format
                demanat. 
             */
            int segonsTotals;
            string temps;

            Console.WriteLine("Escriu la quantita de segons que tens i la transformare en un format de h:m:s digital");
            segonsTotals = Convert.ToInt32(Console.ReadLine());

            temps = CalculDeTemps(segonsTotals);

            Console.WriteLine($"{temps}");
        }
        /// <summary>
        /// Calcula i retorna el temps en format h:m:s d'una quantitat de segons totals
        /// </summary>
        /// <param name="segonsTotals">Els segons totals a caluclar</param>
        /// <returns></returns>
        static string CalculDeTemps(int segonsTotals)
        {
            string temps; 
            int hores, minuts, segons, residu;
            hores = segonsTotals / 3600;
            residu = segonsTotals % 3600;
            minuts = residu / 60;
            segons = residu % 60;
            temps = $"{hores}:{minuts}:{segons}";

            return temps;
        }
    }
}
