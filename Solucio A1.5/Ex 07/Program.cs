namespace Ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: demana un número enter positiu i el mostra amb les xifres
             * en ordre invers.
             */
            int numero = 0;

            Console.Write($"Escriu un número enter positiu: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Invertit: {Invertir(numero)}");
            
        }
        static int Invertir(int numero)
        {
            int resultat = 0, numeroNou = 0;

            while (numero != 0)
            {
                numeroNou = (numeroNou * 10) + (numero % 10);
                numero /= 10;
            }
            resultat = numeroNou;
            return resultat;
        }
    }
}
