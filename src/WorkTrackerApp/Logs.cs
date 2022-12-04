using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WorkTrackerAPP
{

    public partial class Logs : Form
    {



        private List<Log> logs;
        public Logs()
        {
            InitializeComponent();
        }


        private void Logs_Load(object sender, EventArgs e)
        {
            var apiLogs = new LogApi("http://worktracker-001-site1.atempurl.com/");
            logs = apiLogs.ApiLogGetLogsByDateGet(DateTime.Now);


        }

        private void cmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            
            dgvLogs.DataSource = logs.Where(x => x.Level.Equals(cmbTipo.Text));

            dgvLogs.Refresh();
        

        }
    }
}
