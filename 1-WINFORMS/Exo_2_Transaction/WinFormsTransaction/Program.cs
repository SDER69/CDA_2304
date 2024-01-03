using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;
using CL_Transaction;
using CL_Serialisation;
using Transaction = CL_Transaction.Transaction;
using System.Collections.Generic;

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
            DialogResult r = creationFormulaire.ShowDialog();
            if (r == DialogResult.OK)
            {
                listTransactions.Add(creationFormulaire.Transaction);

                // Serialisation binaire
                /*SerialisationBinaire.Serialiser(listTransactions[0]);
                Transaction t1 = SerialisationBinaire.Deserialiser();
                listTransactions.Add(t1);*/

                //Serialisation json
                SerialisationJson.Serialiser(listTransactions[0]);
                Transaction? t2 = SerialisationJson.Deserialiser();
                listTransactions.Add(t2);
                /*FileStream fs = new FileStream("data.dat", FileMode.Create);
                
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fs, listTransactions);
                fs.Close();
                

                FileStream _fs = new FileStream("data.dat", FileMode.Open);
                listTransactions = (List<Transaction>)formatter.Deserialize(_fs);
                */
                FormTransaction editionFormulaire = new FormTransaction(t2);
                Application.Run(editionFormulaire);
            }

           


           






            /*DialogResult r =f.ShowDialog();
            if (r==DialogResult.OK)
            {
                Transaction t = f.Transaction;
            }
            Application.Run(new FormTransaction());*/
        }

    }
}