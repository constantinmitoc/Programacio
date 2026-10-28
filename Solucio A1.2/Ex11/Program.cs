namespace Ex11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Escriu  un  programa  per  calcular  la  nòmina  d'un  treballador:  L’usuari  ens  ha  d’entrar 
            el  nombre  total  d'hores  treballades,  el  sou  brut  per  cada  hora  treballada  i  el 
            percentatge d'impost aplicat al sou brut total, el programa ha d'informar de: 
                a. Sou brut total  
                b. Retenció d’impostos  
                c. Sou net (sou brut menys els impostos)
             */
            double nominabrut,hores,soubrut,governCaca,nominanet;

            Console.Write("Cuantes hores has treballat?  ");
            hores = Convert.ToDouble(Console.ReadLine());

            Console.Write("Cuant cobres per hora?  ");
            soubrut = Convert.ToDouble(Console.ReadLine());

            Console.Write("Quant es el percentatge que et roben?  ");
            governCaca = Convert.ToDouble(Console.ReadLine()) / 100;

            nominabrut = hores * soubrut;
            nominanet = nominabrut - (nominabrut * governCaca);

            Console.WriteLine($"El teu sou brut es {nominabrut} pero, com que et roben un {governCaca * 100}%, el teu sou net es de {nominanet}");

        }
    }
}
