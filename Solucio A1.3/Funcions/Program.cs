namespace Funcions
{
    internal class Program
    {
       static void Main(string[] args)
        {

            int solucio;
            int a, b;

            EscriuTitol();
            Console.WriteLine();
            Console.WriteLine("Escriu el valor del primer factor");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriu el valor del segon factor");
            b = Convert.ToInt32(Console.ReadLine());
            solucio = Multiplica(a,b);
            Console.WriteLine($"El resultat de la multiplicacio es {solucio}");
            Console.WriteLine();

            EscriuTitol();

            Console.WriteLine();

            static void EscriuTitol ()
            {
                Console.WriteLine("********************************");
                Console.WriteLine("*****        FUNCIONS      *****");
                Console.WriteLine("********************************");
            }

            /*
             * Les funcions s'sescriuen amb 'static', la sortida amb una variable, un nom, els parametres
             * entre '()' i el que fa entre '{}'.
             */
            


        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="primerFactor"></param>
        /// <param name="segonFactor"></param>
        /// <returns></returns>
        static int Multiplica(int primerFactor, int segonFactor)
        {
            int resultat;
            resultat = primerFactor * segonFactor;

            return resultat;
        }
    }
}
