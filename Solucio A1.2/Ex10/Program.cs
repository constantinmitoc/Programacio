namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            L'altitud  dels  avions  es  mesura  en  peus.  1  metre  són  39,27  polzades  i  1  peu  són  12 
            polzades.  1  polzada  són  2,54  cm.  Escriu  un  programa  que  ens  demani  una  quantitat 
            de peus i ens informi del seu equivalent en metres.
            */
            double peus, metres;
            const double METRE = 2.54 / 100;
            const double POLZADES = 12;

            Console.WriteLine("Quants peus tens?");
            peus = Convert.ToDouble(Console.ReadLine());

            metres = peus * POLZADES * METRE;
            
            Console.WriteLine($"{peus} peus  son {metres} metres");

        }
    }
}
