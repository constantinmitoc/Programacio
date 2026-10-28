namespace Ex14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  per  mostrar  l'hora  en  format  hh:mm:ss  a  partir  d'una  quantitat 
            de  segons  donada  com  a  entrada.  Per  exemple,  si  l'entrada  és  4000,  la  sortida  ha  de 
            ser 01:04:40.
             */
            int hores, minuts, segons, total;

            Console.WriteLine("Quants segons tens?");
            total = Convert.ToInt32(Console.ReadLine());

            hores = total / 3600;
            minuts = (total % 3600) / 60;
            segons = ((total % 3600) % 60);

            Console.WriteLine($"El valor {hores}:{minuts}:{segons}");


        }
    }
}
