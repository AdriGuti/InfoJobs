using InfoJobs.BussinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoJobs.PresentationLayer
{
    public partial class Autentificacion_Empresas : Form
    {
        public Autentificacion_Empresas()
        {
            InitializeComponent();
        }

        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Autentificacion_Empresas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BotonLogin_Click(object sender, EventArgs e)
        {
            if (GestioSQL.LoginEmpresas(CuadroTextoUsuario.Text,CuadroTextoContraseña.Text))
            {
                this.Hide();
                FormularioPrincipalEmpresas principal = new FormularioPrincipalEmpresas();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña erroneo");
            }
        }
    }
}
