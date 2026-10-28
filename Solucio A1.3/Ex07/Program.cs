namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Demana  a  l'usuari  que  introdueixi  un  número  enter  (suposarem  que  l’usuari 
                sempre  entra  un  numero  enter  de  4  digits)  i  el  programa  ens  ha  de  dir
                quant  sumen els seus digits. Per exemple, si l’usuari entra 1234 el programa ha de
                mostrar: 
                Els  digits  1234  sumen  10.  Per  fer-ho,  dissenyeu  una  funció  que  rebi  un 
                enter (suposarem  que  l’enter  sempre  té  4  dígits)  i  que  retorni  un  altre  
                enter corresponent a la suma dels seus digits. 
             */
            int numero4xifres, sumaTotal;

            Console.WriteLine("Introdueix un numero de cuatre xifres i jo sumare el total d'aquestes");
            numero4xifres = Convert.ToInt32(Console.ReadLine());

            sumaTotal = SumaDeXifres(numero4xifres);

            Console.WriteLine($"La suma de les cuatre xifres del teu numero es {sumaTotal}");
        }
        static int SumaDeXifres(int numero4xifres)
        {
            int total, total1, total2, total3, total4, residu;

            //1234
            total1 = numero4xifres % 10; //4
            residu = numero4xifres / 10; //123
            total2 = residu % 10; //3
            residu = numero4xifres / 100;//12
            total3 = residu % 10;//2
            total4 = residu / 10;//1
            total = total1 + total2 + total3 + total4;

            return total;
        }
    }
}
