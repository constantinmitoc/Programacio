namespace Ex17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  que  et  demani  el  nombre  de  cares  d'un  dau  i  després  llença  el 
            dau aleatòriament (suposa que el dau està numerat començant per 1). 
            */

            Random random = new Random();
            int cares, resultat;

            Console.WriteLine("Quantes cares te el teu dau?");
            cares = Convert.ToInt32(Console.ReadLine());

            resultat = random.Next(1, cares + 1);

            Console.WriteLine($"Ha caigut en el {resultat}");
        }
    }
}
