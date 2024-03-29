﻿

using System.Data.SqlClient;
using System.Data;
using System;

namespace DVLD_DataAccessLayer.Tests_Data
{
    public static class clsTestTypes_Data
    {
        public static DataTable GetAllTestTypes()
        {

            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"select ID = TestTypeID, [Test Title] = TestTypeTitle, [Test Description] = TestTypeDescription , Fees = TestTypeFees   
                            from TestTypes;";

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

        public static void GetTestTypeInfo(int TestTypeID, ref string TestTypeTitle, ref string TestTypeDescription, ref decimal TestTypeFees)
        {

            SqlConnection connection = new SqlConnection(General.ConnectionString);
            string query = @"select * from TestTypes where TestTypeID = @TestTypeID;";

            SqlCommand cmd = new SqlCommand(query, connection);

            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    TestTypeTitle = (string)reader["TestTypeTitle"];
                    TestTypeDescription = (string)reader["TestTypeDescription"];
                    TestTypeFees = (decimal)reader["TestTypeFees"];

                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally { connection.Close(); }
        }

        public static bool UpdateTestType(int TestTypeID, string TestTypeTitle, string TestTypeDescription, decimal TestTypeFees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(General.ConnectionString);

            string query = @"update TestTypes
                        set TestTypeTitle = @TestTypeTitle,
                            TestTypeFees =@TestTypeFees,
                            TestTypeDescription = @TestTypeDescription 
                            where TestTypeID =@TestTypeID;";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@TestTypeFees", TestTypeFees);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTypeTitle);
            command.Parameters.AddWithValue("@TestTypeDescription", TestTypeDescription);



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


        public static decimal GetTestTypeFees(int TestTypeID)
        {
            decimal Fees = 0;

            SqlConnection connection = new SqlConnection(General.ConnectionString);
            string query = @"select TestTypeFees from TestTypes where TestTypeID = @TestTypeID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null && decimal.TryParse(result.ToString(), out Fees))
                {
                    connection.Close();
                    return Fees;
                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally { connection.Close(); }
            return Fees;
        }

        public static string GetTestTypeName(int TestTypeID)
        {
            string TestTypeTitle = "";

            SqlConnection connection = new SqlConnection(General.ConnectionString);
            string query = @"select TestTypeTitle from TestTypes where TestTypeID = @TestTypeID ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    TestTypeTitle = (string)result;
                }

            }
            catch (Exception e) { General.LogErrorMessage(e.Message); }
            finally { connection.Close(); }
            return TestTypeTitle;
        }

    }
}
