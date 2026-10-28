namespace Ex_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int any = 0;

            Console.Write("Escriu un any: ");
            any = Convert.ToInt32(Console.ReadLine());

            if (EsAnyTraspas(any))
            {
                Console.Write($"L'any {any} és de traspàs.");
            }
            else
            {
                Console.Write($"L'any {any} no és de traspàs.");
            }
        }
        /// <summary>
        /// Retorna "true" si l'any es de traspas.
        /// </summary>
        /// <param name="any">L'any introduit</param>
        /// <returns></returns>
        static bool EsAnyTraspas(int any)
        {
            return (any % 4 == 0 && any % 100 != 0) || (any % 400 == 0); 
        }
    }
}
