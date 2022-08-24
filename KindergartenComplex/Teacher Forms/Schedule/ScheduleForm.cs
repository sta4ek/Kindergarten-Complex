using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KindergartenComplex.Teacher_Forms.Schedule
{
    public partial class ScheduleForm : Form
    {
        private readonly int _groupId;
        private readonly Form _prevForm;
        private readonly List<string>[] _listDays;
        private readonly string[] _daysOfWeek = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница" };

        public ScheduleForm(int groupId, string groupName, Form prevForm = null, List<string>[] listDays = null)
        {
            _groupId = groupId;
            _prevForm = prevForm;
            _listDays = listDays;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            if (_prevForm != null)
            {
                buttonBack.Visible = true;
                buttonSave.Visible = true;
            }
            else
            {
                labelGroupName.Visible = true;
                labelGroupName.Text += groupName;
                ScheduleController.FillListDays(_groupId, ref _listDays, _daysOfWeek);
            }

            ScheduleController.FillScheduleFromLists(_listDays, dataGridViewSchedule);
            ScheduleController. SelectDayOfWeek(dataGridViewSchedule);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
            _prevForm.Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ScheduleController.SaveSchedule(_groupId, _listDays, _daysOfWeek);
            _prevForm.Close();
            Close();
        }
    }
}