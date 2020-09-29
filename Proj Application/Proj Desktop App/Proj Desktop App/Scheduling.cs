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
        List<Employee> employees;
        //List<AssignedShift> assignedshifts;
        Schedule schedule;
        ShiftType seletedshifttype;
        DateTime seleteddate;
        public Scheduling()
        {
            InitializeComponent();
            employees = new List<Employee>();
            employees.Add(new Employee(3992616, "Shenghang", "Zhu", "male", 134556, DateTime.Parse("01/01/2020"), "Tilburg", "ICT", "employed", "Depot", "xxxx@gmail.com", 1, PositionType.Depot_Worker));
            employees.Add(new Employee(3376540, "David", "van Rijthoven ", "male", 134556, DateTime.Parse("01/01/2020"), "Eindhoven", "ICT", "employed", "Sale", "xxxx@gmail.com", 1, PositionType.Sales_Worker));
            employees.Add(new Employee(4090918, "Dzhurov", "Shenghang", "male", 134556, DateTime.Parse("01/01/2020"), "Amersfoort", "ICT", "employed", "Depot", "xxxx@gmail.com", 1, PositionType.Depot_Worker));
            employees.Add(new Employee(443892, "Mohammed", "Al-Eryani", "male", 134556, DateTime.Parse("01/01/2020"), "Den Haag", "ICT", "employed", "Sale", "xxxx@gmail.com", 1, PositionType.Sales_Worker));
            employees.Add(new Employee(3088685, "Joost", "Burggraaff", "male", 134556, DateTime.Parse("01/01/2020"), "Eindhoven", "ICT", "employed", "Depot", "xxxx@gmail.com", 1, PositionType.Depot_Worker));
            schedule=new Schedule();
            // assignedshifts = new List<AssignedShift>();
 
            schedule.AssignEmployeeToShift(ShiftType.Morning_Afternoon, DateTime.Today.ToString("29/09/2020"),employees);
            




            seletedshifttype = ShiftType.Morning;
            ckbMorning.Checked = true;
            monthCalendarScheduling.SelectionStart = DateTime.Today;
            seleteddate= DateTime.Today;
            UpDateAssignedToListBox();
            UpDateEmployeeToListBox();
        }

        void UpDateAssignedToListBox()
        {
            List<Employee> tempo = new List<Employee>();
            tempo=schedule.GetAssignedEmployees(seleteddate.ToString("dd/MM/yyyy"));
            foreach (Employee e in tempo)
            {
                listboxAssignedEmployees.Items.Add(e.BSN);
            }
            
          
        }

        void UpDateEmployeeToListBox()
        {
            listboxAvailableEmployees.Items.Clear();
            foreach (Employee e in employees)
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
            //1.check and get shifttype
            if (CheckAssignedShiftType())
            {
                //2.get selected Object;
                //a. Get list of bsn
                List<int> seletedbsn = new List<int>();
                List<Employee> tempoemployees = new List<Employee>();
                foreach (object m in listboxAvailableEmployees.SelectedItems)
                {
                    string extractbsn = Regex.Match(m.ToString(), @"[0-9]+").ToString();
                    seletedbsn.Add(Convert.ToInt32(extractbsn.ToString()));
                }
                //b.Get list of employees 
                foreach (int bsn in seletedbsn)
                {
                    foreach (Employee Em in employees)
                    {
                        if (Em.BSN == bsn)
                        {
                            tempoemployees.Add(Em);
                        }
                    }
                }
                //3. Assign sift            
                if (schedule.AssignEmployeeToShift(seletedshifttype, seleteddate.Date.ToString("dd/MM/yyyy"), tempoemployees))
                {
                    MessageBox.Show($"Assign succeed ~ ! ");
                }
            }
            else
            { MessageBox.Show("please selete the shift type"); }







        }

        private void monthCalendarScheduling_DateChanged(object sender, DateRangeEventArgs e)
        {
            seleteddate = monthCalendarScheduling.SelectionStart;
            schedule.GetAssignedEmployees(seleteddate.ToString("dd/MM/yyyy"));
        }

        private void listboxAvailableEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateEmployeesInfo();
        }
        void UpdateEmployeesInfo()
        {
            listBox1.Items.Clear();
            List<int> seletedbsn = new List<int>();
            List<Employee> tempoemployees = new List<Employee>();
            foreach (object m in listboxAvailableEmployees.SelectedItems)
               {
                    string extractbsn= Regex.Match(m.ToString(), @"[0-9]+").ToString();
                    seletedbsn.Add(Convert.ToInt32(extractbsn.ToString()));
               }
            foreach (int bsn in seletedbsn)
              {
                    foreach (Employee Em in employees)
                    {
                        if (Em.BSN == bsn)
                        {
                            tempoemployees.Add(Em);
                        }                 
                    }
                }
            foreach (Employee e in tempoemployees)
            {

                listBox1.Items.Add(e.Biscinfo());
            }
               
        }









        private void btnRmvEmployeeShift_Click(object sender, EventArgs e)
        {
            schedule.GetAssignedEmployees(seleteddate.ToString("dd/MM/yyyy"));
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
