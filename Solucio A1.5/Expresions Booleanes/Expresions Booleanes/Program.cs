namespace Expresions_Booleanes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool plou = true;
            bool portoParaigues = true;
            bool emMullare;


            emMullare = plou && !portoParaigues;
            emMullare = !(!plou || portoParaigues);

            int dividend = 10;
            int divisor = 0;

            bool esDivisible = divisor != 0 && dividend % divisor == 0;
        }
    }
}
