using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CL_VerifTransaction
{
    static public class VerifTransaction
    {
        public static Boolean VerifNom(string nom)
        {
            //Regex controleNom = new Regex(@"^[A-Z]([a-z])+(-[A-Z]([a-z])+)*$");// regex qui accepte les tirets dans les noms composés
            Regex controleNom = new Regex(@"^[A-Z]([a-z])+(\-[A-Z]([a-z])+|\s[A-Z]([a-z])+)*$");// regex qui accepte les tirets et les espaces dans les noms composés
            return controleNom.IsMatch(nom);
        }

        public static Boolean VerifDateFormat(string date)
        {
            bool valideDateGlobale = false;
            //valideDate = Regex.IsMatch(date, "^[0-9]{2}/[0-9]{2}/[0-9]{4}$");

            DateTime date1;
            CultureInfo cultureFR = CultureInfo.GetCultureInfo("fr-fr");
            //DateTimeFormatInfo di = cultureFR.DateTimeFormat;

            bool valideDate = DateTime.TryParseExact(date, "dd/MM/yyyy", cultureFR, DateTimeStyles.None, out date1);

            valideDateGlobale = valideDate;

            return valideDateGlobale;
        }

        public static Boolean VerifDateSuperieure(string date)
        {
            bool valideDateGlobale = false;

            DateTime date1;
            CultureInfo cultureFR = CultureInfo.GetCultureInfo("fr-fr");

            bool valideDate = DateTime.TryParseExact(date, "dd/MM/yyyy", cultureFR, DateTimeStyles.None, out date1);

            valideDateGlobale = date1 > DateTime.Now;

            return valideDateGlobale;
        }

        public static Boolean VerifMontant(string montant,out double montantConverti)
        {
            montantConverti = 0;
            //Regex controleMontant = new Regex(@"^[0-9]+(\.[0-9]{2})?$");//regex acceptant uniquement les points
            Regex controleMontant = new Regex(@"^[0-9]+(((\.[0-9]{2})|(\,[0-9]{2})))*$");//regex acceptant les points et le virgules
            // "^[0-9]+((\,|\.)[0-9]{2})?$"
            Boolean ok= controleMontant.IsMatch(montant);
            if (ok)
            {             
                montant=montant.Replace('.',char.Parse(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator));
                montant=montant.Replace(',', char.Parse(CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator));
                montantConverti = Double.Parse(montant);
            }
            return ok;
        }

        public static Boolean VerifCodePostal(string codePostal)
        {
            Regex controleCodePostal = new Regex("^[0-9]{5}$");
            return controleCodePostal.IsMatch(codePostal);
        }








    }
}


