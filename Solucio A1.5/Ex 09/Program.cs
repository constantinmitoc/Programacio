namespace Ex_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: mostra quants bitllets hi ha, quants tenen premi, el 
             * percentatge de bitllets premiats (arrodonit a dos decimals) i el total 
             * d'euros repartits.
             */
            const string RUTA = @"bitllets.txt";
            string? linia = "";
            StreamReader fitxer = new StreamReader(RUTA);
            double per100 = 0;
            int nBitllets = 0, bitlletPremi = 0,
                euro = 0, euroRepartit = 0;

            linia = fitxer.ReadLine();

            while (linia != null)
            {
                if (linia == "BONUS")
                {
                    linia = fitxer.ReadLine();
                    euro = Convert.ToInt32(linia);
                    euroRepartit += euro;
                    bitlletPremi++;
                }
                linia = fitxer.ReadLine();
                nBitllets++;
            }
            Console.WriteLine($"Bitllets: {nBitllets}");
            Console.WriteLine($"Bitllets amb BONUS: {bitlletPremi}");
            per100 = (Convert.ToDouble(bitlletPremi) / nBitllets) * 100;
            Console.WriteLine($"Percentatge de bitllets premiats: {per100}%");
            Console.WriteLine($"Total de guanys: {euroRepartit}");

            fitxer.Close();
        }
    }
}
