namespace Condicionals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;
      
            Console.WriteLine("Escriu un numero:   ");
            numero = Convert.ToDouble(Console.ReadLine());


            if (numero < 0)
            {
                numero = numero * -1;
            }
            Console.WriteLine($"El teu numero en positiu es {numero}");

        }
    }
}
