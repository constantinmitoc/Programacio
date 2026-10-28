namespace Extra_3_Condicionals_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int divident, divisor, quocient, residu;

            Console.Write("Quin es el divident:   ");
            divident = Convert.ToInt32(Console.ReadLine());
            Console.Write("Quin es el divisor:   ");
            divisor = Convert.ToInt32(Console.ReadLine());
            if (divisor != 0)
            {
                quocient = divident / divisor;
                residu = divident % divisor;

                Console.WriteLine($"QUant divideixes {divident} entre {divisor}, el quocient es " +
                    $"{quocient} i el residu es {residu}");
            }
            else
            {
                Console.WriteLine("No et puc contestar, perque no es pot dividir entre zero");
            }
        }
    }
}
