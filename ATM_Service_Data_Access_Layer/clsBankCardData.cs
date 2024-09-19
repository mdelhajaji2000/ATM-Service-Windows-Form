using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Service_Data_Access_Layer
{
    public static class clsBankCardData
    {
        public static DataTable GetAllCards()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * From BankCard";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                    dt.Load(reader);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return dt;  
        }

        public static bool GetCardByCardNumber(int CardNumber, ref int CardID, ref int AccountNumber, ref bool ActivationStatus, ref DateTime CreationDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM BankCard WHERE CardNumber = @CardNumber";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CardNumber", CardNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CardID = (int)reader["CardID"];
                    AccountNumber = (int)reader["AccountNumber"];
                    ActivationStatus = reader.GetBoolean(reader.GetOrdinal("ActivationStatus"));
                    CreationDate = (DateTime)reader["CreationDate"];

                    IsFound = true;
                }
                else
                    IsFound = false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static DataTable GetAllCardsForASpecificAccount(int AccountNumber)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM BankCard WHERE AccountNumber = @AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

        public static bool GetCardByCardID(int CradID, ref int CardNumber, ref int AccountNumber, ref bool ActivationStatus, ref DateTime CreationDate)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * FROM BankCard WHERE CardID = @CardID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CardID", CradID);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    CardNumber = (int)reader["CardNumber"];
                    AccountNumber = (int)reader["AccountNumber"];
                    ActivationStatus = reader.GetBoolean(reader.GetOrdinal("ActivationStatus"));
                    CreationDate = (DateTime)reader["CreationDate"];

                    IsFound = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
    }
}
