using IO.Swagger.Api;
using IO.Swagger.Model;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WorkTrackerAPP
{
    public partial class Fichar : Form
    {
        private const string Format = "dd/M/yyyy";
        private const string FormatHora = "HH:mm:ss";
        public static Estados estado;
        public static EstadoComida estadoComida;
        TimeSpan tiempoJornada = default;
        TimeSpan tiempoComida = default;
        TimeSpan tiempoDescanso = default;
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
        public int contadorComida = 0;


        public Fichar()
        {
            InitializeComponent();
        }

        private void CargarFichajesHoy()
        {
            var apiclient = new ClockInApi(UserSession.APIUrl);
            var userClockIn = apiclient.ApiClockInGetClockInsTodayByUserIdIdGet((int)UserSession.User.IdUser);
            UserSession.FichajesHoy = userClockIn;
        }

        private Estados GetEstadosByFichajes()
        {
            var fichajesActuales = UserSession.FichajesHoy;
            Estados estado;
            if (fichajesActuales != null)
            {
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
                    contadorComida = 1;
                    return estado;
                }
                if (fichajesActuales.Any(x => x.ClockinTypeId == 3 && x.FinishHour == null))
                {
                    return Estados.Descansando;
                }
                /*btnJornada.Image = null;
                btnJornada.Image = */
            }
            return Estados.Entrada;
        }


        private void CargarTiempoJornada()
        {
            lblTJornada.Text = string.Empty;
            lblTDesc.Text = string.Empty;
            lblTComida.Text = string.Empty;

            var fichajesActuales = UserSession.FichajesHoy;
            if (fichajesActuales.Any(x => x.ClockinTypeId == 1 ))
            {
               var fichajeJornada = fichajesActuales.First(x => x.ClockinTypeId == 1);
                if (fichajeJornada.FinishHour == null)
                {
                    tiempoJornada = DateTime.UtcNow.AddHours(1).Subtract((DateTime)fichajeJornada.StartHour);
                }
                else
                {
                    tiempoJornada = fichajeJornada.FinishHour.Value.Subtract((DateTime)fichajeJornada.StartHour);
                }
             
              

            }

            if (fichajesActuales.Any(x => x.ClockinTypeId == 2)){
                var fichajeComida = fichajesActuales.First(x => x.ClockinTypeId == 2);
                if (fichajeComida.FinishHour == null)
                {
                    tiempoComida = DateTime.UtcNow.AddHours(1).Subtract((DateTime)fichajeComida.StartHour);
                }
                else
                {
                    tiempoComida = fichajeComida.FinishHour.Value.Subtract((DateTime)fichajeComida.StartHour);
                }
               
            }

            if (fichajesActuales.Any(x => x.ClockinTypeId == 3))
            {
                var fichajesDescanso = fichajesActuales.Where(x => x.ClockinTypeId == 3);
                foreach (var fichajeDescanso in fichajesDescanso)
                {
                    if (fichajeDescanso.FinishHour == null)
                    {
                        tiempoDescanso += DateTime.UtcNow.AddHours(1).Subtract((DateTime)fichajeDescanso.StartHour);
                    }
                    else
                    {
                        tiempoDescanso += fichajeDescanso.FinishHour.Value.Subtract((DateTime)fichajeDescanso.StartHour);
                    }
                }
            }



            lblTJornada.Text = CalcularTotalJornada().ToString("hh\\:mm\\:ss");
            lblTComida.Text = tiempoComida.ToString("hh\\:mm\\:ss");
            lblTDesc.Text = tiempoDescanso.ToString("hh\\:mm\\:ss");

        }

        private TimeSpan CalcularTotalJornada()
        {
            return tiempoJornada - tiempoDescanso - tiempoComida;
        }

        private void CargarFichajes(int id)
        {
            //Cargamos los fichajes
            var apiclient = new ClockInApi(UserSession.APIUrl);
            var fichajesUsuario = apiclient.ApiClockInGetClockInsByUserIdIdGet(id);
            

            if (fichajesUsuario.Count > 0)
            {
                var ultimoFichaje = fichajesUsuario.Last();
                var ffechaUltimoFichaje = Convert.ToDateTime(ultimoFichaje.Date).ToString(Format);
                var ffechaActual = Convert.ToDateTime(DateTime.UtcNow.AddHours(1)).ToString(Format);

                //Seleccionar el estado del usuario
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
                                        lblFichajeActual.Text = "Hora de salida a comer: " + hora.ToString();
                                        estado = Estados.Comiendo;

                                    }
                                    else
                                    {
                                        var hora = Convert.ToDateTime(ultimoFichaje.FinishHour).ToString(FormatHora);
                                        lblFichajeActual.Text = "Hora de entrada: " + hora.ToString();
                                        estado = Estados.Comido;

                                    }
                                    break;

                                case 3:

                                    if (ultimoFichaje.FinishHour.ToString() =="")
                                    {
                                        var hora = Convert.ToDateTime(ultimoFichaje.StartHour).ToString(FormatHora);
                                        lblFichajeActual.Text = "Hora de salida descanso: " + hora.ToString();
                                        estado = Estados.Descansando;
                                    }
                                    else
                                    {
                                        var hora = Convert.ToDateTime(ultimoFichaje.FinishHour).ToString(FormatHora);
                                        lblFichajeActual.Text = "Hora de entrada: " + hora.ToString();
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
                    Helper.MensajeError("Error al Obtener el usuario" + ex, "Error");
                }
            }

        }

        private void MostrarHistoricoFichajes()
        {
            lblHistorico.Text = "";
            var apiclient = new ClockInApi(UserSession.APIUrl);
            var fichajesUsuario = apiclient.ApiClockInGetClockInsByUserIdIdGet( UserSession.User.IdUser);
           

            if (UserSession.Fichajes.Count() > 0)
            {

                foreach (var _data in UserSession.Fichajes.Skip(Math.Max(0, UserSession.Fichajes.Count() - 5)).Reverse())
                {
                    var ffecha = Convert.ToDateTime(_data.Date).ToString(Format);

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
            clockin.Date = DateTime.UtcNow.AddHours(1);
            var apiclient = new ClockInApi(UserSession.APIUrl);

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
                    var fichaje = UserSession.FichajesHoy.Last(x => x.ClockinTypeId == 1);
                    fichaje.FinishHour = DateTime.UtcNow.AddHours(1);
                    apiclient.ApiClockInUpdateClockInPost(fichaje);
                }
                else if (estado == Estados.Comiendo)
                {
                    clockin.ClockinTypeId = 2;
                    clockin.StartHour = DateTime.UtcNow.AddHours(1);
                    clockin.FinishHour = null;
                    apiclient.ApiClockInClockInPut(clockin);
                }
                if (estado == Estados.Comido)
                {
                    var fichaje = UserSession.FichajesHoy.Last(x => x.ClockinTypeId == 2);
                    fichaje.FinishHour = DateTime.UtcNow.AddHours(1);
                    apiclient.ApiClockInUpdateClockInPost(fichaje);
                }
                if (estado == Estados.Descansando)
                {
                    clockin.ClockinTypeId = 3;
                    clockin.StartHour = DateTime.UtcNow.AddHours(1);
                    clockin.FinishHour = null;
                    apiclient.ApiClockInClockInPut(clockin);
                }
                if (estado == Estados.Descansado)
                {
                    var fichaje = UserSession.FichajesHoy.Last(x => x.ClockinTypeId == 3  && x.FinishHour == null);
                    fichaje.FinishHour = DateTime.UtcNow.AddHours(1);
                    apiclient.ApiClockInUpdateClockInPost(fichaje);
                }
                CargarFichajesHoy();
                CargarFichajes((int)UserSession.User.IdUser);

            }
            catch (IO.Swagger.Client.ApiException ex)
            {
                Helper.MensajeError("Error al fichar" + ex, "Error");
            }

        }



        private void Fichar_Load(object sender, EventArgs e)
        {
            CargarFichajesHoy();
            CargarFichajes((int)UserSession.User.IdUser);  
            estado = GetEstadosByFichajes();
            MaquinaEstados();
            CargarTiempoJornada();
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
                    btnComida.Enabled = true;
                    btnDescanso.Enabled = false;
                    btnDescanso.Text = "Descanso";
                    break;
                case Estados.Comido:
                    btnJornada.Enabled = true;
                    btnJornada.Text = "Salida";
                    estado = Estados.Comido;
                    btnComida.Text = "Comida Completada";
                    btnComida.Enabled = false;
                    contadorComida = 1;
                    btnDescanso.Enabled = true;
                    btnDescanso.Text = "Descanso";
                    break;
                case Estados.Descansado:
                    btnJornada.Enabled = true;
                    btnJornada.Text = "Salida";
                  
                    if (contadorComida == 1)
                    {
                        btnComida.Text = "Comida Completada";
                        btnComida.Enabled = false;
                    }
                    else
                    {
                        btnComida.Text = "Comida";
                        btnComida.Enabled = true;
                    }
                    btnDescanso.Enabled = true;
                    btnDescanso.Text = "Descanso";
                    break;
                case Estados.Descansando:
                    btnJornada.Enabled = false;
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
                    btnDescanso.Enabled = true;
                    btnDescanso.Text = "Volver Descanso";
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
                MaquinaEstados();
                Fichaje();
                CargarTiempoJornada();

            }
            else if (estado == Estados.Entrada || estado == Estados.Comido || estado == Estados.Descansado)
            {

                var timeTotalJornada = new TimeSpan(UserSession.Jornada, 0, 0);
                if (CalcularTotalJornada().CompareTo(timeTotalJornada) < 0)
                {
                    var messageResult = MessageBox.Show("No ha cumplido con el total de la jornada. ¿Desa fichar la salida?", "Fichaje Salida", MessageBoxButtons.YesNo);
                    if (messageResult == DialogResult.Yes)
                    {
                        estado = Estados.Saliendo;
                        MaquinaEstados();
                        Fichaje();
                        CargarTiempoJornada();
                    }
                }
                else
                {
                    estado = Estados.Saliendo;
                    MaquinaEstados();
                    Fichaje();
                    CargarTiempoJornada();
                }
            }
        

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
            CargarFichajes((int)UserSession.User.IdUser);
            CargarTiempoJornada();

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
            CargarFichajes((int)UserSession.User.IdUser);
            CargarTiempoJornada();
        }


    }
}
