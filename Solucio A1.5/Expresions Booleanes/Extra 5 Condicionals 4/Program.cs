namespace Extra_5_Condicionals_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Escriu un numero:   ");
            numero = Convert.ToDouble(Console.ReadLine());


            if (numero < 0)
            {
                numero = ValorAbsolut(numero);
            }
            Console.WriteLine($"El teu numero en positiu es {numero}");
        }
        static double ValorAbsolut(double numero)
        {
            double resultat = 0;
            if (numero < 0)
            {
                numero = numero * -1;
                resultat = numero;
            }
            return resultat;
        }
        static bool EsParell(int numero)
        {
            //bool resultat;

            //if (numero % 2 == 0)
            //{
            //    resultat = true;
            //}
            //else
            //{
            //    resultat = false;
            //}
            //return resultat;

            //OR

            //bool resultat;

            //resultat = numero == 0;
            //return resultat;

            //OR

            return numero == 0;
        }
        static bool EsMultipleDe3 (int numero)
        {
            //bool resultat;
            //if (numero % 3 == 0)
            //{
            //    resultat = true;
            //}
            //else
            //{
            //    resultat = false;
            //}
            //return resultat;

            //OR

            return numero % 3 == 0;
        }
        static string ResultatPartida(int puntuacioJ1, int puntuacioJ2)
        {
            string resultat = "";
            
            if (puntuacioJ1 > puntuacioJ2)
            {
                resultat = "Guanya el Jugador 1";
            }
            else if (puntuacioJ2 > puntuacioJ1)
            {
                resultat = "Guanya el Jugador 2";
            }
            else
            {
                resultat = "Els jugadors han empatat";
            }

            return resultat;
        }
    }
}
