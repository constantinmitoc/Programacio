namespace MarcaDeFi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string RUTA = @"pluja_marca.txt";
            const int MARCA_DE_FI = -1;
            int nNumeros = 0;
            int plujaActual = 0, quantitatDePluja = 0;

            StreamReader fitxer = new StreamReader(RUTA);
            plujaActual = Convert.ToInt32(fitxer.ReadLine()??"-1");

            while (plujaActual != MARCA_DE_FI)
            {
                nNumeros++;
                quantitatDePluja = quantitatDePluja + plujaActual;

                plujaActual = Convert.ToInt32(fitxer.ReadLine() ?? "-1");
            }

            Console.WriteLine($"Ha plogut {quantitatDePluja} litres");
            Console.WriteLine($"Lectures: {nNumeros}");
            fitxer.Close();
        }
    }
}
