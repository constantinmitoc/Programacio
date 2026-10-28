namespace Ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què fa el programa: demana un número i en mostra la taula de multiplicar, de l'1 al 10.
             */
            int numero;

            Console.Write("Escriu un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int repeticions = 1; repeticions <= 10; repeticions++)
            {
                Console.WriteLine($"{numero} x {repeticions} = {numero * repeticions}");
            }
        }
    }
}
