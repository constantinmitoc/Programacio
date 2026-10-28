namespace Ex_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: mostra tots els múltiples de 4 del 0 al 300, un per línia.
             * Cada vegada que n'hagi mostrat 20, mostra Prem una tecla per continuar... i espera 
             * que l'usuari premi una tecla. Al final, diu quants números ha mostrat.
             */
            const int NUMERO4 = 4;

            for (int repeticions = 0; repeticions <= 75; repeticions++)
            {
                if (repeticions % 20 == 0 && repeticions != 0)
                {
                    Console.WriteLine("Prem una tecla per continuar...");
                    Console.ReadKey(true);
                }
                Console.WriteLine($"{NUMERO4 * repeticions}");
            }


        }
    }
}
