namespace Solucio_1._5._2._Iterativa_amb_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: mostra els números de l'1 al 20, en una sola línia, separats
             * per una coma i un espai.
             */
            int repeticions;

            for (repeticions = 0; repeticions < 20; repeticions++)
            {
                Console.Write($"{repeticions}, ");
            }
            Console.Write($"{repeticions}");
        }
    }
}
