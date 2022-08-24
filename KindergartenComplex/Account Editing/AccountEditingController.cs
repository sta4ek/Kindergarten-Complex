using System;
using System.Data;
using System.Data.SqlClient;

namespace KindergartenComplex.Account_Editing
{
    internal static class AccountEditingController
    {
        public static int SaveChanges(string[] paramsList)
        {
            string sql = paramsList.Length == 2 ? "UPDATE Accounts SET Accounts.UserName = @userName WHERE Accounts.AccountId = @accountId" : "UPDATE Accounts SET Accounts.UserName = @userName, Accounts.UserPassword = @newPassword WHERE Accounts.AccountId = @accountId AND Accounts.UserPassword = @oldPassword";

            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = paramsList[0];
            cmd.Parameters.Add("@accountId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[1]);

            if (paramsList.Length == 4)
            {
                cmd.Parameters.Add("@newPassword", SqlDbType.VarChar).Value = paramsList[3];
                cmd.Parameters.Add("@oldPassword", SqlDbType.VarChar).Value = paramsList[2];
            }

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();

            return rowCount;
        }

        public static string GetLogin(int accountId)
        {
            SqlConnection con = new SqlConnection(AppParameters.ConnectionString);
            con.Open();

            string sql = "SELECT Accounts.UserName FROM Accounts WHERE Accounts.AccountId =  @accountId";

            SqlCommand command = con.CreateCommand();
            command.CommandText = sql;

            command.Parameters.Add("@accountId", SqlDbType.BigInt).Value = accountId;

            return command.ExecuteScalar().ToString();
        }
    }
}
