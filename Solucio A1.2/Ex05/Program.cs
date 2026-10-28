namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  per  demanar  una  lletra  pel  teclat  i  mostrar  el  seu  codi  ASCII  a  la 
            pantalla. 
            */

            char lalletra, lalletraseguent, LALLETRA;
            int lletraASCII, LLETRAASCII;

            Console.WriteLine("Quin es el teu caracter? ");
            lalletra = Convert.ToChar(Console.ReadLine()??"");

            lletraASCII = Convert.ToInt32(lalletra);
            lalletraseguent = Convert.ToChar(lalletra + 1);

            Console.WriteLine($"En ASCII, la lletra {lalletra} es {lletraASCII} i el caracter seguent es {lalletraseguent}";

            Console.WriteLine("Entra un numero entre 0 i 127");
            LLETRAASCII = Convert.ToInt32(Console.ReadLine());

            LALLETRA = Convert.ToChar(LLETRAASCII);
            Console.WriteLine($"Com a caracter, el numero {LLETRAASCII} es el caracter {LALLETRA}");

        }
    }
}
