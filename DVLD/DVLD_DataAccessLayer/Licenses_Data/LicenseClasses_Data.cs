using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{

    public class clsLicenseClasses_Data
    {

        public static string GetLicenseClassNameByID(int LicenseClassID)
        {
            string LicenseClassName = "";

            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select ClassName from LicenseClasses where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(@query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    LicenseClassName = result.ToString();
                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally { connection.Close(); }

            return LicenseClassName;
        }


        public static byte GetDefaultValidityLength(int LicenseClassID)
        {
            byte DefaultValidityLength = 0;

            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select DefaultValidityLength from LicenseClasses where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(@query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    DefaultValidityLength = (byte)result;
                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally { connection.Close(); }

            return DefaultValidityLength;
        }


        public static decimal GetLicenseClassFees(int LicenseClassID)
        {
            decimal ClassFees = 0;

            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select ClassFees from LicenseClasses where LicenseClassID = @LicenseClassID";

            SqlCommand command = new SqlCommand(@query, connection);

            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    ClassFees = (decimal)result;
                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally { connection.Close(); }

            return ClassFees;
        }


        public static DataTable GetAllLicenseClasses()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select ClassName from LicenseClasses";

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

            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally
            {
                connection.Close();
            }

            return dt;

        }

    }

}
