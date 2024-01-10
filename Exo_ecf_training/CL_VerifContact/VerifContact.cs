using System.ComponentModel;
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

        public static int GetAge(DateTime DateDeNaissance)
        {
            // Age théorique
            int age = DateTime.Now.Year - DateDeNaissance.Year;

            // Date de l'anniversaire de cette année
            DateTime DateAnniv =
                  new DateTime(DateTime.Now.Year, DateDeNaissance.Month, DateDeNaissance.Day);

            // Si pas encore passé, retirer 1 an
            if (DateAnniv > DateTime.Now)
                age--;

            return age;
        }

        public static Boolean VerifMajorite(DateTime dateDeNaissance)
        {
            if(GetAge(dateDeNaissance) >= 18)
            {
                return true;
            }
            return false;
        }

        public static Boolean VerifEmail(string email)
        {
            Regex controleEmail = new Regex(@"^[a-z0-9\.]*\@[a-z]*\.[a-z]{2,4}$");
            return controleEmail.IsMatch(email);
        }

        public static Boolean VerifCodePostal(string codePostal)
        {
            Regex controleCodePostal = new Regex("^[0-9]{5}$");
            return controleCodePostal.IsMatch(codePostal);
        }

        public static Boolean VerifTel(string tel)
        {
            Regex controleTel = new Regex(@"^([0-9]*(\.|\s|\-))+[0-9]*$");
            return controleTel.IsMatch(tel);
        }

        








    }
}