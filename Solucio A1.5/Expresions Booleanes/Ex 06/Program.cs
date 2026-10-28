namespace Ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int edat = 70, alcadaCm = 105;
            bool acompanyat = true;
            bool potPujarMuntanyaRussa, potPujarBarques, entradaReduida;

            potPujarMuntanyaRussa = alcadaCm >= 140;
            potPujarBarques = alcadaCm > 110 && (edat == 12 || acompanyat == true);
            entradaReduida = edat < 12 || edat > 64;

            Console.WriteLine($"Pot pujar a la muntanya: {potPujarMuntanyaRussa}");
            Console.WriteLine($"Pot pujar a les barques: {potPujarBarques}");
            Console.WriteLine($"Te entrada reduida: {entradaReduida}");
        }
    }
}
