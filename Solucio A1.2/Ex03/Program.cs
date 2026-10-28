namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  demani  a  l’usuari  una  quantitat  d'hores,  minuts  i  segons  i  ens 
            informi per la consola del total de temps entrat, convertit tot en segons.
            */
            int hores, minuts, segons, minutsS, horesS, segonsT;

            Console.WriteLine("Quantes hores marca el rellotje? ");
            hores = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quants minuts marca el rellotje? ");
            minuts = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quants segons marca el rellotje? ");
            segons = Convert.ToInt32(Console.ReadLine());

            minutsS = minuts * 60;
            horesS = hores * 60 * 60;
            segonsT = horesS + minutsS + segons;

            Console.WriteLine($"El temps total acumulat es de {segonsT}");



        }
    }
}
