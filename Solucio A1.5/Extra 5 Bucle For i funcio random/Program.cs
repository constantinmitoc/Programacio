namespace Extra_5_Bucle_For_i_funcio_random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Random generador = new Random();

            for (int quantitat = 0; quantitat < 100; quantitat++)
            {
                numero = generador.Next(1, 101);
                Console.WriteLine($"Ha sortit el numero {numero}");
            }
        }
    }
}
