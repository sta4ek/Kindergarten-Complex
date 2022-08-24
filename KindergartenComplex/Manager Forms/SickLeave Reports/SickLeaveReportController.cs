using System;
using System.Data;
using System.Windows.Forms;

namespace KindergartenComplex.Manager_Forms.SickLeave_Reports
{
    static class SickLeaveReportController
    {
        public static DataTable CalculateSickLeavesDays(DataTable dataTable, DateTimePicker dateTimePickerWorkMonth)
        {
            DataTable newTable = new DataTable();
            newTable.Columns.Add("Fullname");
            newTable.Columns.Add("DaysCount");

            foreach (DataRow row in dataTable.Rows)
            {
                if (Convert.ToDateTime(row[1]).Month < dateTimePickerWorkMonth.Value.Month)
                {
                    row[1] = new DateTime(DateTime.Today.Year, dateTimePickerWorkMonth.Value.Month, 1);
                }

                if (Convert.ToDateTime(row[2]).Month > dateTimePickerWorkMonth.Value.Month)
                {
                    row[2] = new DateTime(DateTime.Today.Year, dateTimePickerWorkMonth.Value.Month, DateTime.DaysInMonth(dateTimePickerWorkMonth.Value.Year,
                        dateTimePickerWorkMonth.Value.Month));
                }

                var dateStart = Convert.ToDateTime(row[1]);
                var dateEnd = Convert.ToDateTime(row[2]);

                int daysCount = 0;

                while (dateStart <= dateEnd)
                {
                    if (dateStart.DayOfWeek == DayOfWeek.Saturday || dateStart.DayOfWeek == DayOfWeek.Sunday)
                    {
                        dateStart = dateStart.AddDays(1);
                        continue;
                    }

                    daysCount++;
                    dateStart = dateStart.AddDays(1);
                }

                if (daysCount != 0)
                    newTable.Rows.Add(row[0].ToString(), daysCount);
            }

            return newTable;
        }
    }
}
