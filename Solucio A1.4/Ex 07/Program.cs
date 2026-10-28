using System.Runtime.InteropServices;
using System.Text;

namespace Ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què ha de fer el programa: demanar la velocitat del vehicle (número enter) i
             * mostrar la sanció que li correspon.
             */
            Console.OutputEncoding = Encoding.UTF8;

            int velocitat = 0;
            string sancio = "";

            Console.Write("Velocitat del vehicle (km/h): ");
            velocitat = Convert.ToInt32(Console.ReadLine());

            sancio = Sancio(velocitat);
            Console.Write(sancio);
        }
        /// <summary>
        /// Calcula la multa per incompliment de velocitat.
        /// </summary>
        /// <param name="velocitat">La velocitat a la que s'anava</param>
        /// <returns></returns>
        static string Sancio(int velocitat)
        {
            string resultat = "";

            if (velocitat < 80)
            {
                resultat = ("Sense sancio");
            }
            else if (velocitat >= 80 && velocitat < 100)
            {
                resultat = ("Multa de 100 €");
            }
            else if (velocitat >= 100 && velocitat < 130)
            {

                resultat = ("Multa de 300 €");
            }
            else
            {
                resultat = ("Multa de 600 € i retirada del carnet.");
            }

            return resultat;
        }
    }
}
