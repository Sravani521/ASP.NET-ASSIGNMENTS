using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL.Repository
{
    public class RepositoryFile
    {
       
        public List<ProductsInformation> GetDetails()
        {
            List<ProductsInformation> products = new List<ProductsInformation>();
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=ACUPC-0906;Initial Catalog=Assignment22sep;Integrated Security=True";
                connection.Open();

                string sql = "select * from ProductsInfo";
                ProductsInformation p;
                SqlCommand cmd = new SqlCommand(sql, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        p = new ProductsInformation
                        {

                            Id = Convert.ToInt32(reader["ProductId"].ToString()),
                            Name = reader["ProductName"].ToString(),
                           Price = Convert.ToDouble(reader["ProductPrice"].ToString()),
                            ImageUrl =  reader["ProductImage"].ToString(),
                            Description = reader["ProductDescription"].ToString()
                        };
                        products.Add(p);
                    }

                }
                connection.Close();
                return products;
            }
            
        }
    }
}
