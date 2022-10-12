using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoJobs
{
    public partial class Autentificacion_Candidatos : Form
    {
        public Autentificacion_Candidatos()
        {
            InitializeComponent();
        }

        private void BotonLogin_Click(object sender, EventArgs e)
        {

        }

        private void BotonRetroceder_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void Autentificacion_Candidatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
