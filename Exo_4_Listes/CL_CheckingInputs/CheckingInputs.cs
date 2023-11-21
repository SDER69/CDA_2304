using System.Text.RegularExpressions;

namespace CL_CheckingInputs
{
    static public class CheckingInputs
    {
        public static Boolean CheckNegativeNumber(int number)
        {
            bool result = number < 0 ? true : false;
            return result;
            
        }

        public static Boolean CheckString (string str)
        {
            Regex checkIndexElement = new Regex("^[0-9]$");
            return checkIndexElement.IsMatch(str); 
        }

        public static Boolean CheckNumber (string str)
        {
            int numericValue;
            bool isNumber = int.TryParse(str, out numericValue);
            return isNumber;
        }

    }
}