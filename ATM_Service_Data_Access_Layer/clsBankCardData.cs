using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
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

        public static bool GetCardByCardNumber(int CardNumber, ref int CardID, ref int AccountNumber, ref int PinCode, ref bool ActivationStatus, ref DateTime CreationDate)
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

        public static bool GetCardByCardID(int CradID, ref int CardNumber, ref int AccountNumber, ref int PinCode, ref bool ActivationStatus, ref DateTime CreationDate)
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

        public static bool ChangeActivationStatus(int CardID, bool ActiveStatus)
        {
            bool IsPerformed = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Update BankCard SET ActivationStatus = @ActiveStatus WHERE CardID = @CardID";

            SqlCommand command = new SqlCommand(Query, connection);

            if (ActiveStatus)
                command.Parameters.AddWithValue("@ActiveStatus", 1);
            else
                command.Parameters.AddWithValue("@ActiveStatus", 0);

            command.Parameters.AddWithValue("@CardID", CardID);

            try
            {
                connection.Open();

                int affectedRows = command.ExecuteNonQuery();

                IsPerformed = (affectedRows == 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return IsPerformed;
        }

        public static bool ChangeCodePin(int CardID, int NewCodePin)
        {
            bool IsPerformed = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Update BankCard SET PINCODE = @PINCODE Where CardID = @CardID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CardID", CardID);
            command.Parameters.AddWithValue("@PinCode", NewCodePin);

            try
            {
                connection.Open();

                int AffectedRwos = command.ExecuteNonQuery();

                IsPerformed = (AffectedRwos == 1);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return IsPerformed;
        }

        public static int CreateBankCardinDataBase(int CardNumber, DateTime CreationDate, bool ActivationStatus, int PinCode, int AccountNumber)
        {
            int ID = -1;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "Insert Into BankCard (CardNumber, AccountNumber, CreationDate, PinCode, ActivationStatus) " +
                " Values (@CardNumber, @AccountNumber, @CreationDate, @PinCode, @ActivationStatus);";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Cardnumber", CardNumber);
            command.Parameters.AddWithValue("@PinCode", PinCode);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@CreationDate", CreationDate);

            if (ActivationStatus)
                command.Parameters.AddWithValue("@ActivationStatus", 1);
            else
                command.Parameters.AddWithValue("@ActivationStatus", 0);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();

                if (result != null && int.TryParse(result.ToString(), out int intResult))
                    ID = intResult;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex);
            }
            finally
            {
                connection.Close();
            }

            return ID;
        }

        public static DataTable GetDesactivatedCards()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string Query = "SELECT * From BankCard Where ActivationStatus = 1";

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

    }
}
