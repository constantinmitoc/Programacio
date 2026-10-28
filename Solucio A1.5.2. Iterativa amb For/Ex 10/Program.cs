namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: mostra quants bitllets hi ha, quants tenen premi, el percentatge
             * de bitllets premiats (arrodonit a dos decimals) i el total d'euros repartits.
             */
            const string RUTA = @"bitllets_n.txt";
            string? linia = "";
            StreamReader fitxer = new StreamReader(RUTA);
            int bitlletQuantitat, bitlletPremi, euroRepartir;
            double per100premiat;

            linia = fitxer.ReadLine();
            bitlletQuantitat = Convert.ToInt32(linia);
            linia = fitxer.ReadLine();

            for (bitlletPremi = 0, per100premiat = 0, euroRepartir = 0;
                linia != null; linia = fitxer.ReadLine())
            {
                if (linia == "BONUS")
                {
                    bitlletPremi++;
                    linia = fitxer.ReadLine();
                    euroRepartir += Convert.ToInt32(linia);
                }
            }
            per100premiat = ((double)bitlletPremi / (double)bitlletQuantitat) * 100.00;
            Console.WriteLine($"Bitllets: {bitlletQuantitat}");
            Console.WriteLine($"Bitllets amb BONUS: {bitlletPremi}");
            Console.WriteLine($"Percentatge de bitllets premiats: {per100premiat}%");
            Console.WriteLine($"Total de guanys: {euroRepartir} euros");
            fitxer.Close();
        }
    }
}
