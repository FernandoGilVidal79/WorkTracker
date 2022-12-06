using IO.Swagger.Model;
using System.Collections.Generic;

namespace WorkTrackerAPP
{
    public static class UserSession
    {
        public static Users User { get; set; }

        public static List<Clockin> Fichajes { get; set; }

        public static List<Clockin> FichajesHoy { get; set; }

        public static string APIUrl { get
            {
                return Properties.Settings.Default.APIUrl;
            } }
    }
}