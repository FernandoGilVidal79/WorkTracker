using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Collections.Generic;
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
            var apiLogs = new LogApi(UserSession.APIUrl);
            logs = apiLogs.ApiLogGetLogsByDateGet(DateTime.Now);
            dgvLogs.DataSource = logs;

        }


    }
}
