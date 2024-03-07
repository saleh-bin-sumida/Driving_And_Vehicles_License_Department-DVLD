using System;
using System.Data.SqlClient;
using System.Data;


namespace DVLD_DataAccessLayer.Applications_Data
{
    public class clsILApplications_Data
    {
        public static DataTable GetAll_ILApplications()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT [Int License ID] = [InternationalLicenseID]
                          ,[Application ID] = [ApplicationID]
                          ,[Driver ID] = [DriverID]
                          ,[License ID] = [IssuedUsingLocalLicenseID]
                          ,[Issue Date] = [IssueDate]
                          ,[Expiration Date] = [ExpirationDate]
                          ,[IsActive]
                      FROM [dbo].[InternationalLicenses] ";

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




        //public static int Add_NewLDLApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
        //    int ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID, int LicenseClassID)
        //{

        //    if (PersonHasValidorCompleted_NewLDLApplication(ApplicantPersonID, LicenseClassID))
        //        return -1;

        //    int LDL_ApplicationsID = -1;


        //    //          to create the application and liked it to the LDLapp;
        //    int ApplicationID = clsApplications_Data.AddApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID,
        //    ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);


        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


        //    string query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
        //                   ([ApplicationID]
        //                   ,[LicenseClassID])
        //             VALUES
        //                   (@ApplicationID
        //                   ,@LicenseClassID)
        //            SELECT SCOPE_IDENTITY();";


        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
        //    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


        //    try
        //    {
        //        connection.Open();

        //        object result = command.ExecuteScalar();



        //        if (result != null && int.TryParse(result.ToString(), out int insertedID))
        //        {
        //            LDL_ApplicationsID = insertedID;
        //        }
        //    }

        //    catch (Exception)
        //    {

        //    }

        //    finally
        //    {
        //        connection.Close();
        //    }



        //    return LDL_ApplicationsID;
        //}




        //public static bool Update_NewLDLApplication(int LocalDrivingLicenseApplicationID, int ApplicationPesonID, int LicenseClassID)
        //{

        //    int rowsAffected = 0;
        //    // fix bug here

        //    if (PersonHasValidorCompleted_NewLDLApplication(ApplicationPesonID, LicenseClassID))
        //        return false;


        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = @"UPDATE [dbo].[LocalDrivingLicenseApplications]
        //           SET [LicenseClassID] = @LicenseClassID
        //         WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

        //    SqlCommand command = new SqlCommand(query, connection);

        //    command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
        //    command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


        //    try
        //    {
        //        connection.Open();
        //        rowsAffected = command.ExecuteNonQuery();

        //    }
        //    catch (Exception)
        //    {
        //    }

        //    finally
        //    {
        //        connection.Close();
        //    }

        //    return (rowsAffected > 0);
        //}





        //public static bool Delete_NewLDLApplication(int LocalDrivingLicenseApplicationID)
        //{

        //    int rowsAffected = 0;


        //    //clsApplicationsData.DeleteApplication(ApplicationID);
        //    SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

        //    string query = @"declare @appID int
        //    select @appID = ApplicationID from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
        //    delete from LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID
        //    delete from Applications where ApplicationID = @appID; ";

        //    SqlCommand command1 = new SqlCommand(query, connection);

        //    command1.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


        //    try
        //    {
        //        connection.Open();
        //        rowsAffected = command1.ExecuteNonQuery();


        //    }
        //    catch (Exception)
        //    {
        //    }
        //    finally
        //    {

        //        connection.Close();

        //    }

        //    return (rowsAffected > 0);

        //}



    }
}
