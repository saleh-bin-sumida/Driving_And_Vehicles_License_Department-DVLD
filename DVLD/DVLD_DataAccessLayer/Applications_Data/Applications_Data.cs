using System;
using System.Data;
using System.Data.SqlClient;
using System.Xml.Serialization;

namespace DVLD_DataAccessLayer
{
    public static class clsApplications_Data
    {
        public static int AddApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            int ApplicationStatus, DateTime LastStatusDate,decimal PaidFees,int CreatedByUserID)
        {
            int ApplicationID = -1;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[Applications]
                           ([ApplicantPersonID]
                           ,[ApplicationDate]
                           ,[ApplicationTypeID]
                           ,[ApplicationStatus]
                           ,[LastStatusDate]
                           ,[PaidFees]
                           ,[CreatedByUserID])
                     VALUES
                           (@ApplicantPersonID
                           ,@ApplicationDate
                           ,@ApplicationTypeID
                           ,@ApplicationStatus
                           ,@LastStatusDate
                           ,@PaidFees
                           ,@CreatedByUserID)
                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();



                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
                }
            }

            catch (Exception)
            {

            }

            finally
            {
                connection.Close();
            }


            return ApplicationID;
        }



        public static bool UpdateApplication(int ApplicationID, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID,
            int ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[Applications]
                           SET [ApplicantPersonID] = @ApplicantPersonID
                              ,[ApplicationDate] = @ApplicationDate
                              ,[ApplicationTypeID] = @ApplicationTypeID
                              ,[ApplicationStatus] = @ApplicationStatus
                              ,[LastStatusDate] = @LastStatusDate
                              ,[PaidFees] = @PaidFees
                              ,[CreatedByUserID] = @CreatedByUserID
                         WHERE ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);




    


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


        public static bool DeleteApplication(int ApplicationID)
        {

            int rowsAffected = 0;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"delete from Applications where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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



        public static bool GetApplicationInfoByID( int ApplicationID,
        ref int ApplicantPersonID,ref  DateTime ApplicationDate,ref int ApplicationTypeID,
        ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)
        {

            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from Applications
                        where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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



        public static bool ApplicationLikedWithLicense(int ApplicationID)
        {

            bool isFound = false;




            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select found =1 from Licenses where ApplicationID = @ApplicationID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null) { isFound = true; }

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


        public static string GetApplicationStatus(int ApplicationID)
        {

            string ApplicationStatus = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select  case
					when Applications.ApplicationStatus = 1 then 'New'
					when Applications.ApplicationStatus = 2 then 'Canceled'
					when Applications.ApplicationStatus = 3 then 'Completed'
					end as 
					[Status] from Applications where ApplicationID = @ApplicationID";

            SqlCommand command = new SqlCommand(@query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    ApplicationStatus = result.ToString();
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ApplicationStatus;
        }


        public static string GetApplicantName(int PersonID)
        {

            string ApplicantName = "";

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select  [Full Name] = People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName
                            from People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(@query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    ApplicantName = result.ToString();
                }

            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return ApplicantName;
        }



    }
}
