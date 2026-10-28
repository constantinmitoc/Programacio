namespace Ex_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: per a cada bitllet amb BONUS si té premi i BONUS, genera un
             * import a l'atzar entre 1 i 10 euros (llavor 2026). Al final, mostra quants bitllets
             * hi ha, quants tenen premi, el percentatge de bitllets premiats (arrodonit a dos
             * decimals) i el total d'euros repartits.
             */
            Random random = new Random(2026);
            const string RUTA = @"bitllets_sense_import.txt";
            string? linia = "";
            const string BONUS = "BONUS"/*, NOBONUS = "NO BONUS"*/;
            int premi = 0, premiTotal = 0, totalBitllets = 0, bitlletsBonus = 0;
            double per100 = 0;

            StreamReader fitxer = new StreamReader(RUTA);
            linia = fitxer.ReadLine();

            while (linia != null)
            {
                if (linia == BONUS)
                {
                    premi = random.Next(1, 11);
                    premiTotal += premi;
                    bitlletsBonus++;
                }
                totalBitllets++;
                linia = fitxer.ReadLine();
            }
            Console.WriteLine($"Bitllets: {totalBitllets}");
            Console.WriteLine($"Bitllets amb BONUS: {bitlletsBonus}");
            per100 = (Convert.ToDouble(bitlletsBonus) / totalBitllets) * 100.00;
            Console.WriteLine($"Percentatge de bitllets premiats: {per100:F2}%");
            Console.WriteLine($"Total de guanys: {premiTotal} euros");
            fitxer.Close();
        }
    }
}
