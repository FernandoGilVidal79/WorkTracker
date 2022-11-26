using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class Fichar : Form
    {
        private const string Format = "yyyy-MM-dd HH:mm:ss";
        public static Estados estado;

        public enum Estados
        {
            Fuera = 0,
            Entrada = 1,
            Comiendo = 2,
            Comido = 3,
            Descansando = 4,
            Descansado = 5,
            Saliendo = 6,
        }

        public int contadorComida = 0;


        public Fichar()
        {
            InitializeComponent();


        }

        private void CargarFichajes(int id)
        {

            var apiclient = new ClockInApi("http://worktracker-001-site1.atempurl.com/");

            var userTypes = apiclient.ApiClockInGetClockInsByUserIdIdGet(id);
            
            UserSession.Fichajes = userTypes;
            try
            {
                if (UserSession.Fichajes != null)
                    MostrarHistoricoFichajes();
                else
                    lblHistorico.Text = "No hay fichajes registrados aún";

            }
            catch (IO.Swagger.Client.ApiException ex)
            {
                toolStripStatusLabel1.Text = "Error al Obtener el usuario" + ex;
            }

        }


        private void MostrarHistoricoFichajes()
        {
            
            for (int i = 0; i < UserSession.Fichajes.Count; i++)
            {
                if(i > 0)
                {
                    if (UserSession.Fichajes[i].Date != UserSession.Fichajes[i - 1].Date)
                    {
                        Console.WriteLine(UserSession.Fichajes[i]);
                        lblHistorico.Text += UserSession.Fichajes[i];
                    }
                }

            }

        }


        private void Fichaje(int clkType)
        {
            
            //Marcaje realizado
            Console.WriteLine("Clockin Type " + clkType);
            var clockin = new Clockin();
            clockin.UserId = UserSession.User.IdUser;
            clockin.Date = DateTime.Now;
            
            //clockin.FinishHour;
            

            var apiclient = new ClockInApi("http://worktracker-001-site1.atempurl.com/");
            try
            {
                if (estado.ToString() == "Fuera")
                {
                    clockin.ClockinTypeId = 1;
                    clockin.StartHour = DateTime.Now;
                    //apiclient.ApiClockInClockInPut(clockin);
                }
                if (estado.ToString() == "Entrada")
                {
                    clockin.ClockinTypeId = 1;
                }
                if (estado.ToString() == "Comiendo")
                {
                    clockin.ClockinTypeId = 2;
                }
                if (estado.ToString() == "Comido")
                {
                    clockin.ClockinTypeId = 2;
                }
                if (estado.ToString() == "Descansando")
                {
                    clockin.ClockinTypeId = 3;
                }
                if (estado.ToString() == "Descansado")
                {
                    clockin.ClockinTypeId = 3;
                    Console.WriteLine("Descansado "+clockin.ClockinTypeId);
                }
                lblResumen.Text = "Fichaje Realizado";

            }
            catch (IO.Swagger.Client.ApiException ex)
            {
                toolStripStatusLabel1.Text = "Error al fichar" + ex;
            }
            lblHistorico.Text = "Estado";

            //Actualizar datos
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
                    if (contadorComida == 1)
                        btnComida.Enabled = false;
                    else
                        btnComida.Enabled = true;
                    btnComida.Text = "Comida";
                    btnDescanso.Enabled = true;
                    btnDescanso.Text = "Descanso";
                    break;
                case Estados.Comiendo:
                    btnJornada.Enabled = false;
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
                    btnComida.Text = "Comida";
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
                case Estados.Descansado:
                    btnJornada.Enabled = true;
                    btnJornada.Text = "Salida";
                    if (contadorComida == 1)
                        btnComida.Enabled = false;
                    else
                        btnComida.Enabled = true;
                    btnComida.Text = "Comida";
                    btnDescanso.Enabled = true;
                    btnDescanso.Text = "Descanso";
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
            //Realizamos un fichaje
            
            if (estado == Estados.Fuera)
            {
                estado = Estados.Entrada;
                Fichaje(1);

            }

            else if (estado == Estados.Entrada || estado == Estados.Comido || estado == Estados.Descansado)
            {
                estado = Estados.Saliendo;
                Fichaje(3);
            }
            MaquinaEstados();
            
        }

        private void btnComida_Click(object sender, EventArgs e)
        {

            if (estado == Estados.Entrada || estado == Estados.Descansado)
            {
                contadorComida = 1;
                estado = Estados.Comiendo;
                Fichaje(2);
            }
            else if (estado == Estados.Comiendo)
            {
                estado = Estados.Comido;
                Fichaje(2);

            }
            MaquinaEstados();
            
        }

        private void btnDescanso_Click(object sender, EventArgs e)
        {
            lblHistorico.Text = "pulsado";
            Console.WriteLine("pulsado: ");
            Console.WriteLine("Contador Comida: " + contadorComida);
            if (estado == Estados.Entrada || estado == Estados.Comido)
            {
                estado = Estados.Descansando;
            }

            else if (estado == Estados.Descansando)
            {
                estado = Estados.Descansado; //Hay que ver que hacer con el estado Comido
            }

            MaquinaEstados();
            Fichaje(3);
        }

    }
}
