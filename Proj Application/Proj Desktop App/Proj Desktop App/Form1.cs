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
           
        }

        private void btStatistics_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            Scheduling a = new Scheduling();
            a.Show();
        }
    }
}
