namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  per  mostrar  el  resultat  del  residu  i  la  divisió  entera  de  2  números 
            enters.  
            */
            int numero1, numero2, resultat, residu;
            
            Console.WriteLine("Quin es el primer numero?");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quin es el segon numero?");
            numero2 = Convert.ToInt32(Console.ReadLine());

            resultat = numero1 / numero2;
            residu = numero1 % numero2;

            Console.WriteLine($"El resultat de la divisio es {resultat} i el residu es {residu}");

        }
    }
}
