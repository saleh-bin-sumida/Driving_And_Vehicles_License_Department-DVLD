using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public static class ApplicationTypes_Data
    {
        public static DataTable GetAllApplicationTypes()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select ID = ApplicationTypeID, [Application Title] = ApplicationTypeTitle, Fees = ApplicationFees 
                            from ApplicationTypes;";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }

                reader.Close();


            }

            catch (Exception)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }

        public static void GetApplicationTypeInfo(int ApplicationTypeID, ref string ApplicationTypeTitle, ref decimal ApplicationFees)
        {

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select * from ApplicationTypes where ApplicationTypeID = @ApplicationTypeID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    ApplicationTypeTitle = (string)reader["ApplicationTypeTitle"];
                    ApplicationFees = (decimal)reader["ApplicationFees"];

                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { connection.Close(); }
        }

        public static bool UpdateApplicationType(int ApplicationTypeID, string ApplicationTypeTitle, decimal ApplicationFees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"update ApplicationTypes
                        set ApplicationTypeTitle = @ApplicationTypeTitle,
                            ApplicationFees =@ApplicationFees
                            where ApplicationTypeID =@ApplicationTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationFees", ApplicationFees);
            command.Parameters.AddWithValue("@ApplicationTypeTitle", ApplicationTypeTitle);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            {
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);

        }

        public static decimal GetApplicationTypeFees(int ApplicationTypeID) 
        {
            decimal Fees = 0;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select ApplicationFees from ApplicationTypes where ApplicationTypeID =@ApplicationTypeID ";

            SqlCommand command = new SqlCommand(query,connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                object result =  command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out Fees))
                {
                    connection.Close();
                    return Fees;
                }

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }
            return Fees;
        }

        public static string GetApplicationTypeName(int ApplicationTypeID)
        {
            string ApplicationTypeTitle = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"select ApplicationTypeTitle from ApplicationTypes where ApplicationTypeID =@ApplicationTypeID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null )
                {
                   ApplicationTypeTitle = (string)result;
                }

            }
            catch (Exception)
            {

            }
            finally { connection.Close(); }
            return ApplicationTypeTitle;
        }


    }
}
