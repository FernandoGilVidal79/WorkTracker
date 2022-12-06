using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

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
            /*btnJornada.Image = null;
            btnJornada.Image = */

            return Estados.Entrada;
        }

        private void CargarFichajes(int id)
        {
            //Cargamos los fichajes
            var apiclient = new ClockInApi("http://worktracker-001-site1.atempurl.com/");
            var fichajesUsuario = apiclient.ApiClockInGetClockInsByUserIdIdGet(id);
            

            if (fichajesUsuario.Count > 0)
            {
                var ultimoFichaje = fichajesUsuario.Last();
                var ffechaUltimoFichaje = Convert.ToDateTime(ultimoFichaje.Date).ToString(Format);
                var ffechaActual = Convert.ToDateTime(DateTime.UtcNow).ToString(Format);
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
                            lblHistorico.Hide();
                            lblResumen.Text = "Jornada de hoy: " + ffechaActual.ToString();

                            switch (ultimoFichaje.ClockinTypeId)
                            {
                                case 1:
                                    if (ultimoFichaje.FinishHour.ToString() == "")
                                    {
                                        var hora = Convert.ToDateTime(ultimoFichaje.StartHour).ToString(FormatHora);
                                        lblFichajeActual.Text = "Hora de entrada: " + hora.ToString();
                                        estado = Estados.Entrada;
                                    }
                                    else
                                    {
                                        var hora = Convert.ToDateTime(ultimoFichaje.FinishHour).ToString(FormatHora);
                                        lblFichajeActual.Text = "Hora de salida: " + hora.ToString();
                                        estado = Estados.Fuera;
                                    }
                                    break;

                                case 2:
                                    if (ultimoFichaje.FinishHour.ToString() == "")
                                    {
                                        var hora = Convert.ToDateTime(ultimoFichaje.StartHour).ToString(FormatHora);
                                        lblFichajeActual.Text = "Hora de entrada: " + hora.ToString();
                                        estado = Estados.Comiendo;

                                    }
                                    else
                                    {
                                        var hora = Convert.ToDateTime(ultimoFichaje.FinishHour).ToString(FormatHora);
                                        lblFichajeActual.Text = "Hora de salida: " + hora.ToString();
                                        estado = Estados.Comido;

                                    }
                                    break;

                                case 3:
                                    if (ultimoFichaje.FinishHour.ToString() == "")
                                    {
                                        var hora = Convert.ToDateTime(ultimoFichaje.StartHour).ToString(FormatHora);
                                        lblFichajeActual.Text = "Hora de entrada: " + hora.ToString();
                                        estado = Estados.Descansando;
                                    }
                                    else
                                    {
                                        var hora = Convert.ToDateTime(ultimoFichaje.FinishHour).ToString(FormatHora);
                                        lblFichajeActual.Text = "Hora de salida: " + hora.ToString();
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
                        lblFichajeActual.Text = "";

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
            var apiclient = new ClockInApi("http://worktracker-001-site1.atempurl.com/");
            var fichajesUsuario = apiclient.ApiClockInGetClockInsByUserIdIdGet( UserSession.User.IdUser);
            Console.WriteLine(UserSession.Fichajes);
            

            if (UserSession.Fichajes.Count() > 0)
            {

                foreach (var _data in UserSession.Fichajes.Skip(Math.Max(0, UserSession.Fichajes.Count() - 5)).Reverse())
                {
                    var ffecha = Convert.ToDateTime(_data.Date).ToString(Format);
                    Console.WriteLine(UserSession.Fichajes);

                    lblHistorico.Text += "Fecha: " + ffecha;
                    lblHistorico.Text += "\n";
                    lblHistorico.Text += "Hora de entrada:" + _data.StartHour;
                    lblHistorico.Text += "\n";
                    lblHistorico.Text += "Hora de salida: " + _data.FinishHour;
                    lblHistorico.Text += "\n-------------------------------------------------\n";

                }
            } 
            else {
                lblHistorico.Text = "No hay fichajes registrados aún";
            }

        }


        private void Fichaje()
        {
            //Declaramos las variables
            var clockin = new Clockin();
            clockin.UserId = UserSession.User.IdUser;
            clockin.Date = DateTime.UtcNow;
            var apiclient = new ClockInApi("http://worktracker-001-site1.atempurl.com/");

            try
            {
                //Realizar un marcaje por estado
                if (estado == Estados.Entrada)
                {
                    clockin.ClockinTypeId = 1;
                    clockin.StartHour = DateTime.UtcNow.AddHours(1);
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
                    apiclient.ApiClockInUpdateClockInPost(fichaje);
                }
                CargarFichajesHoy();
                CargarFichajes((int)UserSession.User.IdUser);

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
                    btnComida.Text = "Comiendo";
                    btnDescanso.Enabled = false;
                    btnDescanso.Text = "Descanso";
                    break;
                case Estados.Comido:
                    btnJornada.Enabled = true;
                    btnJornada.Text = "Salida";
                    estado = Estados.Comido;
                    btnComida.Text = "Comida Completada";
                    contadorComida = 1;
                    btnDescanso.Enabled = true;
                    btnDescanso.Text = "Descanso";
                    break;
                case Estados.Descansado:
                    btnJornada.Enabled = true;
                    btnJornada.Text = "Salida";
                    btnComida.Enabled = false;
                    if (contadorComida == 1)
                    {
                        btnComida.Text = "Comida Completada";
                    }
                    else
                    {
                        btnComida.Text = "Comida";
                    }

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

            }
            else if (estado == Estados.Entrada || estado == Estados.Comido || estado == Estados.Descansado)
            {
                estado = Estados.Saliendo;
            }
            if(estado == Estados.Entrada)
            {
                //btnJornada.Image = Image.FromFile(@"Resources\\salida.png");
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


    }
}
