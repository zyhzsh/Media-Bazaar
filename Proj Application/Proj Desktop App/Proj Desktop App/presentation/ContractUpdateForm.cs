using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public partial class ContractUpdateForm : Form
    {
        public ContractUpdateForm(EmployeeStorage store, Employee employee, bool promotion)
        {
            InitializeComponent();
            this.Visible = true;
            if (promotion)
            {
                lblAction.Text = "Increase salary by:";
                NumericUpDown nudPromotion = new NumericUpDown
                {
                    Increment = new decimal(new int[] { 5, 0, 0, 0 }),
                    Location = new Point(337, 111),
                    Minimum = new decimal(new int[] { 1, 0, 0, 0 }),
                    Name = "nudPromotion",
                    Size = new Size(60, 24),
                    //nudPromotion.TabIndex = 33;
                    Value = new decimal(new int[] { 1, 0, 0, 0 })
                };
                this.Controls.Add(nudPromotion);
                Label lblPercent = new Label
                {
                    AutoSize = true,
                    Location = new Point(403, 111),
                    Name = "lblPercent",
                    Size = new Size(21, 18),
                    //lblPercent.TabIndex = 34;
                    Text = "%"
                };
                this.Controls.Add(lblPercent);
            }
            else
            {
                lblAction.Text = "Terminate contract form:";
                DateTimePicker dtpTerminateDate = new DateTimePicker
                {
                    Location = new Point(224, 111),
                    Name = "dtbTerminateDate",
                    Size = new Size(200, 24)
                    //TabIndex = 30;
                };
                this.Controls.Add(dtpTerminateDate);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
           // DateTime dateTime = this.dtpTerminateDate.Value;
        }
    }
}
