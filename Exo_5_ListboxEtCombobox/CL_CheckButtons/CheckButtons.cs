using System.Diagnostics.Eventing.Reader;
using System.Text.RegularExpressions;

namespace CL_CheckButtons
{
     static public class CheckButtons
    {
        public static Boolean ComboboxIsEmpty(ComboBox box)
        {
            bool boxIsEmpty = box.Items.Count == 0;
            return boxIsEmpty; 
        }

        public static Boolean ListboxIsEmpty(ListBox box)
        {
            bool boxIsEmpty = box.Items.Count == 0;
            return boxIsEmpty;
        }

        public static Boolean CheckCountryName(string countryName)
        {
            //Regex controleNom = new Regex(@"^[A-Z]([a-z])+(-[A-Z]([a-z])+)*$");// regex qui accepte les tirets dans les noms composés
            Regex validCountry = new Regex(@"^[A-Z]([a-z])+(\-[A-Z]([a-z])+|\s[A-Z]([a-z])+)*$");// regex qui accepte les tirets et les espaces dans les noms composés
            return validCountry.IsMatch(countryName);
        }

        /*public static Boolean CheckDuplicate(string countryName,ComboBox box)
        {
            foreach (string item in box.Items)
            {
                bool duplicate = item.Equals(countryName, StringComparison.InvariantCultureIgnoreCase);
                return duplicate;
               
              
            }*/
        }

    }
