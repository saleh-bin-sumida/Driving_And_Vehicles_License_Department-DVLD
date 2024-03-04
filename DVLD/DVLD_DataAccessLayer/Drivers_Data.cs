using System;
using System.Data.SqlClient;


namespace DVLD_DataAccessLayer
{
    public class Drivers_Data
    {
        public static int AddNewDriver(int PersonID,int CreatedByUserID, DateTime CreatedDate)
        {
        
            //this function will return the new user id if succeeded and -1 if not.
            int DriverID = -1;






            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"INSERT INTO [dbo].[Drivers]
                       ([PersonID]
                       ,[CreatedByUserID]
                       ,[CreatedDate])
                 VALUES
                       (@PersonID
                       ,@CreatedByUserID
                       ,@CreatedDate)
                        select  SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();



                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    DriverID = insertedID;
                }
            }

            catch (Exception)
            {

            }

            finally
            {
                connection.Close();
            }


            return DriverID;
        }
    }
}
