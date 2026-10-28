namespace Ex_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Què ha de fer el programa: demanar, per aquest ordre, el nom de l'equip local,
             * els gols de l'equip local, el nom de l'equip visitant i els gols de l'equip visitant.
             * Després, mostrar un missatge que digui qui ha guanyat, o bé que han empatat.
             */

            string nomEquipL = "", nomEquipV = "", resultat = "";
            int golEquipL = 0, golEquipV = 0;

            Console.Write("Equip local: ");
            nomEquipL = Convert.ToString(Console.ReadLine()??"Equip sense nom");

            Console.Write("Gols de l'equip local: ");
            golEquipL = Convert.ToInt32(Console.ReadLine());

            Console.Write("Equip visitant: ");
            nomEquipV = Convert.ToString(Console.ReadLine()??"Equip sense nom");

            Console.Write("Gols de l'equip visitant: ");
            golEquipV = Convert.ToInt32(Console.ReadLine());

            resultat = InformeResultat(nomEquipL, golEquipL, nomEquipV, golEquipV);
            Console.Write($"{resultat}");
        }
        /// <summary>
        /// Informa el resultat del partit.
        /// </summary>
        /// <param name="nomEquipLocal">El nom del equip local</param>
        /// <param name="golsEquipLocal">Els gols del equip local</param>
        /// <param name="nomEquipVisitant">El nom del equip visitant</param>
        /// <param name="golsEquipVisitant">Els gols del equip visitant</param>
        /// <returns></returns>
        static string InformeResultat(string nomEquipLocal, int golsEquipLocal, string
        nomEquipVisitant, int golsEquipVisitant)
        {
            string resultat = "";

            if (golsEquipLocal > golsEquipVisitant)
            {
                resultat = $"{nomEquipLocal} ha guanyat {nomEquipVisitant} per" +
                    $" {golsEquipLocal} a {golsEquipVisitant}";
            }
            else if (golsEquipVisitant > golsEquipLocal)
            {
                resultat = $"{nomEquipVisitant} ha guanyat {nomEquipLocal} per" +
                    $" {golsEquipVisitant} a {golsEquipLocal}";
            }
            else
            {
                resultat = $"{nomEquipLocal} i {nomEquipVisitant} han empatat a {golsEquipLocal}";
            }
            return resultat;
        }
    }
}
