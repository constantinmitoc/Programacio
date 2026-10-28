namespace Ex_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: mostra una línia per a cada producte amb el seu import, i al
             * final el total del tiquet. Els imports s'arrodoneixen a dos decimals.
             */
            const string RUTA = @"tiquet_super.txt";
            string? linia = "";
            StreamReader fitxer = new StreamReader(RUTA);
            int quantitatProductes, quantitatElement;
            double preu, total, totalLlista;
            string? nom;

            linia = fitxer.ReadLine();
            quantitatProductes = Convert.ToInt32(linia);
            linia = fitxer.ReadLine();

            for (quantitatElement = 0, preu = 0, total = 0, totalLlista = 0; 
                 linia != null; linia = fitxer.ReadLine(), total = 0)
            {
                nom = linia;
                quantitatElement = Convert.ToInt32(fitxer.ReadLine());
                preu = Convert.ToDouble(fitxer.ReadLine());
                total += quantitatElement * preu;
                Console.WriteLine($"{quantitatElement} x {nom} a {Math.Round(preu, 2)} euros = {Math.Round(total, 2)} euros");
                totalLlista += total;
            }
            Console.WriteLine($"TOTAL: {totalLlista:F2} euros");
            fitxer.Close();
        }
    }
}
