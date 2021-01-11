using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Desktop_App.presentation
{
    public partial class WeeklyScheduleGridForm : Form
    {
        private AutomaticScheduling autoSchedule;
        private ScheduleStorage scheduleStorage;
        private EmployeeStorage empStorage;

        private List<Employee>[] assignedWorkers;
        private List<Employee>[] assignedManagers;
        public WeeklyScheduleGridForm(Department currentDepartment, EmployeeStorage empStorage)
        {
            InitializeComponent();
            this.empStorage = empStorage;
            this.scheduleStorage = new ScheduleStorage(empStorage);

            autoSchedule = new AutomaticScheduling(currentDepartment, scheduleStorage);
            


        /*
            for(int i = 0; i < 3; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dtGrdViewWorkers.Rows[0].Clone();

                row.Cells[0].Value = assignedEmployees[i].Count;
                row.Cells[1].Value = assignedEmployees[i+3].Count;
                row.Cells[2].Value = assignedEmployees[i+6].Count;
                row.Cells[3].Value = assignedEmployees[i+9].Count;
                row.Cells[4].Value = assignedEmployees[i+12].Count;

                dtGrdViewWorkers.Rows.Add(row);
            }
        */
        }

        private void btnAutoSchedule_Click(object sender, EventArgs e)
        {
            lbEmployeeReports.Items.Clear();
            dtGrdViewManagers.Rows.Clear();
            dtGrdViewWorkers.Rows.Clear();

            // WORKERS
            assignedWorkers = autoSchedule.AssignWorkers();

            for (int i = 0; i < 3; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dtGrdViewWorkers.Rows[0].Clone();

                row.Cells[0].Value = assignedWorkers[i].Count;
                row.Cells[1].Value = assignedWorkers[i + 3].Count;
                row.Cells[2].Value = assignedWorkers[i + 6].Count;
                row.Cells[3].Value = assignedWorkers[i + 9].Count;
                row.Cells[4].Value = assignedWorkers[i + 12].Count;

                dtGrdViewWorkers.Rows.Add(row);
            }
            lbEmployeeReports.Items.Add("WORKERS");
            foreach(string workerReport in autoSchedule.GetReports())
            {
                lbEmployeeReports.Items.Add(workerReport);
            }

            // MANAGERS
            assignedManagers = autoSchedule.AssignManagers();
            for (int i = 0; i < 3; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dtGrdViewManagers.Rows[0].Clone();

                row.Cells[0].Value = assignedManagers[i].Count;
                row.Cells[1].Value = assignedManagers[i + 3].Count;
                row.Cells[2].Value = assignedManagers[i + 6].Count;
                row.Cells[3].Value = assignedManagers[i + 9].Count;
                row.Cells[4].Value = assignedManagers[i + 12].Count;

                dtGrdViewManagers.Rows.Add(row);
            }
            lbEmployeeReports.Items.Add("MANAGERS");
            foreach (string managerReport in autoSchedule.GetReports())
            {
                lbEmployeeReports.Items.Add(managerReport);
            }

            gbSubmit.Enabled = true;
            btnAssign.Enabled = false;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == MessageBox.Show("This will erase all previously assigned shifts for the coming week before assigning the generated shifts.","Are you sure?", MessageBoxButtons.OKCancel))
            {
                if(ckBoxWorkers.Checked && ckBoxManagers.Checked)
                {
                    List<Employee>[] both = new List<Employee>[15];
                    scheduleStorage.AssignNextWeekShifts(WorkersAndManagers());
                }
                else if (ckBoxManagers.Checked)
                {
                    scheduleStorage.AssignNextWeekShifts(assignedManagers);
                }
                else if(ckBoxWorkers.Checked)
                {
                    scheduleStorage.AssignNextWeekShifts(assignedWorkers);
                }
                else
                {
                    MessageBox.Show("No shifts selected");
                }
                MessageBox.Show("Employees assigned successfully!");
            }
        }

        private List<Employee>[] WorkersAndManagers()
        {
            List<Employee>[] result = new List<Employee>[15];
            for(int i = 0; i < 15; i++)
            {
                result[i] = new List<Employee>();
                result[i].AddRange(assignedWorkers[i]);
                result[i].AddRange(assignedManagers[i]);
            }
            return result;
        }
        private void ckBoxWorkers_CheckedChanged(object sender, EventArgs e)
        {
            if(!ckBoxManagers.Checked && !ckBoxWorkers.Checked)
            {
                btnAssign.Enabled = false;
            }
            else
            {
                btnAssign.Enabled = true;
            }
        }

        private void ckBoxManagers_CheckedChanged(object sender, EventArgs e)
        {
            if (!ckBoxManagers.Checked && !ckBoxWorkers.Checked)
            {
                btnAssign.Enabled = false;
            }
            else
            {
                btnAssign.Enabled = true;
            }
        }
    }
}
