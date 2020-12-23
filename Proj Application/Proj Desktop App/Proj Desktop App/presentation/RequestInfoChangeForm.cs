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
    public partial class RequestInfoChangeForm : Form
    {
        private RequestInfoChange infoChange = new RequestInfoChange();
        private RequestChangeStorage RequestChangeStorage;
        private EmployeeCreateUpdateForm emplCUForm;
        private EmployeeStorage emplStorage;
        public RequestInfoChangeForm()
        {
            InitializeComponent();
            RequestChangeStorage = new RequestChangeStorage();
            this.emplStorage = new EmployeeStorage();
            lvrequests.MultiSelect = true;
            lvrequests.FullRowSelect = true;
            GUI();
        }
        public void GUI()
        {
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
                lvrequests.Items.Add(item);
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {

            if (lvrequests.SelectedItems != null)
            {
                ListViewItem item = lvrequests.SelectedItems[0];
                int BSN = Convert.ToInt32(item.SubItems[0].Text);
                Employee employee = RequestChangeStorage.GetEmployeeByBsn(BSN);
                // Open form for updating an employee's details
                emplCUForm = new EmployeeCreateUpdateForm(emplStorage, employee);
                RequestChangeStorage.DeleteRequest(BSN);
            }
            else
            {
                MessageBox.Show("Please select an employee form the list to procces the request.");
            }
        }
    }
}
