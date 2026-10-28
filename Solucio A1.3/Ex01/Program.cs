namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Escriu  un  programa  demani  a  l’usuari  una  quantitat  d'hores,  minuts  i  segons  i  ens 
                informi  per  la  consola  del  total  de  temps  entrat,  convertit  tot  en  segons.
                El  càlcul  cal fer-lo  dissenyant  una  funció  que  rebi  3  paràmetres  enters  corresponents  
                a les  hores,  minuts  i  segons  i  ens  retorni  un  valor  enter  corresponent  a  la 
                conversió a segons  .
             */

            int hores, minuts, segons, tempsTotal;

            Console.WriteLine("Quantes hores han pasat?");
            hores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quants minuts han pasat?");
            minuts = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quants segons han pasat?");
            segons = Convert.ToInt32(Console.ReadLine());

            tempsTotal = CalculDeTempsEnSegons(hores, minuts, segons);

            Console.WriteLine($"Han pasat {tempsTotal} segons");

        }
        /// <summary>
        /// Aquesta funcio calcula els segons totals donantli les hores el minuts i els segons
        /// </summary>
        /// <param name="hores">Aqui van les hores</param>
        /// <param name="minuts">Aqui van els minuts</param>
        /// <param name="segons">Aqui van els segons</param>
        /// <returns></returns>
        static int CalculDeTempsEnSegons(int hores, int minuts, int segons)
        {
            int temps;
            temps = (hores * 3600) + (minuts * 60) + segons;

            return temps;
        }
    }
}
