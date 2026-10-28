namespace Ex_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *Què ha de fer el programa: demanar per separat les hores, els minuts i els segons,
             *i mostrar l'hora entrada i l'hora un segon més tard, totes dues amb el format
             *hh:mm:ss. Si l'hora no és correcta, ha d'avisar-ho.
             */
            int hora = 0, minut = 0, segon = 0;

            Console.Write("Hores: ");
            hora = Convert.ToInt32(Console.ReadLine());
            Console.Write("Minuts: ");
            minut = Convert.ToInt32(Console.ReadLine());
            Console.Write("Segons: ");
            segon = Convert.ToInt32(Console.ReadLine());

            if (EsHoraValida(hora, minut, segon) == false)
            {
                Console.Write("L'hora no és correcta.");
            }
            else
            {
                Console.WriteLine($"Hora inicial: {FormatHora(hora, minut, segon)}");
                Console.WriteLine($"Un segon més tard: {Incrementa1Segon(hora, minut, segon)}");
            }
            

        }
        /// <summary>
        /// Reb hores, minuts i segons i les torna amb un increment d'un segon.
        /// </summary>
        /// <param name="hores">Les hores introduides</param>
        /// <param name="minuts">Els minuts introduits</param>
        /// <param name="segons">Els segons introduits</param>
        /// <returns></returns>
        static string Incrementa1Segon(int hores, int minuts, int segons)
        {
            segons = segons + 1;

            if (segons == 60)
            {
                minuts = minuts + 1;
                segons = 00;
            }
            if (minuts == 60)
            {
                hores = hores + 1;
                minuts = 00;
            }
            if (hores == 24)
            {
                hores = 00;
                minuts = 00;
                segons = 00;
            }

            return FormatHora(hores, minuts, segons);

            //ALTERNATIVA (Si es 0 el minuts o segons, nomes posa una xifra de 0)
            //
            //string resposta = "";
            //resposta = FormatHora(hores, minuts, segons);
            //
            //return resposta;

            //ALTERNATIVA 2 (AMB LA FUNCIO "ZeroAlDavant")
            //
            //if (segons == 0 || minuts == 0 || segons == 0)
            //{
            //    return $"{ZeroAlDavant(hores)}{hores}:{ZeroAlDavant(minuts)}{minuts}:" +
            //        $"{ZeroAlDavant(segons)}{segons}";
            //}
            //else
            //{
            //    return FormatHora(hores, minuts, segons);
            //}
        }
        /// <summary>
        /// Transforma el temps introduit en el format correcte
        /// </summary>
        /// <param name="hores">Les hores introduides</param>
        /// <param name="minuts">Els minuts introduits</param>
        /// <param name="segons">Els segons introduits</param>
        /// <returns></returns>
        static string FormatHora(int hores, int minuts, int segons)
        {
            string resposta = "";

            resposta = $"{hores:D2}:{minuts:D2}:{segons:D2}";

            return resposta;
        }
        /// Calcula si el temps insertat es en format correcte.
        /// </summary>
        /// <param name="hores">Les hores</param>
        /// <param name="minuts">Els minuts</param>
        /// <param name="segons">Els segons</param>
        /// <returns></returns>
        static bool EsHoraValida(int hores, int minuts, int segons)
        {
            return !((hores < 0 || hores > 23) || (minuts < 0 || minuts > 59) ||
                    (segons < 0 || segons > 59));
        }
        /// <summary>
        /// ALTERNATIVA PER A POSAR UN 0 AL DAVANT
        /// </summary>
        /// <param name="numero"></param>
        /// <returns></returns>
        static string ZeroAlDavant(int numero)
        {
            ///AIXO ES UNA ALTERNATIVA PER A POSAR UN 0 AL DAVANT (MOLT LLARGA I LLETJA)
            string zero = "0";

            if (numero < 10)
            {
                return zero;
            }
            else
            {
                return "";
            }
        }
    }
}
