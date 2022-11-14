using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InfoJobs.DataLayer;

namespace InfoJobs.BussinessLayer
{
    static public class GestioSQL
    {
        static infojobsContext connexio;
        public static string ErrorMessage = "";
        static public bool LoginCandidatos(string nom,string pass)
        {
            bool loginsuccesful=false;
            connexio = new infojobsContext();
            try
            {

                connexio = new infojobsContext();
                if (connexio.Candidatos.Where(a => a.Nombre == nom && a.Contraseña == pass).Count() == 1)
                {
                    loginsuccesful = true;
                }
            }
            catch(Exception ex) {
                ErrorMessage = ex.Message;
            }
            return loginsuccesful;
        }
        static public bool LoginEmpresas()
        {
            bool loginsuccesful = false;

            return loginsuccesful;
        }
    }
}
