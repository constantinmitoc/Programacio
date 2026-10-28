namespace Extra_4_Condicionals_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double temperatura = 0;

            Console.Write("Quina temperatura fa?   ");
            temperatura = Convert.ToDouble(Console.ReadLine());

            if (temperatura < 0)
            {
                Console.WriteLine("Glaca");
            }
            else if (temperatura < 15)
            {
                Console.WriteLine("Fa fred");
            }
            else if (temperatura < 25)
            {
                Console.WriteLine("S'esta be");
            }
            else
            {
                Console.WriteLine("Fa calor");
            }
        }
    }
}
