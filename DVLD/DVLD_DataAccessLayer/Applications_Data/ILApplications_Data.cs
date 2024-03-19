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

            catch (Exception e)
            {
                clsDataAccessSettings.LogError(e.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;

        }




    }
}
