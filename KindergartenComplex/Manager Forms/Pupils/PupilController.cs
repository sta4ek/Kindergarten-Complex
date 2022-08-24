using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.Pupils
{
    internal static class PupilController
    {
        public static void DeletePupil(DataGridView dataGridViewTable)
        {
            DialogResult dialogResult = MessageBox.Show("Удалить " + dataGridViewTable.SelectedRows.Count + " запись(ей)", "Удаление воспитанника", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
                connection.Open();

                foreach (DataGridViewRow row in dataGridViewTable.SelectedRows)
                {
                    string sql = "DELETE FROM Pupils WHERE Pupils.PupilId = @pupilId";

                    SqlCommand cmd = connection.CreateCommand();
                    cmd.CommandText = sql;

                    cmd.Parameters.Add("@pupilId", SqlDbType.BigInt).Value = Convert.ToInt32(row.Cells[0].Value);

                    int rowCount = cmd.ExecuteNonQuery();

                    dataGridViewTable.Rows.Remove(row);
                }

                connection.Close();
            }
        }

        public static int AddPupil(string[] paramsList)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "INSERT INTO Pupils(Fullname, Parents, PhoneNumber, LivingAddress, HealthGroup, MedicalDiagnosis, Understudy, GroupId, PEGroup, Diet) VALUES(@fullname, @parents, @phoneNumber, @livingAddress, @healthGroup, @medicalDiagnosis, @understudy, @groupId, @peGroup, @diet) SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@fullname", SqlDbType.VarChar).Value = paramsList[0];
            cmd.Parameters.Add("@parents", SqlDbType.VarChar).Value = paramsList[1];
            cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = paramsList[2];
            cmd.Parameters.Add("@livingAddress", SqlDbType.VarChar).Value = paramsList[3];
            cmd.Parameters.Add("@healthGroup", SqlDbType.VarChar).Value = paramsList[4];
            cmd.Parameters.Add("@medicalDiagnosis", SqlDbType.VarChar).Value = paramsList[5];
            cmd.Parameters.Add("@understudy", SqlDbType.VarChar).Value = paramsList[6];
            cmd.Parameters.Add("@groupId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[7]);
            cmd.Parameters.Add("@peGroup", SqlDbType.VarChar).Value = paramsList[8];
            cmd.Parameters.Add("@diet", SqlDbType.VarChar).Value = paramsList[9];

            int rowId = Convert.ToInt32(cmd.ExecuteScalar());

            connection.Close();

            return rowId;
        }

        public static void EditPupil(string[] paramsList)
        {
            SqlConnection connection = new SqlConnection(AppParameters.ConnectionString);
            connection.Open();

            string sql = "UPDATE Pupils SET Pupils.Fullname = @fullname, Pupils.Parents = @parents, Pupils.PhoneNumber = @phoneNumber, Pupils.LivingAddress = @livingAddress, Pupils.HealthGroup = @healthGroup, Pupils.MedicalDiagnosis = @medicalDiagnosis, Pupils.Understudy = @understudy, Pupils.GroupId = @groupId, Pupils.PEGroup = @peGroup, Pupils.Diet = @diet WHERE Pupils.PupilId = @pupilId";

            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandText = sql;

            cmd.Parameters.Add("@fullname", SqlDbType.VarChar).Value = paramsList[0];
            cmd.Parameters.Add("@parents", SqlDbType.VarChar).Value = paramsList[1];
            cmd.Parameters.Add("@phoneNumber", SqlDbType.VarChar).Value = paramsList[2];
            cmd.Parameters.Add("@livingAddress", SqlDbType.VarChar).Value = paramsList[3];
            cmd.Parameters.Add("@healthGroup", SqlDbType.VarChar).Value = paramsList[4];
            cmd.Parameters.Add("@medicalDiagnosis", SqlDbType.VarChar).Value = paramsList[5];
            cmd.Parameters.Add("@understudy", SqlDbType.VarChar).Value = paramsList[6];
            cmd.Parameters.Add("@groupId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[7]);
            cmd.Parameters.Add("@peGroup", SqlDbType.VarChar).Value = paramsList[8];
            cmd.Parameters.Add("@diet", SqlDbType.VarChar).Value = paramsList[9];
            cmd.Parameters.Add("@pupilId", SqlDbType.BigInt).Value = Convert.ToInt32(paramsList[10]);

            int rowCount = cmd.ExecuteNonQuery();

            connection.Close();
        }
    }
}
