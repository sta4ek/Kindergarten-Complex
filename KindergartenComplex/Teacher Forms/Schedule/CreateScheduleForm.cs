using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KindergartenComplex.Teacher_Forms.Schedule
{
    public partial class CreateScheduleForm : Form
    {
        private readonly int _groupId;
        private readonly string _groupName;
        private readonly ListBox[] _listBoxesDays;
        private readonly string[] _daysOfWeek = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница" };
        private int _dayIndex = 0;
        private ListBox _listBoxDay;

        public CreateScheduleForm(int groupId, string groupName)
        {
            _groupId = groupId;
            _groupName = groupName;

            InitializeComponent();

            Text += AppParameters.KindergartenName;

            _listBoxesDays = new []{ listBoxMonday, listBoxThuesday, listBoxWednesday, listBoxThursday, listBoxFriday };

            _listBoxDay = _listBoxesDays[0];

            listBoxSubjects.Items.AddRange(ScheduleController.GetSubjects(ScheduleController.GetColumnName(_groupName)).ToArray());
        }

        private void MoveSelectedItems(ListBox lstFrom, ListBox lstTo)
        {
            if (lstFrom.SelectedItems.Count > 0)
            {
                string item = (string)lstFrom.SelectedItems[0];
                lstTo.Items.Add(item);
                lstFrom.Items.Remove(item);
            }
        }

        private void buttonMoveToWeek_Click(object sender, EventArgs e)
        {
            MoveSelectedItems(listBoxSubjects, _listBoxDay);
            buttonMoveToSubjects.Enabled = _listBoxDay.Items.Count != 0;
        }

        private void buttonMoveToSubjects_Click_1(object sender, EventArgs e)
        {
            MoveSelectedItems(_listBoxDay, listBoxSubjects);
            buttonMoveToSubjects.Enabled = _listBoxDay.Items.Count != 0;
        }

        private void buttonNextDayOfWeek_Click(object sender, EventArgs e)
        {
            _listBoxesDays[_dayIndex].Visible = false;

            if (_dayIndex == _listBoxesDays.Length - 1)
            {
                _dayIndex = 0;
            }
            else
            {
                _dayIndex++;
            }

            _listBoxesDays[_dayIndex].Visible = true;
            _listBoxDay = _listBoxesDays[_dayIndex];
            labelDayOfWeek.Text = _daysOfWeek[_dayIndex];
            buttonMoveToSubjects.Enabled = _listBoxDay.Items.Count != 0;
        }

        private void buttonPrevDayOfWeek_Click(object sender, EventArgs e)
        {
            _listBoxesDays[_dayIndex].Visible = false;

            if (_dayIndex == 0)
            {
                _dayIndex = _listBoxesDays.Length - 1;
            }
            else
            {
                _dayIndex--;
            }

            _listBoxesDays[_dayIndex].Visible = true;
            _listBoxDay = _listBoxesDays[_dayIndex];
            labelDayOfWeek.Text = _daysOfWeek[_dayIndex];
            buttonMoveToSubjects.Enabled = _listBoxDay.Items.Count != 0;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            List<string>[] daysLists = {new List<string>(), new List<string>(), new List<string>(), new List<string>(), new List<string>() };

            for (int i = 0; i < _listBoxesDays.Length; i++)
            {
                foreach (var item in _listBoxesDays[i].Items)
                {
                    daysLists[i].Add(item.ToString());
                }
            }

            Hide();
            ScheduleForm scheduleForm = new ScheduleForm(_groupId, _groupName,this, daysLists);
            scheduleForm.Show();
        }

        private void listBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxSubjects.Items.Count == 0)
            {
                buttonMoveToWeek.Enabled = false;
                buttonNext.Enabled = true;
            }
            else
            {
                buttonMoveToWeek.Enabled = true;
                buttonNext.Enabled = false;
            }
        }
    }
}
