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
        static public bool LoginCandidatos(string dni,string pass)
        {
            bool loginsuccesful=false;
            try
            {
                connexio = new infojobsContext();
                int valor = connexio.Candidatos.Where(a => a.Dni == dni && a.Contraseña == pass).Count();
                if ( valor == 1)
                {
                    loginsuccesful = true;
                }
            }
            catch(Exception ex) {
                ErrorMessage = ex.Message;
            }
            return loginsuccesful;
        }
        static public bool LoginEmpresas(string nif, string pass)
        {
            bool loginsuccesful = false;
            try
            {
                connexio = new infojobsContext();
                int valor = connexio.Empresas.Where(a => a.Nif == nif && a.Contraseña == pass).Count();
                if (valor == 1)
                {
                    loginsuccesful = true;
                }
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return loginsuccesful;
        }
        public static List<string> DataBindingOficio()
        {
            List<Oficio> oficis = new List<Oficio>();
            List<string> nomOficis = new List<string>();
            try
            {
                connexio = new infojobsContext();
                oficis = connexio.Oficio.ToList();

                foreach (Oficio ofici in oficis)
                {
                    nomOficis.Add(ofici.Nombre);
                }
            }
            catch(Exception ex)
            {
                ErrorMessage = ex.Message;
            }
            return nomOficis;
        }
    }
}
