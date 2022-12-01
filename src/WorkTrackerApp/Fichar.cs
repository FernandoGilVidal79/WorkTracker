using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Windows.Forms;
using System.Linq;

namespace WorkTrackerAPP
{
    public partial class Fichar : Form
    {
        private const string Format = "dd/M/yyyy";
        private const string FormatHora = "HH:mm:ss";
        public static Estados estado;
        public static EstadoComida estadoComida;
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
        public enum EstadoComida
        {
            Fuera = 0,
            SinComer = 1,
            Comiendo = 2,
            Comido = 3

        }
        public static int contadorComida = 0;


        public Fichar()
        {
            InitializeComponent();
        }

        private void CargarFichajesHoy()
        {
            var apiclient = new ClockInApi("http://worktracker-001-site1.atempurl.com/");
            var userClockIn = apiclient.ApiClockInGetClockInsTodayByUserIdIdGet((int)UserSession.User.IdUser);
            UserSession.FichajesHoy = userClockIn;
        }

        private Estados GetEstadosByFichajes()
        {
            var fichajesActuales = UserSession.FichajesHoy;
            Estados estado;
            if (!fichajesActuales.Any(x => x.ClockinTypeId == 1))
            {
                return Estados.Fuera;
            }
            else if (fichajesActuales.Any(x => x.ClockinTypeId == 1 && x.FinishHour != null))
            {
                return Estados.Saliendo;
            }
            else if (fichajesActuales.Any(x => x.ClockinTypeId == 2 && x.FinishHour == null))
            {
                return Estados.Comiendo;
            }
            else if (fichajesActuales.Any(x => x.ClockinTypeId == 2 && x.FinishHour != null))
            {
                estado = Estados.Comido;
            }
            if (fichajesActuales.Any(x => x.ClockinTypeId == 2 && x.FinishHour == null))
            {
                estado = Estados.Descansado;
            }
            return Estados.Entrada;
        }

        private void CargarFichajes(int id)
        {

            var apiclient = new ClockInApi("http://worktracker-001-site1.atempurl.com/");
            var fichajesUsuario = apiclient.ApiClockInGetClockInsByUserIdIdGet(id);

            if (fichajesUsuario.Count > 0)
            {
                var ultimoFichaje = fichajesUsuario.Last();
                var ffechaUltimoFichaje = Convert.ToDateTime(ultimoFichaje.Date).ToString(Format);
                var ffechaActual = Convert.ToDateTime(DateTime.Now).ToString(Format);
                UserSession.Fichajes = fichajesUsuario;
                try
                {
                    if (UserSession.Fichajes != null)
                    {
                        if (ffechaUltimoFichaje != ffechaActual)
                        {
                            MostrarHistoricoFichajes();
                        }
                        else
                        {
                            lblResumen.Text = "Jornada de hoy: " + ffechaActual.ToString();

                            switch (ultimoFichaje.ClockinTypeId)
                            {
                                case 1:
                                    if (ultimoFichaje.FinishHour.ToString() == "")
                                    {
                                        var hora = Convert.ToDateTime(DateTime.Now).ToString(FormatHora);
                                        lblHistorico.Text = "Hora de entrada: " + hora.ToString();
                                        estado = Estados.Entrada;
                                    }
                                    else
                                    {
                                        var hora = Convert.ToDateTime(DateTime.Now).ToString(FormatHora);
                                        lblHistorico.Text = "Hora de salida: " + hora.ToString();
                                        estado = Estados.Fuera;
                                    }
                                    break;

                                case 2:
                                    if (ultimoFichaje.FinishHour.ToString() == "")
                                    {
                                        var hora = Convert.ToDateTime(DateTime.Now).ToString(FormatHora);
                                        lblHistorico.Text = "Hora de entrada: " + hora.ToString();
                                        estado = Estados.Comiendo;

                                    }
                                    else
                                    {
                                        var hora = Convert.ToDateTime(DateTime.Now).ToString(FormatHora);
                                        lblHistorico.Text = "Hora de salida: " + hora.ToString();
                                        estado = Estados.Comido;

                                    }
                                    break;

                                case 3:
                                    if (ultimoFichaje.FinishHour.ToString() == "")
                                    {
                                        var hora = Convert.ToDateTime(DateTime.Now).ToString(FormatHora);
                                        lblHistorico.Text = "Hora de entrada: " + hora.ToString();
                                        estado = Estados.Descansando;
                                    }
                                    else
                                    {
                                        var hora = Convert.ToDateTime(DateTime.Now).ToString(FormatHora);
                                        lblHistorico.Text = "Hora de salida: " + hora.ToString();
                                        estado = Estados.Descansado;
                                    }
                                    break;

                                default:
                                    MostrarHistoricoFichajes();
                                    break;

                            }

                        }
                    }

                    else
                        lblHistorico.Text = "No hay fichajes registrados aún";

                }
                catch (IO.Swagger.Client.ApiException ex)
                {
                    // toolStripStatusLabel1.Text = "Error al Obtener el usuario" + ex;
                }
            }

        }


