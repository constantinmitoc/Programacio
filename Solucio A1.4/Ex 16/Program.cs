namespace Ex_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què ha de fer el programa: demanar un any i mostrar totes les propietats que té,
             * en aquest ordre: any de traspàs, festival Huluculu, festival Bulukulu. Cada 
             * propietat va en una línia. Si l'any no en té cap, ha de mostrar Aquest és un any normal. 
             */
            int any = 0;

            Console.Write("Escriu un any: ");
            any = Convert.ToInt32(Console.ReadLine());

            if (EsAnyDeTraspas(any))
            {
                Console.WriteLine("Any de traspàs.");
            }
            if (EsAnyFestivalHuluculu(any))
            {
                Console.WriteLine("Any del festival Huluculu.");
            }
            if (EsAnyFestivalBulukulu(any))
            {
                Console.WriteLine("Any del festival Bulukulu.");
            }
            if (EsAnyDeTraspas(any) == false && EsAnyFestivalHuluculu(any) == false &&
                (EsAnyFestivalBulukulu(any) == false))
            {
                Console.WriteLine("Aquest és un any normal.");
            }
        }
        /// <summary>
        /// Torna "true" si es un any de trespas.
        /// </summary>
        /// <param name="any">L'any introduit</param>
        /// <returns></returns>
        static bool EsAnyDeTraspas(int any)
        {
            return (any % 4 == 0 && any % 100 != 0) || (any % 400 == 0);
        }
        /// <summary>
        /// Torna "true" si es festival huluculu.
        /// </summary>
        /// <param name="any">L'any introduit</param>
        /// <returns></returns>
        static bool EsAnyFestivalHuluculu(int any)
        {
           return any % 15 == 0;
        }
        /// <summary>
        /// Torna "true" si es festival BuluKulu.
        /// </summary>
        /// <param name="any">L'any introduit</param>
        /// <returns></returns>
        static bool EsAnyFestivalBulukulu(int any)
        {
            return EsAnyDeTraspas(any) && any % 55 == 0;
        }
    }
}
