using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Domain
{
    public class PersistancePersonne
    {
        public int Insert(Personne p)
        {
                int nb;
                string connectionString = ConfigurationManager.ConnectionStrings["BdPersonne"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand sqlCde = new SqlCommand("InsertPersonne", connection);
                    // Paramétrage de la commande
                    sqlCde.CommandType = CommandType.StoredProcedure;

                    SqlParameter pId = new SqlParameter("@id", SqlDbType.Int);
                    SqlParameter p1 = new SqlParameter("@nom", SqlDbType.VarChar);
                    SqlParameter p2 = new SqlParameter("@prenom", SqlDbType.VarChar);
                    SqlParameter p3 = new SqlParameter("@age", SqlDbType.Int);
                    pId.IsNullable = false;
                    p1.IsNullable = false;
                    p2.IsNullable = false;
                    p3.IsNullable = false;
                    pId.Direction = ParameterDirection.Output;
                    p1.Direction = ParameterDirection.Input;
                    p2.Direction = ParameterDirection.Input;
                    p3.Direction = ParameterDirection.Input;
                    p1.Value = p.Nom;
                    p2.Value = p.Prenom;
                    p3.Value = p.Age;
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
        }
    }

