namespace Ex_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char caracter = 'k';
            double angle = 120.5;
            bool actiu = true;
            bool condicio;

            condicio = caracter >= 'a' && caracter <= 'z';

            condicio = (caracter >= 'A' && caracter <= 'Z') ||
                (caracter >= 'a' && caracter <= 'Z');

            condicio = (caracter <= 'a' || caracter >= 'z') &&
                (caracter <= 'a' || caracter >= 'z');

            condicio = EsUnaLletra(caracter);

            condicio = (caracter == 'a') || (caracter == 'e') || caracter == 'i' ||  caracter == 'o' || caracter == 'u' ||
                (caracter == 'A') || (caracter == 'E') || caracter == 'I' || caracter == 'O' || caracter == 'U';

            condicio = EsUnaLletra(caracter) && !((caracter == 'a') || (caracter == 'e') || caracter == 'i' || caracter == 'o' || caracter == 'u' ||
                (caracter == 'A') || (caracter == 'E') || caracter == 'I' || caracter == 'O' || caracter == 'U');


        }
        static bool EsUnaLletra(char caracter)
        {
            bool condicio;

            condicio = (caracter >= 'A' && caracter <= 'Z') ||
                (caracter >= 'a' && caracter <= 'Z');

            return condicio;
        }
    }
}
