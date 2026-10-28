namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  que  demani  per  teclat  dos  valors  corresponents  als  coeficients  a  i 
            b  d’una  equació  de  primer  grau  (  ax  +  b  =  0)  i  ens  calculi  la  solució  de  l’equació.  El 
            programa  després  de  demanar  els  dos  valors,  ens  ha  de  mostrar  l’equació  i  la  solució 
            mostrant  els  coeficients  a  i  b  així  com  la  solució  exactament  amb  dues  xifres 
            decimals. No cal considerar el cas a=0;
            */
            int valorA, valorB;
            double resposta;


            Console.WriteLine("Et demano els valors A i B en la ecuacio ax + b = 0");
            Console.WriteLine("Quin es el valor de A? ");
            valorA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Quin es el valor de B");
            valorB = Convert.ToInt32(Console.ReadLine());

            resposta = -valorB / valorA;

            Console.WriteLine($"En la ecuacio {valorA}x + {valorB} = 0, el valor de x es {resposta}");

        }
    }
}
