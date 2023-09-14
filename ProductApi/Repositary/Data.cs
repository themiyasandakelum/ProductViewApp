using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProductApi.Database;
using ProductApi.Models;
using System.Data;

namespace ProductApi.Repositary
{
    public class Data : IData
    {
        private readonly IConfiguration _configuration;

        public string ConnectionString { get; set; }
        public Data(IConfiguration configuration)
        {
            _configuration = configuration;

             ConnectionString = _configuration.GetValue<string>("DefaultConnection");

        }
        public Product SaveBillDetails(Product details)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spt_saveEBillDetails", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@ProductName", details.ProductName);
                cmd.Parameters.AddWithValue("@SKU", details.SKU);
                cmd.Parameters.AddWithValue("@CreatedDate",details.CreatedDate);
                cmd.Parameters.AddWithValue("@RetailPrice", details.RetailPrice);
                cmd.Parameters.AddWithValue("@SalePrice", details.SalePrice);
                cmd.Parameters.AddWithValue("@LowestPrice", details.LowestPrice);

                SqlParameter outputparm = new SqlParameter();
                outputparm.DbType = DbType.Int32;
                outputparm.Direction = ParameterDirection.Output;
                outputparm.ParameterName = "@Id";
                cmd.Parameters.Add(outputparm);
                cmd.ExecuteNonQuery();
                int id = int.Parse(outputparm.Value.ToString());
                details.ProductId = id;
            }

            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return details;
        }


        public List<Product> GetAllProductDetails()
        {
            List<Product> list = new List<Product>();
            SqlConnection con = new SqlConnection(ConnectionString);
            Product details;
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("spt_getAllProductDetails", con);
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.CommandType = CommandType.StoredProcedure;

                while (reader.Read())
                {
                    details = new Product();
                    details.ProductId = int.Parse(reader["id"].ToString());
                    details.ProductName = reader["ProductName"].ToString();
                    details.SKU = reader["SKU"].ToString();
                    details.CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);
                    details.Status = int.Parse(reader["SalePrice"].ToString());
                    details.SalePrice = int.Parse(reader["SalePrice"].ToString());
                    details.RetailPrice = int.Parse(reader["RetailPrice"].ToString());
                    details.LowestPrice = int.Parse(reader["LowestPrice"].ToString());
                    list.Add(details);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return list;
        }
    }
}
