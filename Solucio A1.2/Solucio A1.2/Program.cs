namespace Solucio_A1._2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  que  et  demani  la  teva  edat  i  et  digui  quants  anys  faràs  l'any 
            vinent.
            */
            int edat, edatVinen;

            Console.WriteLine("Quina edat tens? ");
            edat = Convert.ToInt32(Console.ReadLine());

            edatVinen = edat + 1;

            Console.WriteLine($"La teva edat l'any que ve sera {edatVinen}");



        }
    }
}
