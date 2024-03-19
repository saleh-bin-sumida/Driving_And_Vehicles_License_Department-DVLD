using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccessLayer
{
    public class clsDrivers_Data
    {
        public static DataTable GetAllDrivers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select * from Drivers";

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

            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally
            {
                connection.Close();
            }

            return dt;

        }


        public static DataTable GetLocalLicenses(int DriverID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select [License ID] = LicenseID,
	                [App ID] = ApplicationID,
	                [Class Name] = (select ClassName from LicenseClasses where LicenseClassID = Licenses.LicenseClassID),
	                [Issue Date] = IssueDate,
	                [Expiration Date] = ExpirationDate,
	                [Is Acitve] = IsActive
                from Licenses
                where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

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

            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally
            {
                connection.Close();
            }

            return dt;

        }


        public static DataTable GetInternationalLicenses(int DriverID)
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select [intLicense ID] = InternationalLicenseID,
	                    [App ID] = ApplicationID,
	                    [Local License ID] = IssuedUsingLocalLicenseID,
	                    [Issue Date] = IssueDate,
	                    [Expiration Date] = ExpirationDate,
	                    [Is Acitve] = IsActive
                    from InternationalLicenses
                    where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

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

            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally
            {
                connection.Close();
            }

            return dt;

        }



        public static int AddNewDriver(int PersonID,int CreatedByUserID, DateTime CreatedDate)
        {
        
            //this function will return the new user id if succeeded and -1 if not.
            int DriverID = -1;






            SqlConnection connection = new SqlConnection(General.ConnectionString);

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

            catch (Exception e) { General.LogErrorMessage(e.Message); }

            finally
            {
                connection.Close();
            }


            return DriverID;
        }

        public static int GetDriverID(int PersonID)
        {
            int DriverID = -1;

            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select DriverID from Drivers where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null)
                {
                    DriverID = (int) result;
                }
            }

            catch (Exception e) { General.LogErrorMessage(e.Message); }

            finally  {connection.Close();}

            return DriverID;
        }

        public static bool GetDriverInfoByID(int DriverID,ref int PersonID,ref DateTime CreatedDate, ref int CreatedByUserID)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"SELECT * FROM  Drivers 
                        where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                }
                else
                    isFound = false;

                reader.Close();
            }
            catch (Exception) {isFound = false;}
            finally {connection.Close();}

            return isFound;
        }

        public static bool HasActiveInternationalLicense(int DriverID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select top 1 found = 1 from InternationalLicenses inner join Drivers
                on InternationalLicenses.DriverID = Drivers.DriverID
                where Drivers.DriverID = @DriverID and InternationalLicenses.IsActive = 1
                order by IssueDate desc";

            SqlCommand command = new SqlCommand(@query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    isFound = true;
                }


            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally { connection.Close(); }

            return isFound;
        }


        public static bool HasActiveLocalLicense(int DriverID, int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select found =1 from Licenses where LicenseClassID = @LicenseClassID and IsActive = 1 and DriverID = @DriverID";

            SqlCommand command = new SqlCommand(@query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
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
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally { connection.Close(); }

            return isFound;
        }
    }
}
