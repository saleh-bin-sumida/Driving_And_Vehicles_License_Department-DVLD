

using System.Data.SqlClient;
using System;

namespace DVLD_DataAccessLayer
{
    public class clsLocalLicenses_Data
    {

        public static int AddNewLicense( int ApplicationID, int DriverID, int LicenseClassID,
            DateTime IssueDate, DateTime ExpirationDate, string Notes, decimal PaidFees, bool IsActive,
            int IssueReason, int CreatedByUserID)
        {

            int LicenseID = -1;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"INSERT INTO [dbo].[Licenses]
                   ([ApplicationID]
                   ,[DriverID]
                   ,[LicenseClassID]
                   ,[IssueDate]
                   ,[ExpirationDate]
                   ,[Notes]
                   ,[PaidFees]
                   ,[IsActive]
                   ,[IssueReason]
                   ,[CreatedByUserID])
             VALUES
                   (@ApplicationID
                   ,@DriverID
                   ,@LicenseClassID
                   ,@IssueDate
                   ,@ExpirationDate
                   ,@Notes
                   ,@PaidFees
                   ,@IsActive
                   ,@IssueReason
                   ,@CreatedByUserID)
                    SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@IssueReason", IssueReason);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();



                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LicenseID = insertedID;
                }
            }

            catch (Exception)
            {

            }

            finally
            {
                connection.Close();
            }



            return LicenseID;
        }


        public static bool GetLicenseInfoByID(int LicenseID, ref int ApplicationID,
       ref int DriverID, ref int LicenseClassID, ref int CreatedByUserID,
       ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes,
       ref bool IsActive, ref byte IssueReason,ref decimal PaidFees)
        {

            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Licenses
                        where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    Notes = (string)reader["Notes"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    PaidFees = (decimal)reader["PaidFees"];



                }

            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }




        public static bool IsLicenseDetained(int LicenseID)
        {
            return false;
        }


        public static int GetLicenseIDbyLDLappID(int LDLappID)
        {

            int LicenseID = -1;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"select * from Licenses inner join LocalDrivingLicenseApplications
                        on Licenses.ApplicationID = LocalDrivingLicenseApplications.ApplicationID
                        where LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LDLappID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null )
                {
                    LicenseID = (int)result;
                }
            }

            catch (Exception){}

            finally { connection.Close(); } 

            return LicenseID;
        }


    }
}
