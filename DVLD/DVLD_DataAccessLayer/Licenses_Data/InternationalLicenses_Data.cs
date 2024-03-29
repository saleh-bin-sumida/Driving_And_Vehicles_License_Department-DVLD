﻿using System;
using System.Data.SqlClient;


namespace DVLD_DataAccessLayer.Licenses_Data
{
    public class clsInternationalLicenses_Data
    {
        public static bool GetIntLicenseInfoByID(int InternationalLicenseID, ref int LocalLicenseID, ref int ApplicationID,
        ref int DriverID, ref int CreatedByUserID,
        ref DateTime IssueDate, ref DateTime ExpirationDate,
        ref bool IsActive)
        {

            bool isFound = false;



            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select * from InternationalLicenses where InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID", InternationalLicenseID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    DriverID = (int)reader["DriverID"];
                    LocalLicenseID = (int)reader["IssuedUsingLocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsActive = (bool)reader["IsActive"];



                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally
            {
                connection.Close();
            }

            return isFound;
        }



        public static int AddNewIntLicense(int ApplicationID, int DriverID, int LocalLicenseID,
            DateTime IssueDate, DateTime ExpirationDate, bool IsActive,int CreatedByUserID)
        {

            int intLicenseID = -1;


            SqlConnection connection = new SqlConnection(General.ConnectionString);


            string query = @"INSERT INTO [dbo].[InternationalLicenses]
                           ([ApplicationID]
                           ,[DriverID]
                           ,[IssuedUsingLocalLicenseID]
                           ,[IssueDate]
                           ,[ExpirationDate]
                           ,[IsActive]
                           ,[CreatedByUserID])
                     VALUES
                           (@ApplicationID
                           ,@DriverID
                           ,@IssuedUsingLocalLicenseID
                           ,@IssueDate
                           ,@ExpirationDate
                           ,@IsActive
                           ,@CreatedByUserID)
                    SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@IssuedUsingLocalLicenseID", LocalLicenseID);
            command.Parameters.AddWithValue("@IssueDate", IssueDate);
            command.Parameters.AddWithValue("@ExpirationDate", ExpirationDate);
            command.Parameters.AddWithValue("@IsActive", IsActive);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();



                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    intLicenseID = insertedID;
                }
            }

            catch (Exception e) { General.LogErrorMessage(e.Message); }

            finally
            {
                connection.Close();
            }



            return intLicenseID;
        }


        public static bool DeactivateintLicense(int intLicenseID)
        {

            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"update InternationalLicenses
                    set IsActive = 0 where InternationalLicenseID = @InternationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@InternationalLicenseID ", intLicenseID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }

            finally
            { connection.Close(); }

            return (rowsAffected > 0);
        }


    }
}
