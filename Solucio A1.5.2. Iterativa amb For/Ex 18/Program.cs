namespace Ex_18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: demana un número enter positiu n i mostra, per a cada número
             * d'1 a n, la suma de tots els anteriors amb l'operació escrita.
             */
            int numero = 0;
            string numerosString = "";

            Console.Write("Escriu un número enter positiu: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int limit = 1, numTemp = 0; limit <= numero; limit++)
            {
                numTemp += limit;
                if (limit == 1)
                {
                    numerosString += $"{Convert.ToString(limit)}";
                }
                else
                {
                    numerosString += $"+{Convert.ToString(limit)}";
                }
                Console.WriteLine($"{numerosString}={numTemp}");
            }
        }
    }
}
