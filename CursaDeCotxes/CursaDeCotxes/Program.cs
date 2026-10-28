namespace CursaDeCotxes
{
    /// <summary>
    /// Joc de curses de cotxes per a dos jugadors a la consola. Cada jugador prem
    /// la seva tecla tan ràpid com pot, i guanya qui arriba primer a la meta.
    /// </summary>
    internal class Program
    {
        // --- POSICIONS DE LA PISTA --
        /// <summary>
        /// Columna on comencen la cursa els cotxes.
        /// </summary>
        const int SORTIDA = 20;
        /// <summary>
        /// Columna de la línia de meta, que és també la vora dreta del marc.
        /// </summary>
        const int META = 100;
        /// <summary>
        /// Fila on comença el dibuix: la vora superior del marc.
        /// </summary>
        const int MARGE_SUPERIOR = 5;
        /// <summary>
        /// Fila on s'escriu "Marcador:" i on surten els missatges per als jugadors.
        /// </summary>
        const int FILA_MARCADOR = MARGE_SUPERIOR + 1;
        /// <summary>
        /// Fila de la línia que separa el marcador de la pista.
        /// </summary>
        const int FILA_SEPARADORA = MARGE_SUPERIOR + 4;
        /// <summary>
        /// Fila per on corre el cotxe 1.
        /// </summary>
        const int FILA_COTXE1 = MARGE_SUPERIOR + 6;
        /// <summary>
        /// Fila per on corre el cotxe 2.
        /// </summary>
        const int FILA_COTXE2 = MARGE_SUPERIOR + 8;
        /// <summary>
        /// Fila de la vora inferior del marc.
        /// </summary>
        const int FILA_INFERIOR = MARGE_SUPERIOR + 10;
        // --- DIBUIXOS ---
        /// <summary>
        /// Dibuix del cotxe.
        /// </summary>
        const string COTXE = "Ö=o.";
        /// <summary>
        /// Dibuix del rastre que deixa el cotxe quan avança.
        /// </summary>
        const char ESTELA = '▓';
        /// <summary>
        /// Cantó superior esquerre del marc.
        /// </summary>
        const char CANTO_SUPERIOR_ESQUERRE = '╔';
        /// <summary>
        /// Cantó superior dret del marc.
        /// </summary>
        const char CANTO_SUPERIOR_DRET = '╗';
        /// <summary>
        /// Cantó inferior esquerre del marc.
        /// </summary>
        const char CANTO_INFERIOR_ESQUERRE = '╚';
        /// <summary>
        /// Cantó inferior dret del marc.
        /// </summary>
        const char CANTO_INFERIOR_DRET = '╝';
        /// <summary>
        /// Extrem esquerre de la línia separadora.
        /// </summary>
        const char SEPARADOR_ESQUERRE = '╠';
        /// <summary>
        /// Extrem dret de la línia separadora.
        /// </summary>
        const char SEPARADOR_DRET = '╣';
        /// <summary>
        /// Tros de línia horitzontal del marc.
        /// </summary>
        const char LINIA_HORITZONTAL = '═';
        /// <summary>
        /// Tros de línia vertical del marc.
        /// </summary>
        const char LINIA_VERTICAL = '║';
        // --- COLORS --
        /// <summary>
        /// Color de fons de tota la pantalla.
        /// </summary>
        const ConsoleColor COLOR_FONS = ConsoleColor.Gray;
        /// <summary>
        /// Color de les línies del marc i del text "Marcador:".
        /// </summary>
        const ConsoleColor COLOR_LINIES = ConsoleColor.DarkGray;
        /// <summary>
        /// Color del cotxe 1, de la seva estela i del seu marcador.
        /// </summary>
        const ConsoleColor COLOR_COTXE1 = ConsoleColor.Red;
        /// <summary>
        /// Color del cotxe 2, de la seva estela i del seu marcador.
        /// </summary>
        const ConsoleColor COLOR_COTXE2 = ConsoleColor.Blue;
        // --- MECÀNICA DEL JOC --
        /// <summary>
        /// Vegades que cal prémer la tecla perquè el cotxe avanci una columna.
        /// </summary>
        const int VALOR_POSICIO = 3;
        /// <summary>
        /// Tecla del jugador 1.
        /// </summary>
        const ConsoleKey JUGADOR1 = ConsoleKey.Q;
        /// <summary>
        /// Tecla del jugador 2.
        /// </summary>
        const ConsoleKey JUGADOR2 = ConsoleKey.P;
        /// <summary>
        /// Tecla per començar la cursa i per sortir del joc.
        /// </summary>
        const ConsoleKey ACCIO = ConsoleKey.Spacebar;
        /// <summary>
        /// Punt d'entrada del programa. Dibuixa la pista, espera que els jugadors
        /// estiguin preparats, fa córrer la cursa i anuncia el guanyador.
        /// </summary>
        static void Main()
        {
            // Vegades que cada jugador ha premut la seva tecla
            int cotxe1 = 0;
            int cotxe2 = 0;
            // El marc comença una columna abans de l'espai que ocupa el cotxe a la sortida
            int esquerra = SORTIDA - COTXE.Length - 1;
            // Sumem 2 per les dues columnes de les vores verticals
            int llargada = META - SORTIDA + COTXE.Length + 2;
            // Els textos comencen dues columnes a la dreta de la vora esquerra
            int columnaText = esquerra + 2;
            // Guardem els colors originals per restaurar-los al final
            ConsoleColor fonsOriginal = Console.BackgroundColor;
            ConsoleColor lletraOriginal = Console.ForegroundColor;
            // Perquè el marc i el cotxe es vegin bé a qualsevol consola
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // 1. Dibuixem l'escenari inicial
            PintaPantalla(esquerra, llargada, columnaText, cotxe1, cotxe2);
            // 2. Esperem que els jugadors estiguin preparats
            Preparats(columnaText);
            // 3. Tornem a pintar per esborrar el missatge de "Preparats"
            PintaPantalla(esquerra, llargada, columnaText, cotxe1, cotxe2);
            // 4. Bucle principal del joc: mentre ningú guanyi
            while (HiHaGuanyador(cotxe1, cotxe2) == false)
            {
                // Llegim la tecla sense mostrar-la per pantalla (true)
                ConsoleKey tecla = Console.ReadKey(true).Key;
                if (tecla == JUGADOR1)
                {
                    cotxe1 = cotxe1 + 1;
                }
                else if (tecla == JUGADOR2)
                {
                    cotxe2 = cotxe2 + 1;
                }
                // Actualitzem només el marcador i els cotxes, no tot l'escenari
                PintaMarcador(columnaText, cotxe1, cotxe2);
                PintaCotxes(cotxe1, cotxe2);
            }
            // 5. Final del joc
            PintaGuanyador(columnaText, cotxe1, cotxe2);
            // Deixem la consola com l'hem trobada
            Console.BackgroundColor = fonsOriginal;
            Console.ForegroundColor = lletraOriginal;
            Console.CursorVisible = true;
            Console.Clear();
        }
        // --------------------------------------------------------
        // A PARTIR D'AQUÍ ÉS ON HAS DE PROGRAMAR LES TEVES FUNCIONS
        // --------------------------------------------------------
        /// <summary>
        /// Omple la pantalla amb el color de fons, amaga el cursor i dibuixa
        /// el marc del joc, el marcador i els cotxes.
        /// </summary>
        /// <param name="esquerra">Columna de la vora esquerra del marc.</param>
        /// <param name="llargada">Amplada del marc en caràcters, comptant les dues vores.
        /// </param>
        /// <param name="columnaText">Columna on comencen els textos del marcador.</param>
        /// <param name="cotxe1">Nombre de vegades que el jugador 1 ha premut la seva 
        /// tecla.
        /// </param>
        /// <param name="cotxe2">Nombre de vegades que el jugador 2 ha premut la seva 
        /// tecla.
        /// </param>
        private static void PintaPantalla(int esquerra, int llargada, int columnaText, int
        cotxe1, int cotxe2)
        {
            Console.CursorVisible = false;
            Console.BackgroundColor = COLOR_FONS;
            Console.Clear();
            PintaLiniaSuperior(esquerra, llargada);
            PintaLiniesLaterals(esquerra, llargada);
            PintaLiniaSeparadora(esquerra, llargada);
            PintaLiniaInferior(esquerra, llargada);
            PintaMarcador(columnaText, cotxe1, cotxe2);
            PintaCotxes(cotxe1, cotxe2);
        }
        /// <summary>
        /// Dibuixa la vora superior del marc amb els caràcters ╔, ═ i ╗.
        /// </summary>
        /// <param name="esquerra">Columna de la vora esquerra del marc.</param>
        /// <param name="llargada">Amplada del marc en caràcters, comptant les dues vores.
        /// </param>
        private static void PintaLiniaSuperior(int esquerra, int llargada)
        {
            Console.BackgroundColor = COLOR_FONS;
            Console.ForegroundColor = COLOR_LINIES;
            Console.CursorLeft = esquerra;
            Console.CursorTop = MARGE_SUPERIOR;
            Console.Write(CANTO_SUPERIOR_ESQUERRE);
            for (; llargada - 2 != 0; llargada-- )
            {
                Console.Write(LINIA_HORITZONTAL);
            }
            Console.Write(CANTO_SUPERIOR_DRET);
        }
        /// <summary>
        /// Dibuixa les vores esquerra i dreta del marc amb el caràcter ║.
        /// </summary>
        /// <param name="esquerra">Columna de la vora esquerra del marc.</param>
        /// <param name="llargada">Amplada del marc en caràcters, comptant les dues vores.
        /// </param>
        private static void PintaLiniesLaterals(int esquerra, int llargada)
        {
            int dreta = esquerra + llargada - 1;
            Console.BackgroundColor = COLOR_FONS;
            Console.ForegroundColor = COLOR_LINIES;
            for (int fila = MARGE_SUPERIOR + 1; fila < FILA_INFERIOR; fila++)
            {
                Console.CursorTop = fila;
                Console.CursorLeft = esquerra;
                Console.Write(LINIA_VERTICAL);
                Console.CursorLeft = dreta;
                Console.Write(LINIA_VERTICAL);
            }
        }
        /// <summary>
        /// Dibuixa la línia que separa el marcador de la pista amb els caràcters ╠, ═ i ╣.
        /// </summary>
        /// <param name="esquerra">Columna de la vora esquerra del marc.</param>
        /// <param name="llargada">Amplada del marc en caràcters, comptant les dues vores.
        /// </param>
        private static void PintaLiniaSeparadora(int esquerra, int llargada)
        {
            Console.BackgroundColor = COLOR_FONS;
            Console.ForegroundColor = COLOR_LINIES;
            Console.CursorLeft = esquerra;
            Console.CursorTop = FILA_SEPARADORA;
            Console.Write(SEPARADOR_ESQUERRE);
            for (; llargada - 2 != 0; llargada--)
            {
                Console.Write(LINIA_HORITZONTAL);
            }
            Console.Write(SEPARADOR_DRET);
        }
        /// <summary>
        /// Dibuixa la vora inferior del marc amb els caràcters ╚, ═ i ╝.
        /// </summary>
        /// <param name="esquerra">Columna de la vora esquerra del marc.</param>
        /// <param name="llargada">Amplada del marc en caràcters, comptant les dues vores.
        /// </param>
        private static void PintaLiniaInferior(int esquerra, int llargada)
        {
            Console.BackgroundColor = COLOR_FONS;
            Console.ForegroundColor = COLOR_LINIES;
            Console.CursorLeft = esquerra;
            Console.CursorTop = FILA_INFERIOR;
            Console.Write(CANTO_INFERIOR_ESQUERRE);
            for (; llargada - 2 != 0; llargada--)
            {
                Console.Write(LINIA_HORITZONTAL);
            }
            Console.Write(CANTO_INFERIOR_DRET);
        }
        /// <summary>
        /// Escriu el marcador: el text "Marcador:" i, a sota, les pulsacions
        /// de cada jugador amb el color del seu cotxe.
        /// </summary>
        /// <param name="columna">Columna on comencen els textos.</param>
        /// <param name="cotxe1">Nombre de vegades que el jugador 1 ha premut la seva 
        /// tecla.
        /// </param>
        /// <param name="cotxe2">Nombre de vegades que el jugador 2 ha premut la seva 
        /// tecla.
        /// </param>
        private static void PintaMarcador(int columna, int cotxe1, int cotxe2)
        {
            Console.BackgroundColor = COLOR_FONS;
            Console.ForegroundColor = COLOR_LINIES;
            Console.CursorLeft = columna;
            Console.CursorTop = FILA_MARCADOR;
            Console.Write("Marcador: ");
            Console.ForegroundColor = COLOR_COTXE1;
            Console.CursorLeft = columna;
            Console.CursorTop = FILA_MARCADOR + 1;
            Console.Write($"Cotxe 1: {cotxe1}");
            Console.ForegroundColor = COLOR_COTXE2;
            Console.CursorLeft = columna;
            Console.CursorTop = FILA_MARCADOR + 2;
            Console.Write($"Cotxe 2: {cotxe2}");
        }
        /// <summary>
        /// Dibuixa els dos cotxes, cadascun a la seva fila i amb el seu color.
        /// </summary>
        /// <param name="cotxe1">Nombre de vegades que el jugador 1 ha premut la seva 
        /// tecla.
        /// </param>
        /// <param name="cotxe2">Nombre de vegades que el jugador 2 ha premut la seva 
        /// tecla.
        /// </param>
        private static void PintaCotxes(int cotxe1, int cotxe2)
        {
            PintaCotxe(cotxe1, FILA_COTXE1, COLOR_COTXE1);
            PintaCotxe(cotxe2, FILA_COTXE2, COLOR_COTXE2);
        }
        /// <summary>
        /// Dibuixa un cotxe: l'estela des de la sortida fins on ha arribat, i el cotxe al 
        /// final.
        /// </summary>
        /// <param name="pulsacions">Nombre de vegades que el jugador ha premut la seva 
        /// tecla.
        /// </param>
        /// <param name="fila">Fila per on corre el cotxe.</param>
        /// <param name="color">Color del cotxe i de la seva estela.</param>
        private static void PintaCotxe(int pulsacions, int fila, ConsoleColor color)
        {
            int posicio = pulsacions / VALOR_POSICIO + SORTIDA;
            Console.BackgroundColor = COLOR_FONS;
            Console.ForegroundColor = color;
            Console.CursorLeft = SORTIDA;
            Console.CursorTop = fila;
            int columna;
            for (columna = SORTIDA; columna < posicio; columna++)
            {
                Console.Write(ESTELA);
            }
            Console.Write(COTXE);
        }
        /// <summary>
        /// Indica si algun dels dos cotxes ha arribat a la meta.
        /// </summary>
        /// <param name="cotxe1">Nombre de vegades que el jugador 1 ha premut la seva 
        /// tecla.</param>
        /// <param name="cotxe2">Nombre de vegades que el jugador 2 ha premut la seva 
        /// tecla.</param>
        /// <returns>Cert si algun dels dos cotxes ha arribat a la meta; fals altrament.
        /// </returns>
        private static bool HiHaGuanyador(int cotxe1, int cotxe2)
        {
            bool hiHaGuanyador = false;
            int pulsacionsMeta = 3 * (META - SORTIDA - COTXE.Length);
            hiHaGuanyador = cotxe1 >= pulsacionsMeta || cotxe2 >= pulsacionsMeta;
            return hiHaGuanyador;
        }
        /// <summary>
        /// Espera que l'usuari premi una tecla concreta. Les altres tecles no fan res.
        /// </summary>
        /// <param name="teclaEsperada">La tecla que cal prémer per continuar.</param>
        private static void EsperaTecla(ConsoleKey teclaEsperada)
        {
            ConsoleKey tecla = ConsoleKey.NoName;
            do
            {
                tecla = Console.ReadKey(true).Key;
            } while (tecla != teclaEsperada);
        }
        /// <summary>
        /// Escriu, en blanc sobre vermell i a la fila del marcador, el missatge
        /// "Prem la barra d'espai per començar la cursa ..." i espera que algú premi 
        /// l'espai.
        /// </summary>
        /// <param name="columna">Columna on comença el missatge.</param>
        private static void Preparats(int columna)
        {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorLeft = columna;
            Console.CursorTop = FILA_MARCADOR;
            Console.Write("Prem la barra d'espai per començar la cursa ...");
            Console.BackgroundColor = COLOR_FONS;
            EsperaTecla(ACCIO);
        }
        /// <summary>
        /// Escriu, en blanc sobre vermell i a la fila del marcador, el missatge
        /// "Ha guanyat el cotxe N! Prem la barra d'espai per sortir ..." i espera que algú 
        /// premi l'espai.
        /// </summary>
        /// <param name="columna">Columna on comença el missatge.</param>
        /// <param name="cotxe1">Nombre de vegades que el jugador 1 ha premut la seva 
        /// tecla.</param>
        /// <param name="cotxe2">Nombre de vegades que el jugador 2 ha premut la seva 
        /// tecla.</param>
        private static void PintaGuanyador(int columna, int cotxe1, int cotxe2)
        {
            int guanyador = 2;
            if (cotxe1 > cotxe2)
            {
                guanyador = 1;
            }
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.White;
            Console.CursorLeft = columna;
            Console.CursorTop = FILA_MARCADOR;
            Console.Write($"Ha guanyat el cotxe {guanyador}! Prem la barra d'espai per sortir ...");
            Console.BackgroundColor = COLOR_FONS;
            EsperaTecla(ACCIO);
        }
    }
}