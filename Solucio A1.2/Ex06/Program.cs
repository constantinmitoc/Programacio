namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  per  demanar  una  lletra  minúscula  i  mostrar  la  lletra  majúscula 
            equivalent.
            */
            char lletraMi;
            int lletraASCII;
            char lletraMa;

            Console.WriteLine("Quina lletra minuscula vols transformar a majuscula? ");
            lletraMi = Convert.ToChar(Console.ReadLine()??"");

            lletraASCII = (lletraMi - 32);
            
            lletraMa = Convert.ToChar(lletraASCII);
            Console.WriteLine($"L'equivalencia en majuscula de la lletra {lletraMi} es {lletraMa}");
            

        }
    }
}
