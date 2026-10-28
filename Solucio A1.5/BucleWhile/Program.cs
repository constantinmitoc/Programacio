namespace BucleWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int potencia = 1;

            while (potencia < 1000) 
            {
                Console.WriteLine($"Potencia: {potencia}");
                potencia *= 2;
            }
        }
    }
}
