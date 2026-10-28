namespace Ex16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  que  ens  mostri  el  resultat  aleatori  del  partit  Paris  Sant  Germain  - 
            Girona  de  forma  que  tant  el  valor  dels  gols  d’un  com  de  l’altre  equip  sigui  un  valor  a 
            l’atzar entre 0 i 6. 
            */
            Random random = new Random();

            int golSG, golGir;

            golSG = random.Next(1, 7);
            golGir = random.Next(1, 7);

            Console.WriteLine($"Aquest partit acabara en un {golSG}-{golGir} a favor del Girona");

        }
    }
}