        private void MostrarHistoricoFichajes()
        {
            lblHistorico.Text = "";
            int contadorFichajes = 0;
            for (int i = UserSession.Fichajes.Count - 1; i > 0; i--)
            {
                //Helper.MensajeError(i.ToString(), "error");
                //if(i == UserSession.Fichajes.Count - 5)
                //{

                if (UserSession.Fichajes[i].Date != UserSession.Fichajes[i - 1].Date)
                {
                    if (UserSession.Fichajes[i].ClockinTypeId == 1)
                    {
                        //Helper.MensajeError("Contador Fichajes" + contadorFichajes, "Error");
                        var ffecha = Convert.ToDateTime(UserSession.Fichajes[10].Date).ToString(Format);
                        Console.WriteLine(UserSession.Fichajes[i]);
                        lblHistorico.Text += "ID; " + UserSession.Fichajes[i].ClockinTypeId;
                        lblHistorico.Text += "\n";
                        lblHistorico.Text += "Fecha: " + ffecha;
                        lblHistorico.Text += "\n";
                        lblHistorico.Text += "Hora de entrada:" + UserSession.Fichajes[i].StartHour;
                        lblHistorico.Text += "\n";
                        lblHistorico.Text += "Hora de salida: " + UserSession.Fichajes[i].FinishHour;
                        lblHistorico.Text += "\n-------------------------------------------------\n";
                        //contadorFichajes++;
                    }

                }
                contadorFichajes++;

                //}


            }

        }


        private void Fichaje()
        {
            //Declaramos las variables
            var clockin = new Clockin();
            clockin.UserId = UserSession.User.IdUser;
            clockin.Date = DateTime.Now;
            var apiclient = new ClockInApi("http://worktracker-001-site1.atempurl.com/");

            try
            {
                //Realizar un marcaje por estado
                if (estado == Estados.Entrada)
                {
                    clockin.ClockinTypeId = 1;
                    clockin.StartHour = DateTime.UtcNow;
                    clockin.FinishHour = null;
                    apiclient.ApiClockInClockInPut(clockin);
                }
                else if (estado == Estados.Saliendo)
                {
                    var fichaje = UserSession.FichajesHoy.First(x => x.ClockinTypeId == 1);
                    fichaje.FinishHour = DateTime.UtcNow;
                    apiclient.ApiClockInUpdateClockInPost(fichaje);
                }
                else if (estado == Estados.Comiendo)
                {
                    clockin.ClockinTypeId = 2;
                    clockin.StartHour = DateTime.UtcNow;
                    clockin.FinishHour = null;
                    apiclient.ApiClockInClockInPut(clockin);
                }
                if (estado == Estados.Comido)
                {
                    var fichaje = UserSession.FichajesHoy.First(x => x.ClockinTypeId == 2);
                    fichaje.FinishHour = DateTime.UtcNow;
                    apiclient.ApiClockInUpdateClockInPost(fichaje);
                }
                if (estado == Estados.Descansando)
                {
                    clockin.ClockinTypeId = 3;
                    clockin.StartHour = DateTime.UtcNow;
                    clockin.FinishHour = null;
                    apiclient.ApiClockInClockInPut(clockin);
                }
                if (estado == Estados.Descansado)
                {
                    var fichaje = UserSession.FichajesHoy.First(x => x.ClockinTypeId == 3);
                    clockin.FinishHour = DateTime.UtcNow;
                    apiclient.ApiClockInClockInPut(fichaje);
                }
                CargarFichajesHoy();

            }
            catch (IO.Swagger.Client.ApiException ex)
            {
               // toolStripStatusLabel1.Text = "Error al fichar" + ex;
            }

        }

