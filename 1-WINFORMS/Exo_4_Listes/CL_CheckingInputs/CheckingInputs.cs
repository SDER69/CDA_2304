using System.Text.RegularExpressions;

namespace CL_CheckingInputs
{
    static public class CheckingInputs
    {
       /* public static Boolean CheckNegativeNumber(int number)
        {
            bool result = number < 0 ? true : false;
            return result;
            
        }*/

        public static Boolean CheckValidNumber (string number)
        {
            Regex checkIndexElement = new Regex("^[0-9]*$");
            return checkIndexElement.IsMatch(number); 
        }

        /*public static Boolean CheckNumber (string str)
        {
            int numericValue;
            bool isNumber = int.TryParse(str, out numericValue);
            return isNumber;
        }*/

        public static Boolean CheckFirstName(string firstName)
        {
            //Regex controleNom = new Regex(@"^[A-Z]([a-z])+(-[A-Z]([a-z])+)*$");// regex qui accepte les tirets dans les noms composés
            Regex controleNom = new Regex(@"^[A-Z]([a-z])+(\-[A-Z]([a-z])+|\s[A-Z]([a-z])+)*$");// regex qui accepte les tirets et les espaces dans les noms composés
            return controleNom.IsMatch(firstName);
        }   
    }
 }
