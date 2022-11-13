using IO.Swagger.Api;
using System;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class Fichar : Form
    {

        public static Estados estado;

        public enum Estados
        {
            Fuera       = 0,
            Entrada     = 1,
            Comiendo    = 2,
            Comido      = 3,
            Descansando = 4,
            Saliendo    = 5,
        }



        public Fichar()
        {
            InitializeComponent();

            
        }

        private void CargarFichajes(int id)
        {
            var apiclient = new ClockInApi("http://worktracker-001-site1.atempurl.com/");
            var userTypes = apiclient.ApiClockInGetClockInsByUserIdIdGet(id);
            UserSession.Fichajes = userTypes;
            estado = Estados.Fuera;
            MaquinaEstados();
        }

        private void AnalizarFichajes()
        {
          


        }
        

        private void Fichar_Load(object sender, EventArgs e)
        {
            CargarFichajes((int)UserSession.User.IdUser);
            estado = 0;
            MaquinaEstados();
        }

        private void MaquinaEstados()
        {
            switch (estado)
            {

                /// Estado Inicial de un usuario cuando todavía no ha hecho ningún fichaje en el día
                case Estados.Fuera:
                    btnJornada.Enabled = true;
                    btnJornada.Text = "Entrada";
                    btnComida.Enabled = false;
                    btnComida.Text = "Comida";
                    btnDescanso.Enabled = false;
                    btnDescanso.Text = "Descanso";
                break;
                case Estados.Entrada:
                    btnJornada.Enabled = true;
                    btnJornada.Text = "Salida";
                    btnComida.Enabled = true;
                    btnComida.Text = "Comida";
                    btnDescanso.Enabled = true;
                    btnDescanso.Text = "Descanso";
                    break;
                case Estados.Comiendo:
                    btnJornada.Enabled = true;
                    btnJornada.Text = "Salida";
                    btnComida.Enabled = true;
                    btnComida.Text = "Volver Comida";
                    btnDescanso.Enabled = false;
                    btnDescanso.Text = "Descanso";
                    break;
                case Estados.Comido:
                    btnJornada.Enabled = true;
                    btnJornada.Text = "Salida";
                    btnComida.Enabled = false;
                    btnComida.Text = "Comida Completada";
                    btnDescanso.Enabled = true;
                    btnDescanso.Text = "Descanso";
                    break;
                case Estados.Descansando:
                    btnJornada.Enabled = false;
                    btnJornada.Text = "Salida";
                    btnComida.Enabled = false;
                    btnComida.Text = "Comida";
                    btnDescanso.Enabled = true;
                    btnDescanso.Text = "Volver Descanso";
                    break;
                case Estados.Saliendo:
                    btnJornada.Enabled = false;
                    btnJornada.Text = "Salida";
                    btnComida.Enabled = false;
                    btnComida.Text = "Comida";
                    btnDescanso.Enabled = false;
                    btnDescanso.Text = "Descanso";
                    break;
            }   
        }

        private void btnJornada_Click(object sender, EventArgs e)
        {
            if (estado == Estados.Fuera)
            {
                estado = Estados.Entrada;              
            }

            else if (estado == Estados.Entrada)
            {
                estado = Estados.Saliendo;
            }
            MaquinaEstados();
        }

        private void btnComida_Click(object sender, EventArgs e)
        {
            
            if (estado == Estados.Entrada)
            {
                estado = Estados.Comiendo;
            }
            else if (estado == Estados.Comiendo)
            {
                estado = Estados.Comido;

            }
            MaquinaEstados();
        }

        private void btnDescanso_Click(object sender, EventArgs e)
        {
            if (estado == Estados.Entrada || estado == Estados.Comido)
            {
                estado = Estados.Descansando;
            }

            if (estado == Estados.Descansando)
            {
                estado = Estados.Entrada; //Hay que ver que hacer con el estado Comido
            }

            MaquinaEstados();
        }
    }
}
