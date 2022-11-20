using IO.Swagger.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class Logs : Form
    {
        public Logs()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Logs_Load(object sender, EventArgs e)
        {
           // var apiUsers = new UserApi("http://worktracker-001-site1.atempurl.com/");
           // var absensesTypes = apiUsers.ApiUserGetUsersGet();
        }
    }
}
