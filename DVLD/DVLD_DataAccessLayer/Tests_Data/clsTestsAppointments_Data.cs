using System;
using System.Data.SqlClient;


namespace DVLD_DataAccessLayer.Tests_Data
{
    internal class clsTestsAppointments_Data
    {
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
                       (<TestTypeID, int,>
                       ,<LocalDrivingLicenseApplicationID, int,>
                       ,<AppointmentDate, smalldatetime,>
                       ,<PaidFees, smallmoney,>
                       ,<CreatedByUserID, int,>
                       ,<IsLocked, bit,>)
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



        public static bool UpdateTestAppointment(int TestAppointmentID, DateTime AppointmentDate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"UPDATE TestAppointments 
                    set AppointmentDate = @AppointmentDate where TestAppointmentID = @TestAppointmentID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);

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



    }
}
