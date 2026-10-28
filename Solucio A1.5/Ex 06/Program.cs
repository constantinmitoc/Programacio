namespace Ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: demana un número enter positiu i diu quantes xifres té.
             */
            int numero = 0;

            Console.WriteLine("Escriu un número enter positiu: ");
            numero = Convert.ToInt32(Console.ReadLine());
            
            if (numero < 0)
            {
                Console.WriteLine($"El numero ha de ser positiu");
            }
            else
            {
                Console.WriteLine($"Quantitat de xifres: {QuantesXifres(numero)}");
            }

        }
        /// <summary>
        /// Calcula la quantitat de xifres d'un numero
        /// </summary>
        /// <param name="numero">El numero introduit</param>
        /// <returns></returns>
        static int QuantesXifres(int numero)
        {
            int resultat = 0,
                xifres = 0;
            if (numero == 0)
            {
                resultat = 1;
            }
            else
            {
                while (numero > 0)
                {
                    numero = numero / 10;
                    xifres++;
                    resultat = xifres;
                }
            }
            return resultat;
        }
    }
}
