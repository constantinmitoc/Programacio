namespace Ex_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què ha de fer el programa: demanar un angle enter entre −360 i 360, i 
             * dir en quin quadrant és, o si és sobre un eix. Si l'angle no és entre −360 i 
             * 360, ha d'avisar-ho.
             */
            int angle = 0;
            //string resposta = "";

            Console.Write("Escriu un angle: ");
            angle = Convert.ToInt32(Console.ReadLine());

            /*resposta = Angle(angle)*/;
            Console.Write($"{AngleAQuadrant(angle)}");
        }
        /// <summary>
        /// Calcula el quadrant on es troba l'angle (-360 a 360).
        /// </summary>
        /// <param name="angle">L'angle introduit</param>
        /// <returns></returns>
        static string AngleAQuadrant(int angle)
        {
            //ALTERNATIVA
            //
            //string resultat = "";
            //
            //if ((angle > 0 && angle < 90) || (angle > -360 && angle < -270))
            //{
            //    resultat = $"L'angle {angle} és al quadrant I.";
            //}
            //else if ((angle > 90 && angle < 180) || (angle > -270 && angle < -180))
            //{
            //    resultat = $"L'angle {angle} és al quadrant II.";
            //}
            //else if ((angle > 180 && angle < 270) || (angle > -180 && angle < -90))
            //{
            //    resultat = $"L'angle {angle} és al quadrant III.";
            //}
            //else if ((angle > 270 && angle < 360) || (angle > -90 && angle < 0))
            //{
            //    resultat = $"L'angle {angle} és al quadrant IV.";
            //}
            //else if (angle == 0 || angle == 90 || angle == 270 || angle == 360 ||
            //    angle == -90 || angle == -180 || angle == -270 || angle == -360)
            //{
            //    resultat = $"L'angle {angle} és sobre un eix.";
            //}
            //else
            //{
            //    resultat = "L'angle ha d'estar entre -360 i 360.";
            //}
            //
            //return resultat;

            string resultat = "";
            int angleModificat = 0;

            if (angle < 0)
            {
                angleModificat = angle + 360;
            }

            if (angleModificat > 0 && angleModificat < 90)
            {
                resultat = $"L'angle {angle} és al quadrant I.";
            }
            else if (angleModificat > 90 && angleModificat < 180)
            {
                resultat = $"L'angle {angle} és al quadrant II.";
            }
            else if (angleModificat > 180 && angleModificat < 270)
            {
                resultat = $"L'angle {angle} és al quadrant III.";
            }
            else if (angleModificat > 270 && angleModificat < 360)
            {
                resultat = $"L'angle {angle} és al quadrant IV.";
            }
            else if (angleModificat == 0 || angleModificat == 90 || angleModificat == 270 ||
                  angleModificat == 360)
            {
                resultat = $"L'angle {angle} és sobre un eix.";
            }
            else
            {
                resultat = "L'angle ha d'estar entre -360 i 360.";
            }

            return resultat;
        }
    }
}
