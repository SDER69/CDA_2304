

using CL_Transaction;

namespace WinFormsTransaction
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

            List<Transaction> listTransactions = new List<Transaction>();

            FormTransaction creationFormulaire = new FormTransaction();
            DialogResult r =  creationFormulaire.ShowDialog();
            if (r == DialogResult.OK)
            {
                listTransactions.Add(creationFormulaire.Transaction);
            }


            FormTransaction editionFormulaire = new FormTransaction(listTransactions[0]);
            Application.Run(editionFormulaire);




                    
            /*DialogResult r =f.ShowDialog();
            if (r==DialogResult.OK)
            {
                Transaction t = f.Transaction;
            }
            Application.Run(new FormTransaction());*/
        }
    }
}