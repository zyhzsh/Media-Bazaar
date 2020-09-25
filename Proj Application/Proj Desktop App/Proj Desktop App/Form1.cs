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
    public partial class Form1 : Form
    {
        private Store mediaBazaar;
        private Login login;

        public Form1()
        {
            InitializeComponent();
            mediaBazaar = new Store();
            login = new Login();
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            if (login.CheckLogin(textBox1.Text, textBox2.Text))
            {
                PositionType positionType = login.CheckPossition;
                switch(positionType){
                    case PositionType.Administrator:
                        //open admin form
                        break;
                    case PositionType.Depot_Manager:
                        //open depot_man form
                        //EmployeeStatistics employeeStatistics = new EmployeeStatistics();
                        //employeeStatistics.Visible = true;
                        // OR
                        //make button visisble
                        //btStatistics.Visible = true;
                        break;
                    case PositionType.Sales_Manager:
                        //open Sale_manager form
                        break;
                    case PositionType.Depot_Worker:
                        //open Depot_worker form
                        break;
                }
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void btStatistics_Click(object sender, EventArgs e)
        {

        }
    }
}
