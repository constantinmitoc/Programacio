namespace Ex_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: mostra quants números hi ha, la seva suma, i quants són positius,
             * negatius i zeros.
             */
            const string RUTA = @"numeros_n.txt";
            string? linia = "";
            StreamReader fitxer = new StreamReader(RUTA);
            int numeroQuntitat, numeroSuma, numeroPositiu,
                numeroNegatiu, numeroZero, numero;

            linia = fitxer.ReadLine();
            numeroQuntitat = Convert.ToInt32(linia);
            linia = fitxer.ReadLine();


            for (numeroSuma = 0, numeroPositiu = 0, numeroNegatiu = 0,
                numeroZero = 0, numero = 0; linia != null; linia = fitxer.ReadLine())
            {
                numero = Convert.ToInt32(linia);

                numeroSuma += numero;

                if (numero < 0)
                {
                    numeroNegatiu++;
                }
                else if (numero > 0)
                {
                    numeroPositiu++;
                }
                else
                {
                    numeroZero++;
                }
            }
            Console.WriteLine($"Números: {numeroQuntitat}");
            Console.WriteLine($"Suma: {numeroSuma}");
            Console.WriteLine($"Positus: {numeroPositiu}");
            Console.WriteLine($"Negatius: {numeroNegatiu}");
            Console.WriteLine($"Zero: {numeroZero}");
            fitxer.Close();
        }
    }
}
