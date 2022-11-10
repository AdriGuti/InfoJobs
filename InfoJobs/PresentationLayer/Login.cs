using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InfoJobs.BussinessLayer;
using InfoJobs.PresentationLayer;

namespace InfoJobs
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BotonAccesoEmpresas_Click(object sender, EventArgs e)
        {
            Autentificacion_Empresas autentificacion_Empresas = new Autentificacion_Empresas();
            autentificacion_Empresas.Show();
            this.Hide();
        }

        private void BotonAccesoCandidatos_Click(object sender, EventArgs e)
        {
            Autentificacion_Candidatos autentificacion_Candidatos = new Autentificacion_Candidatos();
            autentificacion_Candidatos.Show();
            this.Hide();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
