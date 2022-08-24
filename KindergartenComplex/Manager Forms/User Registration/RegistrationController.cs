using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.User_Registration
{
    internal static class RegistrationController
    {
        public static void RegisterUser(string[] paramsList)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "INSERT INTO Accounts(UserName, UserPassword, EmployeeId) VALUES(@userName, @userPassword, @employeeId)";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = paramsList[0];
            cmd.Parameters.Add("@userPassword", SqlDbType.VarChar).Value = paramsList[1];
            cmd.Parameters.Add("@employeeId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[2]);

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }

        public static bool IsLoginAvailable(string login)
        {
            bool isLoginAvailable = true;

            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "SELECT Accounts.AccountId FROM Accounts WHERE Accounts.UserName = @userName";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@userName", SqlDbType.VarChar).Value = login;

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows)
                isLoginAvailable = false;

            return isLoginAvailable;
        }
    }
}
