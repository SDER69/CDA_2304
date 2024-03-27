using CL_PDomainPersistance;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace CL_PersistanceSQLServer
{
    public class PersistanceForEgg:IPersistanceForEgg
    {
        public int Insert(StructEgg sEgg)
        {
            int nb;
            string connectionString = ConfigurationManager.ConnectionStrings["BdEggs"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlCde = new SqlCommand("InsertEgg", connection);
                // Paramétrage de la commande
                sqlCde.CommandType = CommandType.StoredProcedure;

                SqlParameter pId = new SqlParameter("@Id", SqlDbType.Int);
                SqlParameter p1 = new SqlParameter("@hauteurEnCms", SqlDbType.Float);
                SqlParameter p2 = new SqlParameter("@largeurEnCms", SqlDbType.Float);
                SqlParameter p3 = new SqlParameter("@typeChocolat", SqlDbType.VarChar);
                pId.IsNullable = false;
                p1.IsNullable = false;
                p2.IsNullable = false;
                p3.IsNullable = false;
                pId.Direction = ParameterDirection.Output;
                p1.Direction = ParameterDirection.Input;
                p2.Direction = ParameterDirection.Input;
                p3.Direction = ParameterDirection.Input;
                p1.Value = sEgg.LargeurEnCms;
                p2.Value = sEgg.HauteurEnCms;
                p3.Value = sEgg.TypeChocolat;
                sqlCde.Parameters.Add(pId);
                sqlCde.Parameters.Add(p1);
                sqlCde.Parameters.Add(p2);
                sqlCde.Parameters.Add(p3);
                sqlCde.ExecuteNonQuery();
                // récup paramètre de sortie 

                nb = (int)sqlCde.Parameters["@Id"].Value;    
            }
            return nb;
        }

        public bool Update(StructEgg sEgg) 
        {
            return true;
        }

        public StructEgg Select(int id)
        {
            StructEgg structEgg = new StructEgg();
            string queryString = "SELECT * FROM dbo.Egg where id=@id";
            string connectionString = ConfigurationManager.ConnectionStrings["BdEggs"].ConnectionString ;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", SqlDbType.Int)).Value=1;
                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        structEgg.Id = (int)reader[0];
                        structEgg.HauteurEnCms = (float)((Double)reader[1]);
                        structEgg.LargeurEnCms = (float)((Double)reader[2]);
                        structEgg.TypeChocolat= (string)reader[3];
                    }
                }
            }
            return structEgg;
        }

        public bool Delete(int id)
        {
            bool ok = false;
            StructEgg structEgg = new StructEgg();
            string queryString = "DELETE FROM dbo.Egg where id=@id";
            string connectionString = ConfigurationManager.ConnectionStrings["BdEggs"].ConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add(new System.Data.SqlClient.SqlParameter("@id", SqlDbType.Int)).Value = 1;
                connection.Open();
                int nbLigneAffecte = command.ExecuteNonQuery();
                if (nbLigneAffecte == 1)
                {
                    ok= true;
                }
               
            }
            return ok;
        }
    }
}