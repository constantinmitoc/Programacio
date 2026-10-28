namespace Ex_14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa:
                1. Genera dos números a l'atzar entre 1 i 100 (llavor 2026) i els mostra.
                2. Demana el resultat de la suma, la resta, el producte i la divisió entera dels 
                    dos números.
                3. Si s'han encertat les quatre operacions, s'acaba. Si se n'ha fallat alguna,
                    ho diu i torna al pas 1 amb dos números nous.
                4. En acabar, diu quantes rondes han calgut.
             */
            Random random = new Random(2026);
            int numero1 = 0, numero2 = 0, rondes = 0;
            const string suma = "Suma", resta = "Resta", 
                producte = "Producte", divisio = "Divisio";
            bool repeticio = false;

            do
            {
                numero1 = random.Next(1, 101);
                numero2 = random.Next(1, 101);
                Console.WriteLine($"Números: {numero1} i {numero2}");

                repeticio = Pregunta(suma, (numero1 + numero2)) && Pregunta(resta, (numero1 - numero2)) &&
                    Pregunta(producte, (numero1 * numero2)) && Pregunta(divisio, (numero1 / numero2));

                rondes++;

                if (repeticio == false)
                {
                    Console.WriteLine("Has fallat alguna operació. Tornem-hi!");
                }
                else
                {
                    Console.WriteLine($"Molt bé! Has necessitat {rondes} rondes.");
                }
            }
            while (repeticio == false);

        }
        /// <summary>
        /// Mostra el nom de l'operació, llegeix la resposta de l'usuari i retorna true si es
        /// correcte.
        /// </summary>
        /// <param name="nomOperacio">Suma, resta, producte o divisio</param>
        /// <param name="resultatCorrecte">Resultat de l'operacio</param>
        /// <returns></returns>
        static bool Pregunta(string nomOperacio, int resultatCorrecte)
        {
            int resposta = 0;
            Console.Write($"{nomOperacio}: ");
            resposta = Convert.ToInt32(Console.ReadLine());
            return resposta == resultatCorrecte;
        }

    }
}
