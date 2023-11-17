using CL_Transaction;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace CL_Serialisation
{
    static public class SerialisationJson
    {
        const string fileName = @"data.json";
        public static void Serialiser(Transaction transaction)
        {
            string pathComplete = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);
            
            string transactionFormatJson = JsonSerializer.Serialize(transaction);

            File.WriteAllText(pathComplete, transactionFormatJson);
           
        }

        public static Transaction? Deserialiser()
        {
            string pathComplete = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            string transactionFormatJson= File.ReadAllText(pathComplete);

            Transaction? transactionDeserialisee =JsonSerializer.Deserialize<Transaction?>(transactionFormatJson);

            return transactionDeserialisee;
        }
    }
}
