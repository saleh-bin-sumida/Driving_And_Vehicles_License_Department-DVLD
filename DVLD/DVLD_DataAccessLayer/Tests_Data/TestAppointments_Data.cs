using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccessLayer.Tests_Data
{
    public class clsTestsAppointments_Data
    {
        public static DataTable GetAllTestAppointments(int LocalDrivingLicenseApplicationID, int TestTypeID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select TestAppointmentID as [AppointmentID], 
            AppointmentDate as [Appointment Date],
            PaidFees as [Paid Fees],
            IsLocked as [Is Locked] from TestAppointments where 
            LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID and TestTypeID = @TestTypeID ";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                else { dt = null; }

                reader.Close();


            }

            catch (Exception)
            {
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }




        public static bool GetTestAppointmentInfoByID(int TestAppointmentID, ref int LDLAppID,ref int TestTypeID,
            ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID, ref bool isLocked)
        {

            bool isFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"select * from TestAppointments where TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;
                    LDLAppID = (int)reader["LocalDrivingLicenseApplicationID"];
                    TestTypeID = (int)reader["TestTypeID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    isLocked = (bool)reader["isLocked"];
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




        public static int AddTestAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID, DateTime AppointmentDate,
        decimal PaidFees, bool IsLocked, int CreatedByUserID)
        {
            int TestAppointmentID = -1;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[TestAppointments]
                       ([TestTypeID]
                       ,[LocalDrivingLicenseApplicationID]
                       ,[AppointmentDate]
                       ,[PaidFees]
                       ,[CreatedByUserID]
                       ,[IsLocked])
                 VALUES
                       (@TestTypeID
                       ,@LocalDrivingLicenseApplicationID
                       ,@AppointmentDate
                       ,@PaidFees
                       ,@CreatedByUserID
                       ,@IsLocked)
                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();



                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestAppointmentID = insertedID;
                }
            }

            catch (Exception)
            {

            }

            finally
            {
                connection.Close();
            }


            return TestAppointmentID;
        }



        public static bool UpdateTestAppointment(int TestAppointmentID, DateTime AppointmentDate,bool IsLocked)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestAppointments 
                    set AppointmentDate = @AppointmentDate,
                    IsLocked = @IsLocked where TestAppointmentID = @TestAppointmentID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);


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


        public static bool AllowedToCreateAppointment(int LocalDrivingLicenseApplicationID, int TestTypeID, ref string ErroMessage)
        {
            bool CreateAppointment = true;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
                    select top 1 TestID, TestAppointments.TestAppointmentID, TestTypeID,LocalDrivingLicenseApplicationID,AppointmentDate,IsLocked,
                    TestResult from Tests right join TestAppointments on Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                    where LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID  and TestTypeID = @TestTypeID
                    order by TestAppointments.AppointmentDate desc  ";

            SqlCommand command = new SqlCommand(@query, connection);

            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {

                    if (!(bool)reader["isLocked"])
                    {
                        ErroMessage = "this application alredy had active appointment, cant apply for more than one appointment for the same app";
                        CreateAppointment = false;


               
                    }

                    if ((bool)reader["TestResult"])
                    {
                        ErroMessage = "This Test aleady Passed, cant be taken again for this application";
                        CreateAppointment = false;
                    }


                }
    
                


            }
            catch (Exception)
            {


            }
            finally { connection.Close(); }

            return CreateAppointment;
        }




    }
}
