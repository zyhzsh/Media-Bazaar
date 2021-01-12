using Proj_Desktop_App.dataAccess;
using System;
using System.Windows.Forms;

namespace Proj_Desktop_App
{
    public partial class LoginForm : Form
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
        //
        // SALES MANAGER:
        // Username: chammon7
        // Password: XJlA0h

        // ALT SALES MANAGER:
        // Username: mood
        // Password: 123

        private LoginHandler loginHandler;

        public LoginForm()
        {
            InitializeComponent();
            loginHandler = new LoginHandler();

            // For testing purposes:
            tbLogInUsername.Text = "jguttridge4";
            tbLogInPassword.Text = "uYFLTrkmOqVq";
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            int bsn = loginHandler.Login(tbLogInUsername.Text, tbLogInPassword.Text);

            // Credentials are correct
            if (bsn != -1)
            {
                // Load departments from DB
                DepartmentStorage departments = new DepartmentStorage();

                // Open app for particualr employee
                EmployeeManagement emplMan = new EmployeeManagement(departments);
                Employee currentUser = emplMan.GetEmployee(bsn);

                if (currentUser != null)
                {
                    if (currentUser.IsEmployed())
                    {
                        new MainForm(this, currentUser, departments);
                        this.Visible = false;
                        tbLogInUsername.Clear();
                        tbLogInPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("You no longer have permision to log in to the application.");
                    }
                }
                else
                {
                    MessageBox.Show("Login failed.");
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password.");
            }
        }

        private void tbLogInUsername_KeyDown(object sender, KeyEventArgs e)
        {
            // Login on pressing Enter
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(this, new EventArgs());
            }
        }

        private void tbLogInPassword_KeyDown(object sender, KeyEventArgs e)
        {
            // Login on pressing Enter
            if (e.KeyCode == Keys.Enter)
            {
                btLogin_Click(this, new EventArgs());
            }
        }
    }
}
