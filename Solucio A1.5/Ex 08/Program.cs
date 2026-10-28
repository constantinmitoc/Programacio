namespace Ex_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: diu quantes persones han respost, quants vots té la
             * xocolata i quants la vainilla, i quin dels dos sabors guanya (o si empaten).
             */
            const string RUTA = @"gelats.txt";
            string? linia = "";
            int xoco = 0, vainilla = 0, inputPersones = 0;

            StreamReader fitxer = new StreamReader(RUTA);
            linia = fitxer.ReadLine();

            while (linia != null)
            {
                if (linia == "XOCOLATA")
                {
                    xoco++;
                }
                else if (linia == "VAINILLA")
                {
                    vainilla++;
                }
                inputPersones++;
                linia = fitxer.ReadLine();
            }
            Console.WriteLine($"Respostes: {inputPersones}");
            Console.WriteLine($"Xocolata: {xoco}");
            Console.WriteLine($"Vainilla: {vainilla}");
            if (xoco > vainilla)
            {
                Console.WriteLine("Guanya la xocolata.");
            }
            else if (xoco < vainilla)
            {
                Console.WriteLine("Guanya la vainilla.");
            }
            else
            {
                Console.WriteLine("Els vots empaten");
            }
            fitxer.Close();
        }
    }
}
