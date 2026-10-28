namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Escriu  un  programa  per  demanar  una  lletra  minúscula  i  mostrar  la  lletra  majúscula 
               equivalent.  Per  assolir  el  vostre  objectiu,  cal  dissenyar  una  funció  que  rebi  un 
               caràcter  (suposarem  que  sempre  serà  una  lletra  minúscula)  i  retorni  el  valor 
               de la majúscula corresponent.
             */

            char lletraMi, lletraMa;
            
            Console.WriteLine("Quina es la teva lletra minuscula?");
            lletraMi = Convert.ToChar(Console.ReadLine()??"");

            lletraMa = CanviDeLLetra(lletraMi);

            Console.WriteLine($"La majuscula de {lletraMi} es {lletraMa}");
            
        }
        /// <summary>
        /// Canvia una lletra minuscula en majuscula
        /// </summary>
        /// <param name="lletraMi">La lletra minuscula</param>
        /// <returns></returns>
        static char CanviDeLLetra(char lletraMi)
        {
            int lletraMa;
            char lletraMA;

            lletraMa = Convert.ToInt32(lletraMi) - 32;
            lletraMA = Convert.ToChar(lletraMa);

            return lletraMA;
        }
    }
}
