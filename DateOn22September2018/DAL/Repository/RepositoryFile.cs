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
                            ImageUrl = reader["ProductImage"].ToString(),
                            Description = reader["ProductDescription"].ToString(),

                        };
                        products.Add(p);
                    }

                }
                connection.Close();
                return products;
            }

        }
        
         public  ProductsInformation GetDetail(int id)
         {
            ProductsInformation pi = new ProductsInformation();
            
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=ACUPC-0906;Initial Catalog=Assignment22sep;Integrated Security=True";
                connection.Open();

                string sql = "select * from ProductsInfo";
               
                SqlCommand cmd = new SqlCommand(sql, connection);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    reader.Read();
                    pi.Id = Convert.ToInt32(reader["ProductId"].ToString());
                    pi.Name = reader["ProductName"].ToString();
                    pi.Price = Convert.ToDouble(reader["ProductPrice"].ToString());
                    pi.ImageUrl = reader["ProductImage"].ToString();
                    pi.Description = reader["ProductDescription"].ToString();

                    return pi;
                        
                }
                    

                            
            }

         }
        public void InsertDetails(string name, string img, double price, string desc, int brandid)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=ACUPC-0906;Initial Catalog=Assignment22sep;Integrated Security=True";
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                cmd = new SqlCommand("Proc_InsertDetails1", connection);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProName", name);
                cmd.Parameters.AddWithValue("@ProImage", img);
                cmd.Parameters.AddWithValue("@ProPrice", price);
                cmd.Parameters.AddWithValue("@ProDescription", desc);
                cmd.Parameters.AddWithValue("@ProBrandId", brandid);
                cmd.Connection = connection;
                cmd.ExecuteNonQuery();
                connection.Close();
            }

        }

        public void DeleteDetails(int id)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=ACUPC-0906;Initial Catalog=Assignment22sep;Integrated Security=True";
                connection.Open();
                SqlCommand cmd = new SqlCommand();

                cmd = new SqlCommand("Proc_Delete", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductId", id);
                cmd.ExecuteNonQuery();

            }
        }


        public void UpdateDetails(int id,string name, string img, double price, string desc, int brandid)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = "Data Source=ACUPC-0906;Initial Catalog=Assignment22sep;Integrated Security=True";
                connection.Open();
                SqlCommand cmd = new SqlCommand();
                cmd = new SqlCommand("Proc_update", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("ProId",id);
                cmd.Parameters.AddWithValue("ProName", name);
                cmd.Parameters.AddWithValue("ProImage", img);
                cmd.Parameters.AddWithValue("ProPrice", price);
                cmd.Parameters.AddWithValue("ProDescription",desc);
                cmd.Parameters.AddWithValue("@ProBrandId", brandid);
                cmd.ExecuteNonQuery();

                connection.Close();



            }
        }
    }
}
