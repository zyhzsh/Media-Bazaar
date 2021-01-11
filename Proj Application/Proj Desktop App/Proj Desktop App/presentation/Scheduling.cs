﻿using Proj_Desktop_App.dataAccess;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Proj_Desktop_App.dataAccess;
using Proj_Desktop_App.presentation;

namespace Proj_Desktop_App
{
    public partial class Scheduling : Form
    {

        private AutomaticScheduling automaticScheduling;
        private ShiftType seletedshifttype;
        private DateTime seleteddate;
        private DateTime previousdate;


        private ScheduleStorage scheduleStorage;
        private EmployeeStorage empStorage;

        public Scheduling(Department department, DepartmentStorage departments)
        {
            InitializeComponent();
            empStorage = new EmployeeStorage();
            this.scheduleStorage = new ScheduleStorage(empStorage);

            automaticScheduling = new AutomaticScheduling(department, scheduleStorage);

            //1.update combo box
            foreach (Department d in departments.GetDepartments())
            {
                cbDepartment.Items.Add(d);
            }
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

            foreach (Employee x in empStorage.GetEmployees((Department)cbDepartment.SelectedItem))
            {
                listboxAvailableEmployees.Items.Add(x);
            }
            //6.Update AssigngedShift list by department
            listboxAssignedEmployees.Items.Clear();
            listboxAssignedEmployees.Items.AddRange(schedulemanager.GetEmployeesInfoByDateAndDepartment(seleteddate, (Department)cbDepartment.SelectedItem));
        }

        private void btnAddEmpShift_Click(object sender, EventArgs e)
        {
            if (listboxAvailableEmployees.SelectedItems.Count != 0)
            {
                if (seleteddate.Date < DateTime.Now.Date) { MessageBox.Show($"You can't Assign Shift at {seleteddate.ToString("dd/MM/yyyy")}"); return; }
                listboxAssignedEmployees.Items.Clear();
                if (CheckAssignedShiftType())
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
                        if (scheduleStorage.AssignShift(seletedshifttype, seleteddate, seletedbsn))
                        {
                        //4.update to the shift list
                            listboxAssignedEmployees.Items.AddRange(scheduleStorage.GetEmployeesInfoByDateAndDepartment(seleteddate,(Department)cbDepartment.SelectedItem));
                        }
                        else { MessageBox.Show("Assign failed, Please try again~!"); }
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
        private void btnRmvEmployeeShift_Click(object sender, EventArgs e)
        {
            List<int> seletedbsn = new List<int>();

            foreach (object m in listboxAssignedEmployees.SelectedItems)
            {
                string extractbsn = Regex.Match(m.ToString(), @"[0-9]+").ToString();
                seletedbsn.Add(Convert.ToInt32(extractbsn.ToString()));
            }
            listboxAssignedEmployees.Items.Clear();
            scheduleStorage.RemoveShift(seleteddate, seletedbsn);
            seleteddate = monthCalendarScheduling.SelectionStart;
            listboxAssignedEmployees.Items.AddRange(scheduleStorage.GetEmployeesInfoByDateAndDepartment(seleteddate,(Department)cbDepartment.SelectedItem));
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
               tempoemployees.Add(empStorage.GetEmployee(bsn));
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
                scheduleStorage.ReloadSchedule(seleteddate);
            }
            listboxAssignedEmployees.Items.AddRange(scheduleStorage.GetEmployeesInfoByDateAndDepartment(seleteddate, (Department)cbDepartment.SelectedItem));
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
            foreach (Employee x in empStorage.GetEmployees((Department)cbDepartment.SelectedItem))
            {
                listboxAvailableEmployees.Items.Add(x);
            }
            //2.Update the assignedemployeelist by department
            listboxAssignedEmployees.Items.Clear();
            listboxAssignedEmployees.Items.AddRange(scheduleStorage.GetEmployeesInfoByDateAndDepartment(seleteddate, (Department)cbDepartment.SelectedItem));
        }
        private void listboxAvailableEmployees_Click(object sender, EventArgs e)
        {
            UpdateEmployeePreferenceShiftslists();
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
                tempoemployees.Add(empStorage.GetEmployee(bsn));
            }
            foreach (Employee e in tempoemployees)
            {
                listBoxEmployeesDetails.Items.Add(e.Biscinfo());
            }
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
        private void UpdateEmployeePreferenceShiftslists()
        {
            if (listboxAvailableEmployees.SelectedItem != null)
            {
                listboxEmployeePreferenceShifts.Items.Clear();
                //Get the employee's BSN
                object m = listboxAvailableEmployees.SelectedItem;
                int extractbsn = Convert.ToInt32(Regex.Match(m.ToString(), @"[0-9]+").ToString());
                //Get the employee's Object
                Employee employee = empStorage.GetEmployee(Convert.ToInt32(extractbsn));
                //Let Schdule Manager to Processing Someting To Get the List of Preferences Shifts
                Availability emp_availability= scheduleStorage.GetAvailability(extractbsn);
                //Display the listboxEmployeePreferenceShifts by weekly view
                listboxEmployeePreferenceShifts.Items.Add("Monday-------");
                listboxEmployeePreferenceShifts.Items.Add("Tuesday------");
                listboxEmployeePreferenceShifts.Items.Add("Wednesday----");
                listboxEmployeePreferenceShifts.Items.Add("Thursday-----");
                listboxEmployeePreferenceShifts.Items.Add("Friday-------");
                for (int i = 0; i < 5; i++)
                {
                    if (emp_availability == null) { listboxEmployeePreferenceShifts.Items[i] += "Not Set"; continue; }
                    listboxEmployeePreferenceShifts.Items[i] += emp_availability.WeekAvailability[i].ToString();
                }
            }
        }
    }
}
