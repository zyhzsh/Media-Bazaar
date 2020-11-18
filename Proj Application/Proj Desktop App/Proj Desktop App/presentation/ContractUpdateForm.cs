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
        private Contract contract;
        private NumericUpDown nudPromotion;
        private DateTimePicker dtpTerminateDate;
        private bool promotion;

        public ContractUpdateForm(Contract contract, bool promotion)
        {
            InitializeComponent();
            this.Visible = true;
            this.contract = contract;
            this.promotion = promotion;

            // Display active contract
            lvActiveContract.Items.Clear();
            ListViewItem item = new ListViewItem(this.contract.Iteration.ToString());
            lvActiveContract.Items.Add(item);
            string[] subitems = this.contract.ToString().Split(',');
            item.SubItems.AddRange(subitems);

            if (this.promotion)
            {
                // Display input for promotion
                lblAction.Text = "Increase salary by:";
                nudPromotion = new NumericUpDown
                {
                    Increment = new decimal(1),
                    Location = new Point(337, 111),
                    Minimum = new decimal(1),
                    Maximum = new decimal(50),
                    Name = "nudPromotion",
                    Size = new Size(60, 24),
                    //nudPromotion.TabIndex = 33;
                    Value = new decimal(1)
                };
                dtpTerminateDate = null;
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
                // Display input for terminating
                lblAction.Text = "Terminate contract form:";
                dtpTerminateDate = new DateTimePicker
                {
                    Location = new Point(224, 111),
                    Name = "dtbTerminateDate",
                    Size = new Size(200, 24)
                    //TabIndex = 30;
                };
                nudPromotion = null;
                this.Controls.Add(dtpTerminateDate);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (promotion)
            {
                // Promote
                decimal precent = nudPromotion.Value;
                try
                {
                    contract.Promote(precent);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                // Terminate
                DateTime endDate = dtpTerminateDate.Value;
                try
                {
                    contract.Terminate(endDate);
                    this.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
