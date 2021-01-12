using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proj_Desktop_App.presentation
{
    public partial class RequestInfoChangeForm : Form
    {
        private RequestChangeStorage RequestChangeStorage;
        private EmployeeCreateUpdateForm emplCUForm;
        private EmployeeStorage emplStorage;
        Employee selectedEmployee;
        Employee newEmployee;
        private DepartmentStorage departments;
        public RequestInfoChangeForm(EmployeeStorage employeeStorage, DepartmentStorage departments)
        {
            InitializeComponent();
            RequestChangeStorage = new RequestChangeStorage(departments);
            this.emplStorage = employeeStorage;
            newEmployee = null;
            lvrequests.MultiSelect = true;
            lvrequests.FullRowSelect = true;
            GUI();
            this.departments = departments;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            try
            {
                ListViewItem item = lvrequests.SelectedItems[0];
                int BSN = Convert.ToInt32(item.SubItems[0].Text);
                Employee employee = GetEmployeeToUbdate();
                // Open form for updating an employee's details
                emplCUForm = new EmployeeCreateUpdateForm(emplStorage, employee, departments);
                //creat an event to detect when form closed to ubdate the info
                this.emplCUForm.FormClosed += new FormClosedEventHandler(EmployeeCreateUpdateForm_FormClosed);
                //Delet the request from database after ubdating
                GUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an employee form the list to accept the request.");
                MessageBox.Show(ex.ToString());
            }
        }
        void EmployeeCreateUpdateForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GUI();
        }

        private void brnReject_Click(object sender, EventArgs e)
        {
            try
            {
                ListViewItem item = lvrequests.SelectedItems[0];
                int BSN = Convert.ToInt32(item.SubItems[0].Text);
                //Delet the request from database 
                RequestChangeStorage.DeleteRequest(BSN);
                GUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please select an employee form the list to reject the request.");
                MessageBox.Show(ex.ToString());
            }
        }
        public Employee GetEmployeeToUbdate()
        {
            try
            {
                ListViewItem item = lvrequests.SelectedItems[0];
                int BSN = Convert.ToInt32(item.SubItems[1].Text);
                string firstName = Convert.ToString(item.SubItems[2].Text);
                string lastName = Convert.ToString(item.SubItems[3].Text);
                char gender = Convert.ToChar(item.SubItems[4].Text);
                string phoneNumber = Convert.ToString(item.SubItems[4].Text);
                // DateTime birthDate = Convert.ToDateTime(item.SubItems[0].Text)
                string address = Convert.ToString(item.SubItems[5].Text);
                string certificates = Convert.ToString(item.SubItems[6].Text);
                string Email = Convert.ToString(item.SubItems[7].Text);
                string languages = Convert.ToString(item.SubItems[8].Text);
                Employee oldEmployee = null;
                oldEmployee = RequestChangeStorage.GetEmployeeByBsn(BSN);

                // Set information to update
                if (firstName == null) { firstName = oldEmployee.firstName; }
                if (lastName == null) { lastName = oldEmployee.lastName; }
                if (gender.ToString() == null) { gender = oldEmployee.gender; }
                if (certificates == null) { certificates = oldEmployee.certificates; }
                if (languages == null) { languages = oldEmployee.languages; }
                if (phoneNumber == null) { phoneNumber = oldEmployee.phoneNumber; }
                if (address == null) { address = oldEmployee.address; }
                if (Email == null) { address = oldEmployee.contactEmail; }

                //ubdate old info employee
                newEmployee = new Employee(oldEmployee.GetBSN(), firstName, lastName, gender, oldEmployee.birthDate, languages, certificates, phoneNumber, address, Email);
                return newEmployee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;

        }
        public Employee GetNewEmployee()
        {
            try
            {
                ListViewItem item = lvrequests.SelectedItems[0];
                int BSN = Convert.ToInt32(item.SubItems[0].Text);
                string firstName = Convert.ToString(item.SubItems[1].Text);
                string lastName = Convert.ToString(item.SubItems[2].Text);
                char gender = Convert.ToChar(item.SubItems[3].Text);
                string phoneNumber = Convert.ToString(item.SubItems[4].Text);
                // DateTime birthDate = Convert.ToDateTime(item.SubItems[0].Text)
                string address = Convert.ToString(item.SubItems[4].Text);
                string certificates = Convert.ToString(item.SubItems[5].Text);
                string Email = Convert.ToString(item.SubItems[6].Text);
                string languages = Convert.ToString(item.SubItems[7].Text);
                Employee oldEmployee = null;
                oldEmployee = RequestChangeStorage.GetEmployeeByBsn(BSN);


                //ubdate old info employee
                newEmployee = new Employee(oldEmployee.GetBSN(), firstName, lastName, gender, oldEmployee.birthDate, languages, certificates, phoneNumber, address, Email);
                return newEmployee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;

        }
        public void GUI()
        {
            lvrequests.Items.Clear();
            RequestInfoChange[] temp = RequestChangeStorage.GetRequestInfoChanges();
            foreach (RequestInfoChange request in temp)
            {
                ListViewItem item = new ListViewItem(request.BSN.ToString());
                item.SubItems.Add(request.firstName);
                item.SubItems.Add(request.lastName);
                item.SubItems.Add(request.gender.ToString());
                item.SubItems.Add(request.phoneNumber);
                item.SubItems.Add(request.address);
                item.SubItems.Add(request.languages);
                item.SubItems.Add(request.certificates);
                item.SubItems.Add(request.contactEmail);
             //   item.it.SubItems[0].ForeColor = System.Drawing.Color.Red;
                lvrequests.Items.Add(item);
            //    lvrequests.Items[0].SubItems[0].ForeColor = System.Drawing.Color.Red;
            }
        }

        private void lvrequests_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indices = lvrequests.SelectedIndices;
            if (indices.Count >0)
            {
                GetNewEmployee();
                string item = lvrequests.SelectedItems[0].SubItems[0].Text;
                int BSN = Convert.ToInt32(item);
                selectedEmployee = RequestChangeStorage.GetEmployeeByBsn(BSN);
                if (selectedEmployee != null)
                {
             
                    //Compare new info with old info
                    if (newEmployee.firstName != selectedEmployee.firstName|| newEmployee.lastName != selectedEmployee.lastName) { lblNames.ForeColor=Color.Red; }
                    if (newEmployee.gender.ToString() != selectedEmployee.gender.ToString()) { lblGender.ForeColor = Color.Red; }
                    if (newEmployee.certificates != selectedEmployee.certificates) { lblCertificates.ForeColor = Color.Red; }
                    if (newEmployee.languages.Trim() != selectedEmployee.languages.Trim()) { lblLanguages.ForeColor = Color.Red; }
                    if (newEmployee.phoneNumber != selectedEmployee.phoneNumber) { lblPhone.ForeColor = Color.Red; }
                    if (newEmployee.address.Trim() != selectedEmployee.address.Trim()) { lblAddress.ForeColor = Color.Red; }
                    if (string.Compare(newEmployee.contactEmail ,selectedEmployee.contactEmail)==null) { lblEmail.ForeColor = Color.Red; }
                    // Show employee details:
                    lblNames.Text = $"{selectedEmployee.firstName} {selectedEmployee.lastName}";
                    lblBSN.Text = selectedEmployee.GetBSN().ToString();
                    lblGender.Text = selectedEmployee.gender.ToString();
                    lblBirthdate.Text = selectedEmployee.birthDate.ToString("dd/MM/yyyy");
                    lblLanguages.Text = selectedEmployee.languages;
                    lblCertificates.Text = selectedEmployee.certificates;
                    lblPhone.Text = selectedEmployee.phoneNumber;
                    lblEmail.Text = selectedEmployee.contactEmail;
                    lblAddress.Text = selectedEmployee.address;

                    // Show employee status:
                    bool employed = selectedEmployee.IsEmployed();
                    if (employed)
                    {
                        lblEmployed.Text = "employed";
                    }
                    else
                    {
                        lblEmployed.Text = "unemployed";
                    }
                }
            }
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            GUI();
        }
    }
}
