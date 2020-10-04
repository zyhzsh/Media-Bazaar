using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public partial class Scheduling : Form
    {
       private Schedule schedule;
       private ScheduleManager schedulemanager;
       private ShiftType seletedshifttype;
       private DateTime seleteddate;
        //Tempo employee list should get employee from EmployeeManager Class or somewhere else, currently keep this way
        private EmployeeManager employeeManager;
        public void TestEmployee()
        {
            employeeManager = new EmployeeManager();
            employeeManager.AddTestData();
        }
       
        public Scheduling()
        {
            InitializeComponent();
            schedule=new Schedule();
            schedulemanager = new ScheduleManager();         
            initializesomesetting();
        }
       






        void UpDateAssignedToListBox()
        {
            listboxAssignedEmployees.Items.AddRange(schedulemanager.GetEmployeesInfoByDate(seleteddate));
        }

        void UpDateEmployeeToListBox()
        {
            listboxAvailableEmployees.Items.Clear();
            foreach (Employee e in employeeManager.GetEmployees())
            {
                listboxAvailableEmployees.Items.Add(e.GetBsnAndName());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private bool CheckAssignedShiftType()
        {        
            if (ckbMorning.Checked) { seletedshifttype = ShiftType.Morning; }
            if (ckbAfternoon.Checked) { seletedshifttype = ShiftType.Afternoon; }
            if (CkbEvening.Checked) { seletedshifttype = ShiftType.Evening; }
            if (ckbMorning.Checked && ckbAfternoon.Checked) { seletedshifttype = ShiftType.Morning_Afternoon; }
            if (ckbMorning.Checked && CkbEvening.Checked) { seletedshifttype = ShiftType.Morning_Evening; }
            if (ckbAfternoon.Checked && CkbEvening.Checked) { seletedshifttype = ShiftType.Afternoon_Evening; }
            if (ckbMorning.Checked && ckbAfternoon.Checked && CkbEvening.Checked) { seletedshifttype = ShiftType.FullDay; }
            if (ckbMorning.Checked == false && ckbAfternoon.Checked == false && CkbEvening.Checked == false) { return false; }
            return true;
        }




        private void btnAddEmpShift_Click(object sender, EventArgs e)
        {
            if (listboxAvailableEmployees.SelectedItems.Count!=0)
            {
                listboxAssignedEmployees.Items.Clear();
                //1.check and get shifttype
                if (CheckAssignedShiftType())
                {
                    //2.get selected Object;
                    //a. Get list of bsn
                    List<int> seletedbsn = new List<int>();
                    foreach (object m in listboxAvailableEmployees.SelectedItems)
                    {
                        string extractbsn = Regex.Match(m.ToString(), @"[0-9]+").ToString();
                        seletedbsn.Add(Convert.ToInt32(extractbsn.ToString()));
                    }
                    //3. Assign sift                      
                    if (schedulemanager.AssignShift(seletedshifttype, seleteddate, seletedbsn))
                    {
                        listboxAssignedEmployees.Items.AddRange(schedulemanager.GetEmployeesInfoByDate(seleteddate));
                    }
                    else { MessageBox.Show("Assign failed, Please try again~!"); }

                }
                else
                { MessageBox.Show("please selete the shift type"); }
            }
            else
            {
                MessageBox.Show("Please select Employee then assign shift");
            }
            
        }

        private void monthCalendarScheduling_DateChanged(object sender, DateRangeEventArgs e)
        {
           
            /* 
            schedulem.GetAssignedEmployees(seleteddate.ToString("dd/MM/yyyy"));*/


        }

        private void listboxAvailableEmployees_SelectedIndexChanged(object sender, EventArgs e)
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
                foreach (Employee Em in employeeManager.GetEmployees())
                {
                    if (Em.BSN == bsn)
                    {
                        tempoemployees.Add(Em);
                    }
                }
            }
            foreach (Employee tempo in tempoemployees)
            {

                listBoxEmployeesDetails.Items.AddRange(tempo.GetDetial());
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
            listboxAssignedEmployees.Items.AddRange(schedulemanager.GetEmployeesInfoByDate(seleteddate));

            /* schedule.GetAssignedEmployees(seleteddate.ToString("dd/MM/yyyy"));*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void initializesomesetting()
        {
            seletedshifttype = ShiftType.Morning;
            ckbMorning.Checked = true;
            monthCalendarScheduling.SelectionStart = DateTime.Today;
            seleteddate = DateTime.Today;
            TestEmployee();
            UpDateAssignedToListBox();
            UpDateEmployeeToListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeManager x = new EmployeeManager();
            MessageBox.Show(x.GetEmployees().Count.ToString());
        }

        private void monthCalendarScheduling_DateSelected(object sender, DateRangeEventArgs e)
        {
            listboxAssignedEmployees.Items.Clear();
            seleteddate = monthCalendarScheduling.SelectionStart;
            listboxAssignedEmployees.Items.AddRange(schedulemanager.GetEmployeesInfoByDate(seleteddate));
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
                foreach (Employee Em in employeeManager.GetEmployees())
                {
                    if (Em.BSN == bsn)
                    {
                        tempoemployees.Add(Em);
                    }
                }
            }
            foreach (Employee tempo in tempoemployees)
            {

                listBoxEmployeesDetails.Items.AddRange(tempo.GetDetial());
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

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
    }
}
