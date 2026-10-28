namespace Ex03
{
    /// <summary>
    /// Volum d'una esfera
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.141592
            double radi, volum;


            Console.WriteLine("Quin es el radi de l'esfera? ");
            radi = Convert.ToDouble(Console.ReadLine());

            volum = 4.0 / 3 * PI * radi;
            Console.WriteLine($"El volum d'una esfera de radi {radi} es {volum}");

        }
    }
}
