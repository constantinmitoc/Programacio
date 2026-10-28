namespace Ex18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu un programa per mostrar aleatòriament una lletra majúscula. 
            */

            Random random = new Random();
            int numero;
            char lletra;
            numero = random.Next(65, 91);
            lletra = Convert.ToChar(numero);
            Console.WriteLine($"La teva lletra aleatoria es {lletra}");
        }
    }
}
