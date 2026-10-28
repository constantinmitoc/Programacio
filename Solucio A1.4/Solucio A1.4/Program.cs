
namespace Solucio_A1._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què ha de fer el programa: demanar un número enter i dir si és parell o senar,
             * i si és múltiple de 7 o no.
             */

            int numero = 0;

            Console.Write("Escriu un número enter: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (EsParell(numero))
            {
                Console.WriteLine($"{numero} es parell");
            }
            else
            {
                Console.WriteLine($"{numero} es senar.");
            }
            if (EsMultipleDe7(numero))
            {
                Console.WriteLine($"{numero} es multiple de 7.");
            }
            else
            {
                Console.WriteLine($"{numero} no es multiple de 7.");
            }
        }
        /// <summary>
        /// Comproba si el numero es parell.
        /// </summary>
        /// <param name="numero">El numero a comprobar</param>
        /// <returns></returns>
        static bool EsParell(int numero)
        {  
            return numero % 2 == 0;
        }
        /// <summary>
        /// Comproba si el numero es multiple de 7.
        /// </summary>
        /// <param name="numero">El numero a comprobar</param>
        /// <returns></returns>
        static bool EsMultipleDe7(int numero)
        {
            return numero % 7 == 0;
        }
    }
}
