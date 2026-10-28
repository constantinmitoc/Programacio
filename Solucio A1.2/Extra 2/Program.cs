namespace Extra_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Aquesta linea s'utilitza per donar un numero aleatori
            Random random = new Random();

            int NumeroAleatori;

            //Els valors representats agafa como a opcio el primer numero pero no l'ultim (Entre 1 i 6)
            NumeroAleatori = random.Next(1, 7);

        }
    }
}
