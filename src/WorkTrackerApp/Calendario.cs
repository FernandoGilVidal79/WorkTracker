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
        { int SS = 0; //siglo
            int AA =0; //año
            int Bisiesto = 0;
            SS = anio / 100;
            AA = anio - SS * 100;

            int numerodefor = AA % 4;
            int divisor = AA;
            int resto = 0;
            for(int i=0;i<= numerodefor; i++)
            {
                resto = AA - 4;
                AA = resto;
            }
            
            if ((divisor >= 0)&(resto ==  0 )) 
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
            int X= 0;
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


            if (largoMes < hastaMes + 1)
            {
                int primerDia = IndiceDelDia(int.Parse(txbAnio.Text), mesRellenamos);

                //hace 5 lineas una por cada semana
                for (int nSemanas = 0; nSemanas < 5; nSemanas++)

                {
                    DataRow dr = dt.NewRow();

                    //hace 7 columnas una por cada dia
                    for (int diaSemana = 0; diaSemana < 7; diaSemana++)

                    {
                        int posicion = diaSemana + 2;


                        if (primerDia < posicion)
                        {
                            dr[diaSemana] = largoMes;
                            largoMes++;
                        }

                    }
                    dt.Rows.Add(dr);
                    primerDia = 0;
                }

            }


            return dt;
        }

        public void PoderMeses()
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
            PoderMeses();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
    
}
