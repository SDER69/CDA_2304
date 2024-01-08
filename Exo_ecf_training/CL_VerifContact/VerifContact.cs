using System.Globalization;
using System.Text.RegularExpressions;

namespace CL_VerifContact
{
    static public class VerifContact
    {
        public static Boolean VerifNom(string nom)
        {
            Regex controleNom = new Regex(@"^[A-Z]([a-z])+(\-[A-Z]([a-z])+\s[A-Z]([a-z])+)*$");
            return controleNom.IsMatch(nom);
        }

        public static Boolean VerifPrenom(string prenom)
        {
            Regex controleNom = new Regex(@"^[A-Z]([a-z])+(\-[A-Z]([a-z])+\s[A-Z]([a-z])+)*$");
            return controleNom.IsMatch(prenom);
        }

        public static Boolean VerifDateFormat(string date)
        {
            bool valideDateGloblale = false;

            DateTime date1;
            CultureInfo cultureFR = CultureInfo.GetCultureInfo("fr-fr");

            bool valideDate = DateTime.TryParseExact(date, "dd/MM/yyyy", cultureFR, DateTimeStyles.None, out date1);

            valideDateGloblale = valideDate;

            return valideDateGloblale;
        }

        public static double VerifDateMajorite(DateTime dateDeNaissance)
        {
            //Date et heure actuelle.
            DateTime DateCourante = DateTime.Now;
            //Création d'un objet datetime
            DateTime DateNaissance = dateDeNaissance;

            TimeSpan ts = DateCourante - DateNaissance;
            Console.WriteLine(ts);
            return  ts.TotalDays; 
        }


   






    }
}