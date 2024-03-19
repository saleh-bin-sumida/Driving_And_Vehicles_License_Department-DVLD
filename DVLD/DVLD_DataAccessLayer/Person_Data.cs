using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLD_DataAccessLayer
{
    public static class clsPerson_Data
    {

        public static DataTable GetAllPersons()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"SELECT People.PersonID, People.NationalNo, People.FirstName, People.SecondName, People.ThirdName, People.LastName, People.Gender, People.DateOfBirth, Countries.CountryName, People.Phone, People.Email
                            FROM     People INNER JOIN
                            Countries ON People.NationalityCountryID = Countries.CountryID";

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


        public static bool GetPersonInfoByID(int PersonID,ref string NationalNo,ref string FirstName,ref string SecondName,ref string ThirdName,
        ref string LastName,ref DateTime DateOfBirth,ref byte Gender,
        ref string Address,ref string Phone,ref string Email,
        ref int NationalityCountryID,ref string ImagePath)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"SELECT * FROM  People 
                        where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    NationalNo =                (string)reader["NationalNo"];
                    FirstName =                 (string)reader["FirstName"];
                    SecondName =                (string)reader["SecondName"];
                    LastName =                  (string)reader["LastName"];
                    DateOfBirth =               (DateTime)reader["DateOfBirth"];
                    Gender =                    (byte)reader["Gender"];
                    Address =                   (string)reader["Address"];
                    Phone =                     (string)reader["Phone"];
                    NationalityCountryID =      (int)reader["NationalityCountryID"];




                    //Email , ImagePath and ThridName: allows null in database so we should handle null


                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ThirdName = "";


                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";


                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception e) { General.LogErrorMessage(e.Message); isFound = false; }
            finally
            {
                connection.Close();
            }

            return isFound;
        }





        public static bool GetPersonInfoByNationalNo(string NationalNo,ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName,
        ref string LastName, ref DateTime DateOfBirth, ref byte Gender,
        ref string Address, ref string Phone, ref string Email,
        ref int NationalityCountryID, ref string ImagePath)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"SELECT * FROM  People 
                        where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // The record was found
                    isFound = true;

                    PersonID = (int)reader["PersonID"];
                    FirstName = (string)reader["FirstName"];
                    SecondName = (string)reader["SecondName"];
                    LastName = (string)reader["LastName"];
                    DateOfBirth = (DateTime)reader["DateOfBirth"];
                    Gender = (byte)reader["Gender"];
                    Address = (string)reader["Address"];
                    Phone = (string)reader["Phone"];
                    NationalityCountryID = (int)reader["NationalityCountryID"];




                    //Email , ImagePath and ThridName: allows null in database so we should handle null


                    if (reader["ThirdName"] != DBNull.Value)
                        ThirdName = (string)reader["ThirdName"];
                    else
                        ThirdName = "";


                    if (reader["Email"] != DBNull.Value)
                        Email = (string)reader["Email"];
                    else
                        Email = "";


                    if (reader["ImagePath"] != DBNull.Value)
                        ImagePath = (string)reader["ImagePath"];
                    else
                        ImagePath = "";

                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

                reader.Close();


            }
            catch (Exception e) { General.LogErrorMessage(e.Message); isFound = false; }
            finally
            {
                connection.Close();
            }

            return isFound;
        }




        public static int AddNewPerson(string NationalNo, string FirstName, string SecondName, string ThirdName,
         string LastName, DateTime DateOfBirth, byte Gender,
         string Address, string Phone, string Email,
         int NationalityCountryID , string ImagePath)
        {
            FirstName = FirstName.Trim();
            SecondName = SecondName.Trim();
            ThirdName = ThirdName.Trim();
            LastName = LastName.Trim();
            Address = Address.Trim();
            Phone = Phone.Trim();
            Email = Email.Trim();
            ImagePath = ImagePath.Trim();
    

            //this function will return the new person id if succeeded and -1 if not.
            int PersonID = -1;



            // check if person already exists return the personID or continue to add a new one
            if (_GetPersonID_ByNationalNo(ref PersonID, NationalNo))
                return PersonID;




            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"insert into People
                        values (@NationalNo,@FirstName,@SecondName,@ThirdName,
                                @LastName,@DateOfBirth,
                                @Gender,@Address,@Phone,
                                @Email,@NationalityCountryID,
                                @ImagePath)
                                select SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);



            if (ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);


            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);


            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();



                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    PersonID = insertedID;
                }
            }

            catch (Exception e) { General.LogErrorMessage(e.Message); }

            finally
            {
                connection.Close();
            }


            return PersonID;
        }


        public static bool UpdatePerson(int PersonID,string NationalNo, string FirstName, string SecondName,
            string ThirdName, string LastName,
            DateTime DateOfBirth, byte Gender,
            string Address, string Phone, string Email,
            int NationalityCountryID, string ImagePath)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"Update  People  
                            set NationalNo = @NationalNo,
                                FirstName = @FirstName,
                                SecondName = @SecondName,
                                ThirdName = @ThirdName,
                                LastName = @LastName,
                                DateOfBirth = @DateOfBirth,
                                Gender = @Gender,
                                Address = @Address,
                                Phone = @Phone, 
                                Email = @Email, 
                             NationalityCountryID = @NationalityCountryID,
                             ImagePath = @ImagePath
                                where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@NationalNo", NationalNo);
            command.Parameters.AddWithValue("@FirstName", FirstName);
            command.Parameters.AddWithValue("@SecondName", SecondName);
            command.Parameters.AddWithValue("@LastName", LastName);
            command.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            command.Parameters.AddWithValue("@Gender", Gender);
            command.Parameters.AddWithValue("@Address", Address);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);



            if (ThirdName != "")
                command.Parameters.AddWithValue("@ThirdName", ThirdName);
            else
                command.Parameters.AddWithValue("@ThirdName", System.DBNull.Value);


            if (Email != "")
                command.Parameters.AddWithValue("@Email", Email);
            else
                command.Parameters.AddWithValue("@Email", System.DBNull.Value);


            if (ImagePath != "")
                command.Parameters.AddWithValue("@ImagePath", ImagePath);
            else
                command.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);



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


        public static bool DeletePerson(int PersonID)
        {

            int rowsAffected = 0;



            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"delete from People where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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


        private static bool _GetPersonID_ByNationalNo(ref int PersonID, string NationalNo)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = "SELECT PersonID FROM People WHERE NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);



            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out PersonID))
                {
                    isFound = true;
                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool IsPersonExists(int PersonID)
        {
            bool isFound = false;


            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"SELECT found=1 FROM  People 
                        where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool IsPersonExists(string NationalNo)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"SELECT found=1 FROM  People 
                        where NationalNo = @NationalNo";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@NationalNo", NationalNo);

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
            finally
            {
                connection.Close();
            }

            return isFound;
        }


        public static bool IsPersonLikedWithUser(int PersonID)
        {
            bool isFound = false;



            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"SELECT found=1 FROM  Users 
                        where PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static string GetPersonFullNameByID(int PersonID)
        {
            string PersonFullName = "";

            SqlConnection connection = new SqlConnection(General.ConnectionString);
            string query = @"select  [Full Name] = People.FirstName + ' ' + People.SecondName + ' ' + People.ThirdName + ' ' + People.LastName
                            from People where PersonID = @PersonID"; 

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    PersonFullName = result.ToString();
                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally { connection.Close(); }
            return PersonFullName;
        }







    }
}
