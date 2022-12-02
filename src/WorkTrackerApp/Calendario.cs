using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class Calendario : Form
    {
        public int IndiceMeses;
        public int IndicePrimerosDia, UlmitoDias;
        public int FechMin = 1583;
        public int FechMax = 3210;
        public Calendario()
        {
            InitializeComponent();
        }

        private void Calendario_Load(object sender, EventArgs e)
        {

        }

        private int EsBisiesto(int anio)
        {
            int SS = 0; //siglo
            int AA = 0; //año
            int Bisiesto = 0;
            SS = anio / 100;
            AA = anio - SS * 100;

            int numerodefor = AA % 4;
            int divisor = AA;
            int resto = 0;
            for (int i = 0; i <= numerodefor; i++)
            {
                resto = AA - 4;
                AA = resto;
            }

            if ((divisor >= 0) & (resto == 0))
            {
                Bisiesto = 1;
            }

            return Bisiesto;

        }

        private int NumeroDiasHastaFinesMese(int Anio, int mese)
        {
            int ndias = 31;
            switch (mese)
            {
                case 2:
                    ndias = 28 + EsBisiesto(Anio);
                    break;
                case 4:
                    ndias = 30;
                    break;
                case 6:
                    ndias = 30;
                    break;
                case 9:
                    ndias = 30;
                    break;
                case 11:
                    ndias = 30;
                    break;
            }
            return ndias;
        }

        private int IndiceDelDia(int anio, int nMes)
        {
            int X = 0;
            DateTime dat;
            try
            {
                dat = new DateTime(anio, nMes, 1);
                String dayWeek = dat.DayOfWeek.ToString();
                switch (dayWeek)
                {
                    case "Monday":
                        X = 1;
                        break;
                    case "Tuesday":
                        X = 2;
                        break;
                    case "Wednesday":
                        X = 3;
                        break;
                    case "Thursday":
                        X = 4;
                        break;
                    case "Friday":
                        X = 5;
                        break;
                    case "Saturday":
                        X = 6;
                        break;
                    case "Sunday":
                        X = 7;
                        break;

                }
            }
            catch (Exception e)
            {
                return -1;
            }

            return X;
        }

        private DataTable RellenarMeses(int mesRellenamos)
        {
            var dt = new DataTable();
            int largoMes = 1;
            int hastaMes = NumeroDiasHastaFinesMese(int.Parse(txbAnio.Text), mesRellenamos);


            dt.Columns.Add(new DataColumn("Lu", typeof(int)));
            dt.Columns.Add(new DataColumn("Ma", typeof(int)));
            dt.Columns.Add(new DataColumn("Mi", typeof(int)));
            dt.Columns.Add(new DataColumn("Ju", typeof(int)));
            dt.Columns.Add(new DataColumn("Vi", typeof(int)));
            dt.Columns.Add(new DataColumn("Sa", typeof(int)));
            dt.Columns.Add(new DataColumn("Do", typeof(int)));


            if (largoMes <= hastaMes)
            {
                int primerDia = IndiceDelDia(int.Parse(txbAnio.Text), mesRellenamos);

                //hace 5 lineas una por cada semana
                for (int nSemanas = 0; nSemanas < 6; nSemanas++)

                {
                    DataRow dr = dt.NewRow();

                    //hace 7 columnas una por cada dia
                    for (int diaSemana = 0; diaSemana < 7; diaSemana++)

                    {
                        int posicion = diaSemana + 2;
                        if (primerDia < posicion)
                        {
                            if (largoMes <= hastaMes)
                            {
                                dr[diaSemana] = largoMes;
                                largoMes++;
                            }
                            else
                            {
                                break;
                            }
                        }
                        if (largoMes > hastaMes)
                        {
                            break;
                        }

                    }
                    dt.Rows.Add(dr);
                    primerDia = 0;
                }

            }


            return dt;
        }

        public void PintarMeses()
        {            
                         
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = RellenarMeses(1);
            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = RellenarMeses(2);
            dataGridView3.Columns.Clear();
            dataGridView3.DataSource = RellenarMeses(3);
            dataGridView4.Columns.Clear();
            dataGridView4.DataSource = RellenarMeses(4);
            dataGridView5.Columns.Clear();
            dataGridView5.DataSource = RellenarMeses(5);
            dataGridView6.Columns.Clear();
            dataGridView6.DataSource = RellenarMeses(6);
            dataGridView7.Columns.Clear();
            dataGridView7.DataSource = RellenarMeses(7);
            dataGridView8.Columns.Clear();
            dataGridView8.DataSource = RellenarMeses(8);
            dataGridView9.Columns.Clear();
            dataGridView9.DataSource = RellenarMeses(9);
            dataGridView10.Columns.Clear();
            dataGridView10.DataSource = RellenarMeses(10);
            dataGridView11.Columns.Clear();
            dataGridView11.DataSource = RellenarMeses(11);
            dataGridView12.Columns.Clear();
            dataGridView12.DataSource = RellenarMeses(12);

        }


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            PintarMeses();
            MarcarFestivos();
        }

        private void Calendario_Load_1(object sender, EventArgs e)
        {

        }

        //private TextBox GetTxbAnio()
        //{
        //    return txbAnio.Value;
        //}

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var messageResult = MessageBox.Show("Quiere dar de alta este día como festivo.", "Dar de alta festivo", MessageBoxButtons.YesNo);
            if (messageResult == DialogResult.Yes)
            {
                DataGridView dataGrid =  (DataGridView)sender;
                var index = dataGrid.Name.Replace("dataGridView", "");
                int month = int.Parse(index);

                var  i = dataGrid.SelectedCells;
                int day = (int)i[0].Value;


                var apiclient = new CalendarApi("http://worktracker-001-site1.atempurl.com/");
                var calendar = new Calendar()
                {
                    Day = day,
                    Month = month,
                    Year = int.Parse(txbAnio.Text),
                    Festive = true
                };
                apiclient.ApiCalendarCreateFestivePut(calendar);
                MarcarFestivos();
                //int index =  vvv.SelectedCells.
            }
            string vv = "";

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MarcarFestivosGrid(ref DataGridView datagridView, int festive)
        {
            for (int i = 0; i < datagridView.Rows.Count; i++)
            {
                for (int j = 0; j < datagridView.Rows[i].Cells.Count; j++)
                {
                    datagridView.Rows[i].Cells[j].Style.BackColor = Color.White;             
                }
            }


            for (int i = 0; i < datagridView.Rows.Count; i++)
            {
                for (int j = 0; j < datagridView.Rows[i].Cells.Count; j++)
                {
                    int valueCell = 0;
                    int.TryParse(datagridView.Rows[i].Cells[j].Value?.ToString(), out valueCell);
                    if (valueCell == festive)
                    {
                        datagridView.Rows[i].Cells[j].Style.BackColor = Color.OrangeRed;
                    }
                }
            }
        } 

        private void MarcarFestivos()
        {
            var apiclient = new CalendarApi("http://worktracker-001-site1.atempurl.com/");
            var festives = apiclient.ApiCalendarGetFestiveByYearYearGet(2022);

            foreach( var festive in festives)
            {
               
                switch (festive.Month)
                {
                    case 1:
                        MarcarFestivosGrid(ref dataGridView1, festive.Day.Value);
                        break;
                    case 2:
                        MarcarFestivosGrid(ref dataGridView2, festive.Day.Value);
                        break;
                    case 3:
                        MarcarFestivosGrid(ref dataGridView3, festive.Day.Value);
                        break;
                    case 4:
                        MarcarFestivosGrid(ref dataGridView4, festive.Day.Value);
                        break;
                    case 5:
                        MarcarFestivosGrid(ref dataGridView5, festive.Day.Value);
                        break;
                    case 6:
                        MarcarFestivosGrid(ref dataGridView6, festive.Day.Value);
                        break;
                    case 7:
                        MarcarFestivosGrid(ref dataGridView7, festive.Day.Value);
                        break;
                    case 8:
                        MarcarFestivosGrid(ref dataGridView8, festive.Day.Value);
                        break;
                    case 9:
                        MarcarFestivosGrid(ref dataGridView9, festive.Day.Value);
                        break;
                    case 10:
                        MarcarFestivosGrid(ref dataGridView10, festive.Day.Value);
                        break;
                    case 11:
                        MarcarFestivosGrid(ref dataGridView11, festive.Day.Value);
                        break;
                    case 12:
                        MarcarFestivosGrid(ref dataGridView12, festive.Day.Value);
                        break;

                }
            }
        }

    }

}
