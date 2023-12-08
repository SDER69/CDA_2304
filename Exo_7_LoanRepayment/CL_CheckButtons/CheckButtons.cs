namespace CL_CheckButtons
{
    using System.Diagnostics.Eventing.Reader;
    using System.Text.RegularExpressions;

        static public class CheckButtons
        {
            public static Boolean CheckName(string name)
            {
                Regex validName = new Regex(@"^([A-Z]|[a-z])+(\-([A-Z]|[a-z])+|\s([A-Z]|[a-z])+)*$");// regex qui accepte les tirets et les espaces dans les noms composés
                return validName.IsMatch(name);
            }

            public static Boolean CheckNumbers(string numbers)
            {
                Regex validNumbers = new Regex(@"[0-9]$"); 
                return validNumbers.IsMatch(numbers);
            }





    }

    }

