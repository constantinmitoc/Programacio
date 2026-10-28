namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Demana  a  l'usuari  que  introdueixi  un  número  enter  que  representi  un  any  i  mostra  els 
            4 dígits per separat. 
            */
            int any, any1, any2, any3, any4;

            Console.WriteLine("Diga'm un any");
            any = Convert.ToInt32(Console.ReadLine());

            any1 = (any / 1000) % 10;
            any2 = (any / 100) % 10;
            any3 = (any / 10) % 10;
            any4 = any % 10;

            Console.WriteLine($"Els teu valors son {any1}, {any2}, {any3}, {any4}");
        }
    }
}
