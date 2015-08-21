using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Gets data from, and saves to, Products table in Appliance Repairs database
namespace ProductsData
{
    public class ProductDB
    {
        //GET ALL PRODUCT CODES FOR COMBO BOX
        public static List<string> GetProductCodes()
        {
            List<string> productCodes = new List<string>(); //empty list

            SqlConnection connection = AppRepairsDB.GetConnection();

            string selectStatement =
                "SELECT ProductCode " +
                "FROM Products " +
                "ORDER BY ProductCode";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    string productCode = reader["ProductCode"].ToString();
                    productCodes.Add(productCode);
                }
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return productCodes;
        }


        //RETURN ONE PRODUCT BASED ON PRODUCT CODE
        public static Product GetProduct(string productCode)
        {
            Product p = new Product();

            SqlConnection connection = AppRepairsDB.GetConnection();

            string selectStatement =
                "SELECT ProductCode, Name, YearsWarranty, ReleaseDate " +
                "FROM Products " +
                "WHERE ProductCode = @ProductCode " +
                "ORDER BY ProductCode";

            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            selectCommand.Parameters.AddWithValue("@ProductCode", productCode); //assign value to @ProductCode

            try
            {
                connection.Open();
                SqlDataReader reader = selectCommand.ExecuteReader(CommandBehavior.SingleRow);

                if (reader.Read()) //if there was a matching product code
                {
                    p.ProductCode = reader["ProductCode"].ToString();
                    p.ProductName = reader["Name"].ToString();
                    p.YearsWarranty = Convert.ToDecimal(reader["YearsWarranty"]);
                    p.ReleaseDate = (DateTime)reader["ReleaseDate"];
                }
                else
                    p = null; //product does not exist
                reader.Close();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }

            return p;
        }


        //UPDATE PRODUCT DATA
        public static bool UpdateProduct(Product oldProduct, Product newProduct)
        {
            SqlConnection connection = AppRepairsDB.GetConnection();

            string updateStatement =
                "UPDATE Products SET " +
                    "ProductCode = @NewProductCode, " +
                    "Name = @NewName, " +
                    "YearsWarranty = @NewYearsWarranty, " +
                    "ReleaseDate = @NewReleaseDate " +
                "WHERE ProductCode = @OldProductCode " +
                    "AND Name = @OldName " +
                    "AND YearsWarranty = @OldYearsWarranty " +
                    "AND ReleaseDate = @OldReleaseDate";

            SqlCommand updateCommand = new SqlCommand(updateStatement, connection);
            updateCommand.Parameters.AddWithValue("@NewProductCode", newProduct.ProductCode);
            updateCommand.Parameters.AddWithValue("@NewName", newProduct.ProductName);
            updateCommand.Parameters.AddWithValue("@NewYearsWarranty", newProduct.YearsWarranty);
            updateCommand.Parameters.AddWithValue("@NewReleaseDate", newProduct.ReleaseDate);

            updateCommand.Parameters.AddWithValue("@OldProductCode", oldProduct.ProductCode);
            updateCommand.Parameters.AddWithValue("@OldName", oldProduct.ProductName);
            updateCommand.Parameters.AddWithValue("@OldYearsWarranty", oldProduct.YearsWarranty);
            updateCommand.Parameters.AddWithValue("@OldReleaseDate", oldProduct.ReleaseDate);

            try
            {
                connection.Open();
                int count = updateCommand.ExecuteNonQuery();
                if (count > 0) //a row was affected
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }


        //ADD NEW PRODUCT
        public static void AddProduct(Product product)
        {
            SqlConnection connection = AppRepairsDB.GetConnection();

            string insertStatement =
                "INSERT Products (ProductCode, Name, YearsWarranty, ReleaseDate) " +
                "VALUES (@ProductCode, @Name, @YearsWarranty, @ReleaseDate)";

            SqlCommand insertCommand = new SqlCommand(insertStatement, connection);
            insertCommand.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            insertCommand.Parameters.AddWithValue("@Name", product.ProductName);
            insertCommand.Parameters.AddWithValue("@YearsWarranty", product.YearsWarranty);
            insertCommand.Parameters.AddWithValue("@ReleaseDate", product.ReleaseDate);

            try
            {
                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }


        //DELETE PRODUCT
        public static int DeleteProduct(Product product)
        {
            int deleteCount = 0;

            SqlConnection connection = AppRepairsDB.GetConnection();

            string deleteStatement =
                "DELETE FROM Products " +
                "WHERE ProductCode = @ProductCode " +
                    "AND Name = @Name " +
                    "AND YearsWarranty = @YearsWarranty " +
                    "AND ReleaseDate = @ReleaseDate";

            SqlCommand deleteCommand = new SqlCommand(deleteStatement, connection);
            deleteCommand.Parameters.AddWithValue("@ProductCode", product.ProductCode);
            deleteCommand.Parameters.AddWithValue("@Name", product.ProductName);
            deleteCommand.Parameters.AddWithValue("@YearsWarranty", product.YearsWarranty);
            deleteCommand.Parameters.AddWithValue("@ReleaseDate", product.ReleaseDate);


            try
            {
                connection.Open();
                deleteCommand.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
            return deleteCount;
        }
    }//END CLASS
}
