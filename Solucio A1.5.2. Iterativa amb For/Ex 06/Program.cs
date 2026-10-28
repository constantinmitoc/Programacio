namespace Ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: demana un número de 0 a 20 i en mostra el factorial. Si el
             * número no és de 0 a 20, ho avisa.
             */
            int numero;

            Console.Write("Escriu un número de 0 a 20: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero > 20)
            {
                Console.WriteLine("El número ha de ser de 0 a 20.");
            }
            else
            {
                Console.WriteLine($"{numero}! = {Factorial(numero)}");
            }
        }
        /// <summary>
        /// Rep un numero del 0 al 20 i retorna el factorial
        /// </summary>
        /// <param name="numero">El numero introduit</param>
        /// <returns></returns>
        static long Factorial(int numero)
        {
            long resultat;
            int repeticions;

            for (repeticions = 1, resultat = 1; repeticions <= numero; repeticions++)
            {
                resultat *= repeticions;
            }

            return resultat;
        }

    }
}
