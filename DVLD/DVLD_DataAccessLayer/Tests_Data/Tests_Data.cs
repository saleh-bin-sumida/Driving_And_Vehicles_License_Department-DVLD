using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public static class clsTests_Data
    {
        public static int AddTestAppointment( int TestAppointmentID, bool TestResult,
        string Notes, int CreatedByUserID)
        {
            int TestID = -1;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[Tests]
                       ([TestAppointmentID]
                       ,[TestResult]
                       ,[Notes]
                       ,[CreatedByUserID])
                 VALUES
                       (@TestAppointmentID
                       ,@TestResult
                       ,@Notes
                       ,@CreatedByUserID)
                    SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();



                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    TestID = insertedID;
                }
            }

            catch (Exception)
            {

            }

            finally
            {
                connection.Close();
            }


            return TestID;
        }



    }
}
