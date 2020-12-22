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
        private RequestInfoChange requestInfoChanges;
        public RequestInfoChangeForm()
        {
            InitializeComponent();
            requestInfoChanges = new RequestInfoChange();
            GUI();
        }
        public void GUI()
        {
            listBox1.DataSource = requestInfoChanges.GetRequestInfos();
        }
    }
}
