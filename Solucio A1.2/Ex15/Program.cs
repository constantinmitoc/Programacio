namespace Ex15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Calcula  el  canvi  d'una  quantitat  en  euros  utilitzant  la  quantitat  mínima  de  monedes. 
            El  comerç  no  accepta  bitllets  de  500€  i  200€.  Has  de  començar  amb  bitllets  de  100€, 
            després  50€,  20€,  10€,  5€,  2€,  1€,  50  cèntims,  20  cèntims,  10  cèntims,  5  cèntims,  2 
            cèntims  i  1  cèntim.  Suposa  que  el  comerç  té  canvi  il·limitat  disponible  utilitzant 
            bitllets i monedes il·limitats.
            */
            double preu;
            int preuc, pagat, canvi, e100, e50, e20, e10, e5, e2, e1, c50, c20, c10, c5, c2, c1;

            Console.Write("Quant es el preu del producte?  ");
            preu = Convert.ToDouble(Console.ReadLine());
            preuc = Convert.ToInt32(preu * 100);

            Console.Write("Quant has pagat?  ");
            pagat = Convert.ToInt32(Console.ReadLine()) * 100;
            canvi = pagat - preuc;

            e100 = canvi / 10000;
            canvi = canvi % 10000;
            e50 = canvi / 5000;
            canvi = canvi % 5000;
            e20 = canvi / 2000;
            canvi = canvi % 2000;
            e10 = canvi / 1000;
            canvi = canvi % 1000;
            e5 = canvi / 500;
            canvi = canvi % 500;
            e2 = canvi / 200;
            canvi = canvi % 200;
            e1 = canvi / 100;
            canvi = canvi % 100;
            c50 = canvi / 50;
            canvi = canvi % 50;
            c20 = canvi / 20;
            canvi = canvi % 10;
            c10 = canvi / 10;
            canvi = canvi % 10;
            c5 = canvi / 5;
            canvi = canvi % 5;
            c2 = canvi / 2;
            canvi = canvi % 2;
            c1 = canvi;
            
            Console.WriteLine($"Tornes {e100}b100, {e50}b50, {e20}b20, {e10}b10, {e5}b5, {e2}m2, {e1}m1, {c50}m50, {c20}m20, {c10}m10, {c5}m5, {c2}m2, {c1}m1");

        }
    }
}
