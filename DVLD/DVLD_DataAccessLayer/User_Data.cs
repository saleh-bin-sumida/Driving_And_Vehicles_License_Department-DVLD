using System;
using System.Data;
using System.Data.SqlClient;

namespace DVLD_DataAccessLayer
{
    public static class clsUser_Data
    {

        public static DataTable GetAllUsers()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select UserID, Users.PersonID  , [Full Name] = (People.FirstName +' ' + People.SecondName +' ' + People.ThirdName +' ' + People.LastName) ,Users.Username, IsActive from Users
                            inner join  People on Users.PersonID = People.PersonID;";

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


        public static int AddNewUser(int PersonID, string Username, string Password, bool IsActive)
        {
            Username = Username.Trim();
            Password = Password.Trim();

            //this function will return the new user id if succeeded and -1 if not.
            int UserID = -1;






            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"insert into Users values (@PersonID,@Username,@Password,@IsActive) 
                            select  SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@IsActive", IsActive);



            try
            {
                connection.Open();

                object result = command.ExecuteScalar();



                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    UserID = insertedID;
                }
            }

            catch (Exception e) { General.LogErrorMessage(e.Message); }

            finally
            {
                connection.Close();
            }


            return UserID;
        }


        public static bool UpdateUserInfo(int UserID, int PersonID,string Username,string Password ,bool IsActive)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"Update Users
                            set Password = @Password,
                                Username = @Username,
                                PersonID = @PersonID,
                                IsActive = @IsActive
                            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@IsActive", IsActive);



            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }


        public static bool UpdateUserPassword(int UserID, string Password)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"Update Users
                            set Password = @Password
                            where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);
            command.Parameters.AddWithValue("@Password", Password);


            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static bool DeleteUser(int UserID)
        {

            int rowsAffected = 0;



            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"delete from Users where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally
            {

                connection.Close();

            }

            return (rowsAffected > 0);

        }


        public static bool GetUserByUsernameAndPassword( string Username, string Password, ref int UserID, ref int PersonID, ref bool IsActive)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select * from Users
                           where Username = @Username and Password = @Password";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);



            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = (int)reader["UserID"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];
                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool GetUserByID(int UserID, ref string Username, ref string Password, ref int PersonID, ref bool IsActive)
        {

            bool isFound = false;

            SqlConnection connection = new SqlConnection(General.ConnectionString);
            
            string query = @"select * from Users
                           where UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserID", UserID);


            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    Username = (string)reader["Username"];
                    Password = (string)reader["Password"];
                    PersonID = (int)reader["PersonID"];
                    IsActive = (bool)reader["IsActive"];
                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static string GetUserFullNameByID(int UserId)
        {
            string UserFullName = "";

            SqlConnection connection = new SqlConnection(General.ConnectionString);
            string query = @"select People.FirstName +' ' + People.SecondName +' ' +  People.ThirdName +' ' + People.LastName
                        from Users inner join People on Users.PersonID = People.PersonID
                        where Users.UserID = @UserID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@UserId", UserId);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    UserFullName = result.ToString();
                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally { connection.Close(); }
            return UserFullName;
        }




    }
}
