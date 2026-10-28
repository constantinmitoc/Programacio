namespace Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: demana dos números i mostra tots els que hi ha entre ells,
             * tots dos inclosos, amb el format de l'exercici 1. Si el primer és més gran que el
             * segon, ho avisa.
             */
            int numero1 = 0, numero2 = 0, numeroTemp = 0;

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
                for (numeroTemp = numero1; numeroTemp != numero2; numeroTemp++)
                {
                    Console.Write($"{numeroTemp}, ");
                }
                Console.Write($"{numeroTemp}");
            }
        }
    }
}
