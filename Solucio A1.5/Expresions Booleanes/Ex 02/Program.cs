using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Original
            acabat == false && caracter != '.';
           //Morgan
            !(acabat || caracter == '.');

            //Original
            nivell < 3 || errors == 0 && avisos == 0;
            //Morgan
            !(nivell >= 3 && (errors != 0 || avisos != 0));

            //Original
            'a' <= caracter && caracter <= 'z';
            //Morgan
            !('a' > caracter || caracter > 'z');

            //Original
            caracter != 'a' && caracter != 'e' && caracter != 'i' && caracter != 'o' && caracter != 'u';
            //Morgan
            !(caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u';


        }
    }
}
