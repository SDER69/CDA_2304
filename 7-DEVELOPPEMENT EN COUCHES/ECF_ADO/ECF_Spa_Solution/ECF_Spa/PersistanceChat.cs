using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ECF_Spa
{
    public class PersistanceChat
    {
        public int Insert(Chat c)
        {
            int nb;
            string connectionString = ConfigurationManager.ConnectionStrings["BdChat"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCde = new SqlCommand("InsertChat", connection);
                // Paramétrage de la commande
                sqlCde.CommandType = CommandType.StoredProcedure;

                SqlParameter pNumPuce = new SqlParameter("@numero_puce", SqlDbType.Int);
                SqlParameter p1 = new SqlParameter("@nom", SqlDbType.VarChar);
                SqlParameter p2 = new SqlParameter("@age", SqlDbType.Int);
                SqlParameter p3 = new SqlParameter("@race", SqlDbType.VarChar);

                pNumPuce.IsNullable = false;
                p1.IsNullable = false;
                p2.IsNullable = false;
                p3.IsNullable = false;

                pNumPuce.Direction = ParameterDirection.Input;
                p1.Direction = ParameterDirection.Input;
                p2.Direction = ParameterDirection.Input;
                p3.Direction = ParameterDirection.Input;

                pNumPuce.Value = c.Numero_puce;
                p1.Value = c.Nom;
                p2.Value = c.Age;
                p3.Value = c.Race;
                sqlCde.Parameters.Add(pNumPuce);
                sqlCde.Parameters.Add(p1);
                sqlCde.Parameters.Add(p2);
                sqlCde.Parameters.Add(p3);
                sqlCde.ExecuteNonQuery();
                // récup paramètre de sortie 

                nb = (int)sqlCde.Parameters["@Numero_Puce"].Value;
            }
            return nb;
        }

    }
}
