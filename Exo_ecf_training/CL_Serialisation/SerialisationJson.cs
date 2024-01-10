using CL_Contact;
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
            public static void Serialiser(Contact contact)
            {
                string pathComplete = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                string contactFormatJson = JsonSerializer.Serialize(contact);

                File.WriteAllText(pathComplete, contactFormatJson);

            }

            public static Contact? Deserialiser()
            {
                string pathComplete = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

                string contactFormatJson = File.ReadAllText(pathComplete);

                Contact? contactDeserialisee = JsonSerializer.Deserialize<Contact?>(contactFormatJson);

                return contactDeserialisee;
            }
        }
    }


