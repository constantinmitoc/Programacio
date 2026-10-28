namespace Extra_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nomnom;
            string? nom;

            //Aquest string acepta canvia nulls per un espai
            Console.Write("Quin es el teu nom? ");
            nomnom = Console.ReadLine()??"";

            //Aquest string acepta nulls
            Console.Write("Quin es el teu nom? ");
            nom = Console.ReadLine();

            //Asegures de que no hi ha null
            nom = Console.ReadLine()!;
        }
    }
}
