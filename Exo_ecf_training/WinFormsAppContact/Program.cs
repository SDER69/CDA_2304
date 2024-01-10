using CL_Contact;
using CL_Serialisation;
using System.Transactions;

namespace WinFormsAppContact
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

            List<Contact> listContacts = new List<Contact>();

            FormContact creationFormulaire = new FormContact();
            DialogResult r = creationFormulaire.ShowDialog();
            if (r == DialogResult.OK)
            {
                listContacts.Add(creationFormulaire.Contact);

                //Serialisation json
                /*SerialisationJson.Serialiser(listContacts[0]);
                Contact? t2 = SerialisationJson.Deserialiser();
                listContacts.Add(t2);
               */
                //FormContact editionFormulaire = new FormContact();
                //Application.Run(editionFormulaire);
            }
        }
    }
}