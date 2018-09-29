using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using SourceDAL.Model;

namespace SourceDAL.Repository
{
    public class SourceRepository
    {
        public List<SourceProporties> SourceGetDetails()
        {
            List<SourceProporties> source = new List<SourceProporties>();

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ("Data Source=ACUPC-0906;Initial Catalog=NotificationHub;Integrated Security=True");
                connection.Open();

                string sql = "select * from Source";


                SqlCommand command = new SqlCommand(sql, connection);

                using (SqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        SourceProporties sp = new SourceProporties()
                        {
                            SourceId = Convert.ToInt32(dr["Id"]),
                            SourceName = dr["Name"].ToString()
                        };
                        source.Add(sp);
                        
                    }

                }

            }
            return source;
        }


        public void InsertSources(string SName)
        {

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ("Data Source=ACUPC-0906;Initial Catalog=NotificationHub;Integrated Security=True");
                connection.Open();

                SqlCommand command = new SqlCommand("insert into Source(Name) values('" + SName + "')", connection);
                command.ExecuteNonQuery();

            }

        }



        public void DeleteSources(int Id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = ("Data Source=ACUPC-0906;Initial Catalog=NotificationHub;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("Proc_DeleteSource",connection);   
                
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@SourceId",Id);
                command.ExecuteNonQuery();
               

            }

        }

        public void EditSources(string SName)
        {
            using (SqlConnection connection= new SqlConnection())
            {
                connection.ConnectionString = ("Data Source=ACUPC-0906;Initial Catalog=NotificationHub;Integrated Security=True");
                connection.Open();
                SqlCommand command = new SqlCommand("update Source set ", connection);
                command.ExecuteNonQuery();

            }
        }
    }
}
