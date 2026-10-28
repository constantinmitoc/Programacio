namespace Ex_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què ha de fer el programa: demanar un número enter de 3 xifres i dir si 
             * és cap-i-cua. Si el número no té 3 xifres, ha d'avisar-ho.
             */
            int numero = 0;

            Console.Write("Escriu un número de 3 xifres: ");
            numero = Convert.ToInt32(Console.ReadLine());

            Console.Write(CapICua(numero));
        }
        /// <summary>
        /// Retorna un string sobre si el numero es o no cap-i-cua. Comproba tambe si el numero
        /// es de 3 xifres.
        /// </summary>
        /// <param name="numero">El numero introduit de 3 xifres</param>
        /// <returns></returns>
        static string CapICua(int numero)
        {
            string resultat = "";

            if (numero < 99 || numero > 1000)
            {
                resultat = "El número ha de tenir 3 xifres.";
            }
            else if (numero / 100 == numero % 10)
            {
                resultat = $"{numero} és cap-i-cua.";
            }
            else
            {
                resultat = $"{numero} no és cap-i-cua.";
            }

            

            return resultat;
        }
    }
}
