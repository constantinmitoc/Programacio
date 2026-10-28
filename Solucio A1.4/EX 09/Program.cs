namespace EX_09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què ha de fer el programa: demanar les dues puntuacions i mostrar la valoració.
             * Pots suposar que les puntuacions són de 0 a 10
             */
            double puntuacioCritc = 0, puntuacioPubl = 0;
            string valoracio = "";

            Console.Write("Puntuació de la crítica: ");
            puntuacioCritc = Convert.ToDouble(Console.ReadLine());

            Console.Write("Puntuació del públic: ");
            puntuacioPubl = Convert.ToDouble(Console.ReadLine());

            valoracio = Valoracio(puntuacioCritc, puntuacioPubl);
            Console.Write(valoracio);
        }
        /// <summary>
        /// Valora la pelicula amb les dues puntuacions.
        /// </summary>
        /// <param name="puntuacioCritica">Puntuacio dels critics</param>
        /// <param name="puntuacioPublic">Puntuacio del public</param>
        /// <returns></returns>
        static string Valoracio(double puntuacioCritica, double puntuacioPublic)
        {
            string resultat = "";
            double mitjana = 0;

            mitjana = puntuacioCritica * 0.8 + puntuacioPublic * 0.2;

            if (puntuacioCritica > 10 || puntuacioPublic > 10)
            {
                resultat = "Puntuació no valida introduida";
            }
            else if (puntuacioCritica <= 3 || puntuacioPublic <= 3)
            {
                resultat = "Valoració: No recomanada";
            }
            else if (mitjana < 5)
            {
                resultat = "Valoració: No recomanada";
            }
            else if (mitjana >= 5 && mitjana < 7)
            {
                resultat = "Valoració: Correcta";
            }
            else if (mitjana >= 7 && mitjana < 9)
            {
                resultat = "Valoració: Bona";
            }
            else if (mitjana >= 9 && mitjana < 10)
            {
                resultat = "Valoració: Molt bona";
            }
            else
            {
                resultat = "Valoració: Obra maestra";
            }

            return resultat;
        }
    }
}
