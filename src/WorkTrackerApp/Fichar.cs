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
    public partial class Fichar : Form
    {
        public Fichar()
        {
            InitializeComponent();
            
        }

        private void Fichar_Load(object sender, EventArgs e)
        {

        }

        private void btnJornada_Click(object sender, EventArgs e)
        {
            btnJornada.Text = "Salida";
        }
    }
}
