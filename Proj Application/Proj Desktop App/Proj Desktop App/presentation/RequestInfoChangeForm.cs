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
        public RequestInfoChangeForm()
        {
            InitializeComponent();
            RequestChangeStorage = new RequestChangeStorage();
            lvrequests.MultiSelect = true;
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
    }
}
