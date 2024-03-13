

using System.Data.SqlClient;
using System;
using System.ComponentModel;
using System.Data;

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
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsActive = (bool)reader["IsActive"];
                    IssueReason = (byte)reader["IssueReason"];
                    PaidFees = (decimal)reader["PaidFees"];


                    if (reader["Notes"] == DBNull.Value)
                        Notes = "";
                    else
                        Notes = (string)reader["Notes"];


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



        public static bool DeactivateLocalLicense(int LocalLicenseID)
        {

            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"update Licenses 
                    set IsActive = 0 where LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID ", LocalLicenseID);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            { }

            finally
            { connection.Close(); }

            return (rowsAffected > 0);
        }


        public static bool IsLicenseDetained(int LicenseID)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found = 1 from DetainedLicenses where IsReleased = 0 and LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    isFound = true;
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


        public static int DetainLicense(int LicenseID, decimal FineFees, int CreatedByUserID)
        {
            int DetainID = -1;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[DetainedLicenses]
                   ([LicenseID]
                   ,[DetainDate]
                   ,[FineFees]
                   ,[CreatedByUserID]
                   ,[IsReleased]
                   ,[ReleaseDate]
                   ,[ReleasedByUserID]
                   ,[ReleaseApplicationID])
             VALUES
                   (@LicenseID
                   ,GETDATE()
                   ,@FineFees
                   ,@CreatedByUserID
                   ,0
                   ,null
                   ,null
                   ,null)
                    select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@FineFees", FineFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);


            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(),out int insetedID))
                {
                    DetainID = insetedID;
                }

            }
            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return DetainID;
        }



        public static bool ReleaseLicense(int DetainID, int ReleasedByUserID, int ReleaseApplicationID)
        {

            int rowsAffected = 0;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"update DetainedLicenses 
                        set IsReleased = 1 ,
                        ReleaseDate = GETDATE(),
                        ReleasedByUserID = @ReleasedByUserID,
                        ReleaseApplicationID = @ReleaseApplicationID 
                        where DetainID = @DetainID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@ReleasedByUserID ", ReleasedByUserID);
            command.Parameters.AddWithValue("@ReleaseApplicationID ", ReleaseApplicationID);



            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception)
            { }

            finally
            { connection.Close(); }

            return (rowsAffected > 0);
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

        public static bool GetLicenseDetainInfo(int LicenseID,ref int DetainID, ref decimal FineFees,ref DateTime DetainDate,
            ref int DetainedBy)
        {
            bool isFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"select top(1) DetainID, FineFees,DetainDate, CreatedByUserID from DetainedLicenses 
                    where LicenseID = @LicenseID
                    order by DetainDate desc;";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    DetainID = (int)reader["DetainID"];
                    FineFees = (decimal)reader["FineFees"];
                    DetainDate = (DateTime)reader["DetainDate"];
                    DetainedBy = (int)reader["CreatedByUserID"];

                }
            }

            catch (Exception) { }

            finally { connection.Close(); }

            return isFound;
        }


        public static DataTable GetAllDetainedLicenses()
        {
           
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
SELECT  
		[D ID] = DetainedLicenses.DetainID,
	    [L.ID] = DetainedLicenses.LicenseID,
	    [D.Date] = DetainedLicenses.DetainDate,
	    [Is Released] = DetainedLicenses.IsReleased,
	    [Fine Fees] = DetainedLicenses.FineFees,
	    [Release Date] =DetainedLicenses.ReleaseDate,
	    [N.No] = People.NationalNo,
	    [Full Name] =  (People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' +  People.LastName),
		[Release App ID] = DetainedLicenses.ReleaseApplicationID

FROM     DetainedLicenses INNER JOIN
                  Licenses ON DetainedLicenses.LicenseID = Licenses.LicenseID INNER JOIN
                  Drivers ON Licenses.DriverID = Drivers.DriverID INNER JOIN
                  People ON Drivers.PersonID = People.PersonID";

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
            finally  {connection.Close();}

            return dt;


        }

    }
}
