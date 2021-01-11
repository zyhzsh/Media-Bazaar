using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public enum ContractAction
    {
        Promote, Terminate, Extend
    }

    public partial class ContractUpdateForm : Form
    {
        private Contract activeContract;
        private Employee employee;
        private DepartmentStorage departmentStorage;

        private NumericUpDown nudPromotion;
        private DateTimePicker dtpTerminateDate;
        private ContractAction action;

        public ContractUpdateForm(Employee employee, Contract activeContract, ContractAction action, DepartmentStorage departments)
        {
            InitializeComponent();
            this.Visible = true;
            this.activeContract = activeContract;
            this.employee = employee;
            this.action = action;
            this.departmentStorage = departments;

            // Display active contract
            lvActiveContract.Items.Clear();
            ListViewItem item = new ListViewItem(this.activeContract.Iteration.ToString());
            lvActiveContract.Items.Add(item);
            string[] subitems = this.activeContract.ToString().Split(',');
            item.SubItems.AddRange(subitems);

            if (this.action == ContractAction.Extend)
            {
                pnlExtendContract.Visible = true;
                pnlExtendContract.Enabled = true;
                nudPromotion = null;
                dtpTerminateDate = null;
                cbPosition.DataSource = Enum.GetValues(typeof(PositionType));
                cbDepartment.Items.AddRange(departmentStorage.GetDepartments());

                cbPosition.SelectedItem = activeContract.Position;
                cbDepartment.SelectedItem = departmentStorage.GetDepartment(activeContract.Department.Id);
                nudFTE.Value = activeContract.Fte;

                rbEndOfPrevious.Checked = true;
                rbSameAsPrevious.Checked = true;

                dtpOtherStartDate.MinDate = DateTime.Today;

                lblAction.Text = "Add new contract:";
            }
            else
            {
                btnConfirm.Location = new Point(444, 95);
                this.Size = new Size(621, 177);

                if (this.action == ContractAction.Promote)
                {
                    // Display input for promotion
                    lblAction.Text = "Increase salary by:";
                    nudPromotion = new NumericUpDown
                    {
                        Increment = new decimal(1),
                        Location = new Point(176, 100),
                        Minimum = new decimal(1),
                        Maximum = new decimal(50),
                        Name = "nudPromotion",
                        Size = new Size(60, 24),
                        TabIndex = 3,
                        Value = new decimal(1)
                    };
                    dtpTerminateDate = null;
                    this.Controls.Add(nudPromotion);
                    Label lblPercent = new Label
                    {
                        AutoSize = true,
                        Location = new Point(242, 103),
                        Name = "lblPercent",
                        Size = new Size(21, 18),
                        Text = "%"
                    };
                    this.Controls.Add(lblPercent);
                }
                else if (this.action == ContractAction.Terminate)
                {
                    // Display input for terminating
                    lblAction.Text = "Terminate contract form:";
                    dtpTerminateDate = new DateTimePicker
                    {
                        Location = new Point(224, 100),
                        Name = "dtbTerminateDate",
                        Size = new Size(200, 24),
                        TabIndex = 3
                    };
                    nudPromotion = null;
                    this.Controls.Add(dtpTerminateDate);
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (action)
            {
                case ContractAction.Promote:
                    decimal precent = nudPromotion.Value;
                    try
                    {
                        activeContract.Promote(precent);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case ContractAction.Terminate:
                    DateTime terminateDate = dtpTerminateDate.Value;
                    try
                    {
                        activeContract.Terminate(terminateDate);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;

                case ContractAction.Extend:
                    // Retrieve details about new contract
                    DateTime startDate;
                    if (rbEndOfPrevious.Checked)
                    {
                        startDate = activeContract.EndDate.AddDays(1);
                    }
                    else
                    {
                        startDate = dtpOtherStartDate.Value;
                    }
                    int duration = Convert.ToInt32(nudDuration.Value);
                    DateTime endDate = startDate.AddMonths(duration);
                    int iteration;
                    if (activeContract != null)
                    {
                        iteration = activeContract.Iteration + 1;
                    }
                    else
                    {
                        iteration = 1;
                    }
                    PositionType position;
                    Department department;
                    decimal salary;
                    decimal fte;

                    if (rbChangeDetails.Checked)
                    {
                        position = (PositionType)cbPosition.SelectedItem;
                        department = (Department)cbDepartment.SelectedItem;
                        // TO DO: Add an input for a new salary
                        salary = activeContract.Salary;
                        fte = nudFTE.Value;
                    }
                    else
                    {
                        position = activeContract.Position;
                        department = activeContract.Department;
                        salary = activeContract.Salary;
                        fte = activeContract.Fte;
                    }

                    // Add the new contract
                    try
                    {
                        Contract contract = new Contract(-1, startDate, endDate, iteration, department, position, salary, fte);
                        employee.AddContract(contract);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
            }
        }

        private void rbEndOfPrevious_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEndOfPrevious.Checked)
            {
                dtpOtherStartDate.Enabled = false;
            }
            else
            {
                dtpOtherStartDate.Enabled = true;
            }
        }

        private void rbSameAsPrevious_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSameAsPrevious.Checked)
            {
                cbPosition.Enabled = false;
                cbDepartment.Enabled = false;
                nudFTE.Enabled = false;
            }
            else
            {
                cbPosition.Enabled = true;
                cbDepartment.Enabled = true;
                nudFTE.Enabled = true;
            }
        }


        // - - - - - - - - - - - - - - - - - - - - - - //
        // Managing the position and department inputs //
        // - - - - - - - - - - - - - - - - - - - - - - //

        private void cbPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PositionType selectedPosition = (PositionType)cbPosition.SelectedItem;
                switch (selectedPosition)
                {
                    case PositionType.Administrator:
                        cbDepartment.SelectedItem = departmentStorage.GetDepartment(6); // HR
                        cbDepartment.Enabled = false;
                        break;

                    case PositionType.Depot_Manager:
                    case PositionType.Depot_Worker:
                        cbDepartment.SelectedItem = departmentStorage.GetDepartment(5); // Warehouse
                        cbDepartment.Enabled = false;
                        break;

                    case PositionType.Sales_Manager:
                    case PositionType.Sales_Worker:
                        cbDepartment.SelectedItem = departmentStorage.GetDepartment(1); // Floor one
                        cbDepartment.Enabled = true;
                        break;

                    default:
                        cbDepartment.Enabled = true;
                        break;
                }
            }
            catch (Exception)
            {
                cbDepartment.Enabled = true;
            }
        }

        private void cbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                object position = cbPosition.SelectedItem;
                if (position != null)
                {
                    PositionType selectedPosition = (PositionType)position;
                    Department selectedDepartment = (Department)cbDepartment.SelectedItem;
                    if ((selectedPosition == PositionType.Sales_Manager ||
                        selectedPosition == PositionType.Sales_Worker) &&
                        (selectedDepartment == departmentStorage.GetDepartment(6) || // HR
                        selectedDepartment == departmentStorage.GetDepartment(5))) // Warehouse
                    {
                        cbDepartment.SelectedItem = departmentStorage.GetDepartment(1); // Floor one
                    }
                }
            }
            catch (Exception)
            {
                cbDepartment.Enabled = true;
            }
        }

    }
}
