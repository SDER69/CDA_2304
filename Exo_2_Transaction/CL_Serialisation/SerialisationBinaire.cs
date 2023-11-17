using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using CL_Transaction;

namespace CL_Serialisation
{
    static public class SerialisationBinaire
    {
       const string PATH = "data.dat";

        public static void Serialiser(Transaction transaction)
        {
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+ "\\" + PATH, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fs,transaction);
            fs.Close();
        }

        public static Transaction Deserialiser()
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream fs = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + PATH, FileMode.Open);
            return (Transaction)formatter.Deserialize(fs);   
        }

    }
}