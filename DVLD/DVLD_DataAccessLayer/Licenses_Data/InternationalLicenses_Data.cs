using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLD_DataAccessLayer.Licenses_Data
{
    public class InternationalLicenses_Data
    {
        public static bool GetIntLicenseInfoByID(int InternationalLicenseID, ref int LocalLicenseID, ref int ApplicationID,
        ref int DriverID, ref int CreatedByUserID,
        ref DateTime IssueDate, ref DateTime ExpirationDate,
        ref bool IsActive)
        {

            bool isFound = false;



            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

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
                    LocalLicenseID = (int)reader["LocalLicenseID"];
                    IssueDate = (DateTime)reader["IssueDate"];
                    ExpirationDate = (DateTime)reader["ExpirationDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsActive = (bool)reader["IsActive"];



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

    }
}
