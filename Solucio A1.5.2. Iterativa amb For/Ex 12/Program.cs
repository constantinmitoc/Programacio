namespace Ex_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: calcula els punts del Girona (3 per victòria, 1 per empat),
             * els gols a favor, els gols en contra i la diferència de gols.
             */
            const string RUTA = @"girona_23_24_n.txt";
            string? linia = "";
            StreamReader fitxer = new StreamReader(RUTA);
            int jornades, punts, golsG, golsV,
                golsFavor, golsContra, golsDiferencia;
            bool favorOcontra = true;

            linia = fitxer.ReadLine();
            jornades = Convert.ToInt32(linia);
            linia = fitxer.ReadLine();

            for (punts = 0, golsG = 0, golsV = 0,
                 golsDiferencia = 0, golsFavor = 0, golsContra = 0;
                 linia != null; linia = fitxer.ReadLine())
            {
                golsV = Convert.ToInt32(linia);
                linia = fitxer.ReadLine();
                golsG = Convert.ToInt32(linia);

                if (golsG > golsV)
                {
                    punts += 3;
                }
                else if (golsG == golsV)
                {
                    punts++;
                }
                golsFavor += golsG;
                golsContra += golsV;
            }
            golsDiferencia = golsFavor - golsContra;
            if (golsDiferencia < 0)
            {
                golsDiferencia *= -1;
                favorOcontra = false;
            }
            Console.WriteLine($"Jornades: {jornades}");
            Console.WriteLine($"Punts: {punts}");
            Console.WriteLine($"Gols a favor: {golsFavor}");
            Console.WriteLine($"Gols en contra: {golsContra}");
            if (favorOcontra)
            {
                Console.WriteLine($"Diferència de gols: {golsDiferencia} gols a favor del Girona");
            }
            else if (favorOcontra == false)
            {
                Console.WriteLine($"Diferència de gols: {golsDiferencia} gols en contra del Girona");
            }
            fitxer.Close();
        }
    }
}
