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

        private List<Employee>[] assignedWorkers;
        private List<Employee>[] assignedManagers;
        private Department currentDepartment;
        public WeeklyScheduleGridForm(Department currentDepartment, EmployeeStorage empStorage)
        {
            InitializeComponent();
            this.scheduleStorage = new ScheduleStorage(empStorage);
            this.currentDepartment = currentDepartment;


            autoSchedule = new AutomaticScheduling(currentDepartment, scheduleStorage);
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

                if (i == 0) row.HeaderCell.Value = "Morning";
                else if (i == 1) row.HeaderCell.Value = "Afternoon";
                else if (i == 2) row.HeaderCell.Value = "Evening";

                for(int j = 0; j < 5; j++)
                {
                    row.Cells[j].Value = assignedWorkers[i + j*3].Count;
                    if (Convert.ToInt32(row.Cells[j].Value) < 3) row.Cells[j].Style.BackColor = Color.Red;
                    else if (Convert.ToInt32(row.Cells[j].Value) > 5) row.Cells[j].Style.BackColor = Color.DarkOrange;
                    else row.Cells[j].Style.BackColor = Color.White;
                }

                dtGrdViewWorkers.Rows.Add(row);
            }
            lbEmployeeReports.Items.Add("WORKERS");
            foreach(string workerReport in autoSchedule.GetOvertimeReports())
            {
                lbEmployeeReports.Items.Add(workerReport);
            }


            this.lblWorkerStaff.Text = autoSchedule.GetWorkerReport();
            this.lblWorkerStaff.Visible = true;
            if (lblWorkerStaff.Text == "You have enough workers")
            {
                this.lblWorkerStaff.BackColor = Color.Green;
            }
            else if (lblWorkerStaff.Text == "Too many workers")
            {
                this.lblWorkerStaff.BackColor = Color.Orange;
            }
            else
                this.lblWorkerStaff.BackColor = Color.Red;
            

            // MANAGERS
            assignedManagers = autoSchedule.AssignManagers();
            for (int i = 0; i < 3; i++)
            {
                DataGridViewRow row = (DataGridViewRow)dtGrdViewManagers.Rows[0].Clone();

                if (i == 0) row.HeaderCell.Value = "Morning";
                else if (i == 1) row.HeaderCell.Value = "Afternoon";
                else if (i == 2) row.HeaderCell.Value = "Evening";

                for (int j = 0; j < 5; j++)
                {
                    row.Cells[j].Value = assignedManagers[i + j*3].Count;
                    if (Convert.ToInt32(row.Cells[j].Value) < 1) row.Cells[j].Style.BackColor = Color.Red;
                    else if (Convert.ToInt32(row.Cells[j].Value) > 1) row.Cells[j].Style.BackColor = Color.DarkOrange;
                    else row.Cells[j].Style.BackColor = Color.White;
                }

                dtGrdViewManagers.Rows.Add(row);
            }
            lbEmployeeReports.Items.Add("MANAGERS");
            foreach (string managerReport in autoSchedule.GetOvertimeReports())
            {
                lbEmployeeReports.Items.Add(managerReport);
            }

            this.lblManagerStaff.Text = autoSchedule.GetManagerReport();
            this.lblManagerStaff.Visible = true;
            if (this.lblManagerStaff.Text == "You have enough managers")
            {
                this.lblManagerStaff.BackColor = Color.Green;
            }
            else if (this.lblManagerStaff.Text == "Too many managers")
            {
                this.lblManagerStaff.BackColor = Color.Orange;
            }
            else
                this.lblManagerStaff.BackColor = Color.Red;
            

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
                    scheduleStorage.AssignNextWeekShifts(WorkersAndManagers(), currentDepartment);
                }
                else if (ckBoxManagers.Checked)
                {
                    scheduleStorage.AssignNextWeekShifts(assignedManagers, currentDepartment);
                }
                else if(ckBoxWorkers.Checked)
                {
                    scheduleStorage.AssignNextWeekShifts(assignedWorkers, currentDepartment);
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

        private void dtGrdViewWorkers_SelectionChanged(object sender, EventArgs e)
        {
            this.dtGrdViewWorkers.ClearSelection();
        }

        private void dtGrdViewManagers_SelectionChanged(object sender, EventArgs e)
        {
            this.dtGrdViewManagers.ClearSelection();
        }
    }
}
