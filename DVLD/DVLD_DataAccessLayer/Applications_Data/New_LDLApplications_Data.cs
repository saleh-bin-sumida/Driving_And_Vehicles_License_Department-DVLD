using System;
using System.Data.SqlClient;
using System.Data;

namespace DVLD_DataAccessLayer
{
    public static class cls_NewLDLApplications_Data
    {

        public static DataTable GetAll_NewLDLApplications()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"SELECT 
	                  [LDL app ID] = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID
	                , [Driving Class] = LicenseClasses.ClassName
	                , [National No.] = People.NationalNo
	                , [Full Name] = People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName
	                , [Application Date] = Applications.ApplicationDate
					, case
					when Applications.ApplicationStatus = 1 then 'New'
					when Applications.ApplicationStatus = 2 then 'Canceled'
					when Applications.ApplicationStatus = 3 then 'Completed'
					end as 
					[Status] 
	                ,[Passed Test] = (select count(*) from  
						                ( 
						                select  Tests.TestResult from Tests 
						                inner join TestAppointments on  Tests.TestAppointmentID = TestAppointments.TestAppointmentID
						                where TestAppointments.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplications.LocalDrivingLicenseApplicationID 
						                and Tests.TestResult = 1
						                ) 
						                r1)
                FROM     Applications INNER JOIN
                                  LocalDrivingLicenseApplications ON Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID INNER JOIN
                                  People ON Applications.ApplicantPersonID = People.PersonID INNER JOIN
                                  LicenseClasses ON LocalDrivingLicenseApplications.LicenseClassID = LicenseClasses.LicenseClassID;";

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




        public static int Add_NewLDLApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID ,
            int ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID, int LicenseClassID)
        {

            if (PersonHasValidorCompleted_NewLDLApplication(ApplicantPersonID,LicenseClassID))
                return -1;

            int LDL_ApplicationsID = -1;


            //          to create the application and liked it to the LDLapp;
            int ApplicationID  = clsApplications_Data.AddApplication(ApplicantPersonID, ApplicationDate, ApplicationTypeID,
            ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID);


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);


            string query = @"INSERT INTO [dbo].[LocalDrivingLicenseApplications]
                           ([ApplicationID]
                           ,[LicenseClassID])
                     VALUES
                           (@ApplicationID
                           ,@LicenseClassID)
                    SELECT SCOPE_IDENTITY();";


            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();



                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    LDL_ApplicationsID = insertedID;
                }
            }

            catch (Exception)
            {

            }

            finally
            {
                connection.Close();
            }



            return LDL_ApplicationsID;
        }




        public static bool Update_NewLDLApplication(int LocalDrivingLicenseApplicationID,int ApplicationPesonID, int LicenseClassID)
        {

            int rowsAffected = 0;

            if (PersonHasValidorCompleted_NewLDLApplication(ApplicationPesonID,LicenseClassID))
                return false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE [dbo].[LocalDrivingLicenseApplications]
                           SET [LicenseClassID] = @LicenseClassID
                          WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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



        public static bool Delete_NewLDLApplication(int LocalDrivingLicenseApplicationID)
        {

            int rowsAffected = 0;


            //clsApplicationsData.DeleteApplication(ApplicationID);
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"DELETE FROM [dbo].[LocalDrivingLicenseApplications]
                         WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ";

            SqlCommand queryForApplicationID = new SqlCommand(@"select ApplicationID from LocalDrivingLicenseApplication
            where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID ",connection);
            SqlCommand command1 = new SqlCommand(query, connection);

            command1.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            queryForApplicationID.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);


            try
            {
                connection.Open();
                // deleting the LDL application
                rowsAffected = command1.ExecuteNonQuery();

                // deleting the application
                object obj = queryForApplicationID.ExecuteScalar();
                clsApplications_Data.DeleteApplication(int.Parse(obj.ToString()));

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



        public static bool Get_NewLDLApplicationInfoByID(int LocalDrivingLicenseApplicationID,ref int ApplicationID,
            ref int ApplicantPersonID,ref  DateTime ApplicationDate, ref int ApplicationTypeID,
           ref  short ApplicationStatus,ref  DateTime LastStatusDate,ref  decimal PaidFees, ref int CreatedByUserID, ref int LicenseClassID)
        {

            bool isFound = false;

            clsApplications_Data.GetApplicationInfoByID(ApplicationID,ref ApplicantPersonID,
            ref ApplicationDate,ref ApplicationTypeID,ref ApplicationStatus,ref LastStatusDate,ref PaidFees,ref CreatedByUserID);

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from LocalDrivingLicenseApplications 
                    where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    LicenseClassID = (int)reader["LicenseClassID"];

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


        public static bool PersonHasValidorCompleted_NewLDLApplication(int ApplicantPersonID ,int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
				  select Found = 1 from Applications
				  inner join LocalDrivingLicenseApplications on 
				  Applications.ApplicationID = LocalDrivingLicenseApplications.ApplicationID where ApplicantPersonID = @ApplicantPersonID
				  and Applications.ApplicationTypeID = 1 and LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID 
                  and (Applications.ApplicationStatus =1 or Applications.ApplicationStatus =3)";

            SqlCommand command = new SqlCommand(@query, connection);

            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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
            finally { connection.Close(); }

            return isFound;
        }


    }
}
