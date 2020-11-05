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
        // Login credentials:
        //
        // ADMINISTRATOR:
        // Username: jguttridge4
        // Password: uYFLTrkmOqVq
        //
        // DEPOT MANAGER:
        // Username: gdambrogi6
        // Password: LbZAsgys63h
        //
        // DEPOT WORKER:
        // Username: rgrisleyf
        // Password: RaX3pQ1P

        private Store mediaBazaar;
        private LoginHandler loginHandler;

        public Form1()
        {
            InitializeComponent();
            mediaBazaar = new Store();
            loginHandler = new LoginHandler();
            tbLogInUsername.Text = "gdambrogi6";
            tbLogInPassword.Text = "LbZAsgys63h";
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            PositionType position = loginHandler.CheckLogin(tbLogInUsername.Text, tbLogInPassword.Text);

            // Credentials are correct
            if (position != PositionType.Other)
            {
                // Open app for particualr position
                new MainForm(this, mediaBazaar, position);
                this.Visible = false;
                tbLogInUsername.Clear();
                tbLogInPassword.Clear();
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void tbLogInUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(this, new EventArgs());
            }
        }

        private void tbLogInPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(this, new EventArgs());
            }
        }
    }
}
