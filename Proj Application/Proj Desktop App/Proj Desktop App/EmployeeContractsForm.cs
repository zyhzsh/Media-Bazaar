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
    public partial class EmployeeContractsForm : Form
    {
        public EmployeeContractsForm()
        {
            InitializeComponent();
        }

        private void btnFireEmployee_Click(object sender, EventArgs e)
        {
            string confirmQuestion = "Are you sure you want to fire this employee?";
            DialogResult confirmResult = MessageBox.Show(confirmQuestion, "Confirm cancel", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                //get employee based on bsn
                //int bsn = Convert.ToInt32(tbBSN.Text);
                //Employee employee = store.GetEmployee(bsn);
                //change employee status
                //if (employee != null)
                //{
                //    employee.UpdateStatus("Fired");
                //}
            }

        }
    }
}
