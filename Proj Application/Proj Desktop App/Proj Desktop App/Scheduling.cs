using Org.BouncyCastle.Asn1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Proj_Desktop_App
{
    public partial class Scheduling : Form
    {
        private ScheduleManager schedulemanager;
        private ShiftType seletedshifttype;
        private DateTime seleteddate;
        private DateTime previousdate;
        private Store store;
        public Scheduling(Departments department)
        {
            InitializeComponent();
            store = new Store();
            schedulemanager = new ScheduleManager(store);
            //1.update combo box
            cbDepartment.Items.Add(Departments.floorOne);
            cbDepartment.Items.Add(Departments.floorTwo);
            cbDepartment.Items.Add(Departments.floorThree);
            cbDepartment.Items.Add(Departments.floorFour);
            cbDepartment.Items.Add(Departments.office);
            cbDepartment.Items.Add(Departments.warehouse);
            //2.set default vale for combo box by department
            cbDepartment.SelectedItem = department;
            //3.automatic set the default shifttype
            seletedshifttype = ShiftType.Morning;
            ckbMorning.Checked = true;
            //4.automatic set the calendar date
            monthCalendarScheduling.SelectionStart = DateTime.Today;
            seleteddate = DateTime.Today;
            previousdate = DateTime.Today;
            //5.Update Employee list by department
            listboxAvailableEmployees.Items.Clear();
            
            foreach (Employee x in store.GetEmployees((Departments)cbDepartment.SelectedItem))
            {
                listboxAvailableEmployees.Items.Add(x.GetBsnAndName());
            }
            //6.Update AssigngedShift list by department
            listboxAssignedEmployees.Items.Clear();
            listboxAssignedEmployees.Items.AddRange(schedulemanager.GetEmployeesInfoByDateAndDepartment(seleteddate, (Departments)cbDepartment.SelectedItem));
        }

        private bool CheckAssignedShiftType()
        {
            if (ckbMorning.Checked) { seletedshifttype = ShiftType.Morning; }
            if (ckbAfternoon.Checked) { seletedshifttype = ShiftType.Afternoon; }
            if (CkbEvening.Checked) { seletedshifttype = ShiftType.Evening; }
            if (ckbMorning.Checked && ckbAfternoon.Checked) { seletedshifttype = ShiftType.Morning_Afternoon; }
            if (ckbMorning.Checked && CkbEvening.Checked) { seletedshifttype = ShiftType.Morning_Evening; }
            if (ckbAfternoon.Checked && CkbEvening.Checked) { seletedshifttype = ShiftType.Afternoon_Evening; }
            if (ckbMorning.Checked && ckbAfternoon.Checked && CkbEvening.Checked) { MessageBox.Show("it's illegal to assign empoyee working full day~!"); return false; }
            if (ckbMorning.Checked == false && ckbAfternoon.Checked == false && CkbEvening.Checked == false) { return false; }
            return true;
        }
        private void btnAddEmpShift_Click(object sender, EventArgs e)
        {           
                if (listboxAvailableEmployees.SelectedItems.Count != 0)
                {
                    if (seleteddate.Date < DateTime.Now.Date) { MessageBox.Show($"You can't Assign Shift at {seleteddate.ToString("dd/MM/yyyy")}"); return; }
                    listboxAssignedEmployees.Items.Clear();
                    if (CheckAssignedShiftType())  
                    {                            
                        List<int> seletedbsn = new List<int>();
                        foreach (object m in listboxAvailableEmployees.SelectedItems)
                        {
                            string extractbsn = Regex.Match(m.ToString(), @"[0-9]+").ToString();
                            seletedbsn.Add(Convert.ToInt32(extractbsn.ToString()));
                        }
                        //3. Assign sift                      
                        if (schedulemanager.AssignShift(seletedshifttype, seleteddate, seletedbsn))
                        {
                            listboxAssignedEmployees.Items.AddRange(schedulemanager.GetEmployeesInfoByDateAndDepartment(seleteddate,(Departments)cbDepartment.SelectedItem));
                        }
                        else { MessageBox.Show("Assign failed, Please try again~!"); }
                    }
                    else
                    { MessageBox.Show("please selete the vaild shift type"); }
                }
                else
                {
                    MessageBox.Show("Please select Employee then assign shift");
                }
        }
        private void listboxAvailableEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEmployeesInfo();
        }
        private void UpdateEmployeesInfo()
        {
            listBoxEmployeesDetails.Items.Clear();
            List<int> seletedbsn = new List<int>();
            List<Employee> tempoemployees = new List<Employee>();
            foreach (object m in listboxAvailableEmployees.SelectedItems)
            {
                string extractbsn = Regex.Match(m.ToString(), @"[0-9]+").ToString();
                seletedbsn.Add(Convert.ToInt32(extractbsn.ToString()));
            }
            foreach (int bsn in seletedbsn)
            {
                tempoemployees.Add(store.GetEmployee(bsn));
            }
            foreach (Employee e in tempoemployees)
            {
                listBoxEmployeesDetails.Items.Add(e.Biscinfo());
            }
        }
        private void btnRmvEmployeeShift_Click(object sender, EventArgs e)
        {
            List<int> seletedbsn = new List<int>();

            foreach (object m in listboxAssignedEmployees.SelectedItems)
            {
                string extractbsn = Regex.Match(m.ToString(), @"[0-9]+").ToString();
                seletedbsn.Add(Convert.ToInt32(extractbsn.ToString()));
            }
            listboxAssignedEmployees.Items.Clear();
            schedulemanager.RemoveShift(seleteddate, seletedbsn);
            seleteddate = monthCalendarScheduling.SelectionStart;
            listboxAssignedEmployees.Items.AddRange(schedulemanager.GetEmployeesInfoByDateAndDepartment(seleteddate,(Departments)cbDepartment.SelectedItem));
        }
        private void listboxAssignedEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxEmployeesDetails.Items.Clear();
            List<int> seletedbsn = new List<int>();
            List<Employee> tempoemployees = new List<Employee>();
            foreach (object m in listboxAssignedEmployees.SelectedItems)
            {
                string extractbsn = Regex.Match(m.ToString(), @"[0-9]+").ToString();
                seletedbsn.Add(Convert.ToInt32(extractbsn.ToString()));
            }
            foreach (int bsn in seletedbsn)
            {
               tempoemployees.Add(store.GetEmployee(bsn));
            }
            foreach (Employee tempo in tempoemployees)
            {

                listBoxEmployeesDetails.Items.AddRange(tempo.GetDetail());
            }
        }
        private void monthCalendarScheduling_DateSelected(object sender, DateRangeEventArgs e)
        {
            UpdateEmployeePreferenceShiftslists();
            listboxAssignedEmployees.Items.Clear();
            seleteddate = monthCalendarScheduling.SelectionStart;
            if (previousdate.Month != seleteddate.Month)
            {
                previousdate = seleteddate;
                Schedule a = new Schedule();
                a.LoadSchduleFormDateBase(seleteddate);
            }
            listboxAssignedEmployees.Items.AddRange(schedulemanager.GetEmployeesInfoByDateAndDepartment(seleteddate, (Departments)cbDepartment.SelectedItem));
        }
        private void btnSeachAvailableEmpByBsn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listboxAvailableEmployees.Items.Count; i++)
            {
                if (listboxAvailableEmployees.Items[i].ToString().Contains(textBoxSearchAvailableList.Text))
                {
                    listboxAvailableEmployees.SelectedItems.Add(listboxAvailableEmployees.Items[i]);

                }

            }
        }
        private void btnSearchAssignedEmpByBsn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listboxAssignedEmployees.Items.Count; i++)
            {
                if (listboxAssignedEmployees.Items[i].ToString().Contains(textBoxSearchAssignedEmployees.Text))
                {
                    listboxAssignedEmployees.SelectedItems.Add(listboxAssignedEmployees.Items[i]);
                }

            }
        }
        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //1.Update the employeelist by department
            listboxAvailableEmployees.Items.Clear();
            foreach (Employee x in store.GetEmployees((Departments)cbDepartment.SelectedItem))
            {
                listboxAvailableEmployees.Items.Add(x.GetBsnAndName());
            }
            //2.Update the assignedemployeelist by department
            listboxAssignedEmployees.Items.Clear();
            listboxAssignedEmployees.Items.AddRange(schedulemanager.GetEmployeesInfoByDateAndDepartment(seleteddate, (Departments)cbDepartment.SelectedItem));
        }

        private void listboxAvailableEmployees_Click(object sender, EventArgs e)
        {
            UpdateEmployeePreferenceShiftslists();
        }

        private void UpdateEmployeePreferenceShiftslists()
        {
            if (listboxAvailableEmployees.SelectedItem != null)
            {
                listboxEmployeePreferenceShifts.Items.Clear();
                //Get the employee's BSN
                object m = listboxAvailableEmployees.SelectedItem;
                string extractbsn = Regex.Match(m.ToString(), @"[0-9]+").ToString();
                //Get the employee's Object
                Employee employee = store.GetEmployee(Convert.ToInt32(extractbsn));
                //Let Schdule Manager to Processing Someting To Get the List of Preferences Shifts
                List<AvailableShift> personalpreferemceshift = schedulemanager.GetEmployee_Preference_Shift_For_The_Week(employee, seleteddate);
                //Display the listboxEmployeePreferenceShifts by weekly view
                listboxEmployeePreferenceShifts.Items.Add("Monday-------");
                listboxEmployeePreferenceShifts.Items.Add("Tuesday------");
                listboxEmployeePreferenceShifts.Items.Add("Wednesday----");
                listboxEmployeePreferenceShifts.Items.Add("Thursday-----");
                listboxEmployeePreferenceShifts.Items.Add("Friday-------");
                listboxEmployeePreferenceShifts.Items.Add("Saturday-----");
                listboxEmployeePreferenceShifts.Items.Add("Sunday-------");
                for (int i = 0; i < 7; i++)
                {
                    listboxEmployeePreferenceShifts.Items[i] += GetWeeklyShfitByDayIndex(i, personalpreferemceshift);
                }
            }

        }

        private string GetWeeklyShfitByDayIndex(int indexofweek, List<AvailableShift> templist)
        {
            string week = "";
            if (indexofweek == 0) { week = "Monday"; }
            else if (indexofweek == 1) { week = "Tuesday"; }
            else if (indexofweek == 2) { week = "Wednesday"; }
            else if (indexofweek == 3) { week = "Thursday"; }
            else if (indexofweek == 4) { week = "Friday"; }
            else if (indexofweek == 5) { week = "Saturday"; }
            else if (indexofweek == 6) { week = "Sunday"; }
            string temp = "Not Set Yet";
            foreach (AvailableShift x in templist)
            {
                if (x.GetDate().DayOfWeek.ToString() == week)
                {
                    temp = " "+x.GetDate().ToString("MM-dd")+" "+x.GetShiftTypeToString();
                }
            }
            return temp;
        }

    }
}
