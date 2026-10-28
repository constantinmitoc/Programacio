namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què ha de fer el programa: demanar un any i dir a quin segle pertany,
             * o que l'any no és vàlid.
             */
            int any = 0;
            string resposta = "";

            Console.Write("Escriu un any: ");
            any = Convert.ToInt32(Console.ReadLine());

            resposta = Segle(any);
            Console.Write(resposta);

        }
        /// <summary>
        /// Calcula el segle al que pertany l'any.
        /// </summary>
        /// <param name="any">L'any introduit</param>
        /// <returns></returns>
        static string Segle(int any)
        {
            string resultat = "";

            if (any > 1700 && any <= 1800)
            {
                resultat = $"L'any {any} és del segle XVIII";
            }
            else if (any > 1800 && any <= 1900)
            {
                resultat = $"L'any {any} és del segle XIX";
            }
            else if (any > 1900 && any <= 2000)
            {
                resultat = $"L'any {any} és del segle XX";
            }
            else if (any > 2000 && any < 2100)
            {
                resultat = $"L'any {any} és del segle XXI";
            }
            else
            {
                resultat = $"L'any {any} no és vàlid.";
            }

            return resultat;
        }
    }
}
