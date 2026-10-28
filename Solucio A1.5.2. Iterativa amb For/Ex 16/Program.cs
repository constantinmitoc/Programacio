namespace Ex_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: mostra les taules de multiplicar del 0 al 5, de l'1 al 10,
             * cada una amb un títol i una línia en blanc al final.
             */
            for (int limit = 0; limit <= 5; limit++)
            {
                MostrarTaula(limit);
            }
        }
        /// <summary>
        /// Escriu tota la taula de multiplicar del 0 al 10 del numero introduit
        /// </summary>
        /// <param name="numero">El numero a multiplicar</param>
        static void MostrarTaula(int numero)
        {
            Console.WriteLine($"Taula del {numero}");
            for (int limit = 1; limit <= 10; limit++)
            {
                Console.WriteLine($"{numero} x {limit} = {numero * limit}");
            }
            Console.WriteLine("");
        }
    }
}
