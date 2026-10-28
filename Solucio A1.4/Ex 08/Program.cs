namespace Ex_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Què ha de fer el programa: demanar una hora en format de 24 hores, escrita com un sol
                número enter amb el format hhmmss , i dir si és correcta. Per exemple, 
                153045 (15:30:45) és correcta, però 250000 (25:00:00) no ho és. Una hora és correcta si
                les hores són de 0 a 23, i els minuts i els segons, de 0 a 59.
             */

            int numero = 0, hores = 0, minuts = 0, segons = 0, residu = 0;

            Console.Write("Escriu una hora (hhmmss): ");
            numero = Convert.ToInt32(Console.ReadLine());

            hores = numero / 10000;
            residu = numero % 10000;
            minuts = residu / 100;
            segons = residu % 100;

            if (EsHoraValida(hores,minuts,segons))
            {
                Console.Write("L'hora és correcta.");
                Console.Write($"La teva hora es {hores}:{minuts}:{segons}");
            }
            else
            {
                Console.Write("L'hora no és correcta.");
            }
           
        }
        /// <summary>
        /// Calcula si el temps insertat es en format correcte.
        /// </summary>
        /// <param name="hores">Les hores</param>
        /// <param name="minuts">Els minuts</param>
        /// <param name="segons">Els segons</param>
        /// <returns></returns>
        static bool EsHoraValida(int hores, int minuts, int segons)
        {
            //ALTERNATIVA 1
            //bool resultat;
            //
            //if (hores < 0 || hores > 23)
            //{
            //    resultat = false;
            //}
            //else if (minuts < 0 || minuts > 59)
            //{
            //    resultat = false;
            //}
            //else if (segons < 0 || segons > 59)
            //{
            //    resultat = false;
            //}
            //else
            //{
            //    resultat = true;
            //}
            //
            //return resultat;

            //ALTERNATIVA 2
            //bool resultat;
            //
            //resultat = !((hores < 0 || hores > 23) || (minuts < 0 || minuts > 59) ||
            //    (segons < 0 || segons > 59));
            //
            //return resultat;

            return !((hores < 0 || hores > 23) || (minuts < 0 || minuts > 59) ||
                    (segons < 0 || segons > 59));
        }

    }
}