        private void Fichar_Load(object sender, EventArgs e)
        {

            CargarFichajes((int)UserSession.User.IdUser);
            CargarFichajesHoy();
            estado = GetEstadosByFichajes();
            //estado = 0;
            MaquinaEstados();
            MaquinaEstadoComida();    
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
                    estadoComida = EstadoComida.SinComer;
                    break;
                case Estados.Comiendo:
                    btnJornada.Enabled = false;
                    btnJornada.Text = "Salida";
                    estado = Estados.Comiendo;
                    estadoComida = EstadoComida.SinComer;
                    btnDescanso.Enabled = false;
                    btnDescanso.Text = "Descanso";
                    break;
                case Estados.Comido:
                    btnJornada.Enabled = true;
                    btnJornada.Text = "Salida";
                    estado = Estados.Comido;
                    estadoComida = EstadoComida.Comido;
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
                    btnComida.Text = "Comida";
                    btnDescanso.Enabled = true;
                    btnDescanso.Text = "Descanso";
                    break;
                case Estados.Saliendo:
                    btnJornada.Enabled = false;
                    btnJornada.Text = "Entrada";
                    btnComida.Enabled = false;
                    btnComida.Text = "Comida";
                    btnDescanso.Enabled = false;
                    btnDescanso.Text = "Descanso";
                    break;

            }

        }

        private void MaquinaEstadoComida()
        {
            switch (estadoComida)
            {
                case EstadoComida.Fuera:
                    btnComida.Enabled = false;
                    btnComida.Text = "Comida";
                    break;
                case EstadoComida.SinComer:
                    btnComida.Enabled = true;
                    btnComida.Text = "Comida";
                    break;
                case EstadoComida.Comiendo:
                    btnComida.Enabled = true;
                    btnComida.Text = "Volver Comida";
                    break;
                case EstadoComida.Comido:
                    btnComida.Enabled = false;
                    btnComida.Text = "Comida";
                    break;

            }
        }

        private void btnJornada_Click(object sender, EventArgs e)
        {
            //Realizamos un fichaje            
            if (estado == Estados.Fuera)
            {
                estado = Estados.Entrada;
                Console.WriteLine(estado);

            }
            else if (estado == Estados.Entrada || estado == Estados.Comido || estado == Estados.Descansado)
            {
                estado = Estados.Saliendo;
            }
            MaquinaEstados();
            Fichaje();
            //MaquinaEstadoComida();

        }

        private void btnComida_Click(object sender, EventArgs e)
        {

            if (estado == Estados.Entrada || estado == Estados.Descansado)
            {
                contadorComida = 1;
                estado = Estados.Comiendo;
            }
            else if (estado == Estados.Comiendo)
            {
                estado = Estados.Comido;
            }
            MaquinaEstados();
            Fichaje();

        }

        private void btnDescanso_Click(object sender, EventArgs e)
        {
            if (estado == Estados.Entrada || estado == Estados.Comido || estado == Estados.Descansado)
            {
                estado = Estados.Descansando;

            }
            else if (estado == Estados.Descansando)
            {
                estado = Estados.Descansado;
            }
            MaquinaEstados();
            Fichaje();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
