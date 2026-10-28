namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: el mateix que l'exercici 3, però sense mostrar els múltiples de
             * 7. Ara els números es mostren separats només per un espai.
             */
            int numero1 = 0, numero2 = 0, numTemp = 0;

            Console.Write("Primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segon número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero2 < numero1)
            {
                Console.WriteLine("El primer número no pot ser més gran que el segon.");
            }
            else
            {
                for (numTemp = numero1; numTemp != numero2; numTemp++)
                {
                    if (numTemp % 7 != 0)
                    {
                        Console.Write($"{numTemp}, ");
                    }
                }
                Console.Write($"{numTemp}");
            }
        }
    }
}
