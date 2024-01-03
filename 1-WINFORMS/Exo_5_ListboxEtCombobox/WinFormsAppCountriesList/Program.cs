using System.Runtime.CompilerServices;
using System.Transactions;

namespace WinFormsAppCountriesList
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            Dictionary<string, bool> countriesUnchecked = new Dictionary<string, bool>
            {
                { "France", false },
                { "Belgique", false },
                { "Allemagne", false },
                { "Japon", false },
                { "Portugal", false },
                { "Grèce", false }
            };
            //FormCountriesList creationForm = new FormCountriesList(countriesUnchecked); With datasource
            FormCountriesList creationForm = new FormCountriesList(); //Without datasource
            //DialogResult r = creationForm.ShowDialog();
            Application.Run(creationForm);

            Dictionary<string, bool> editionCountries = creationForm.Countries;
            FormCountriesList editionForm = new FormCountriesList(editionCountries);

            Application.Run(editionForm);

            //Application.Run(new FormCountriesList());

        }
    }
}