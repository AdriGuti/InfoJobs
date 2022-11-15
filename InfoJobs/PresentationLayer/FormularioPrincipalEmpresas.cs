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
using InfoJobs.DataLayer;

namespace InfoJobs.PresentationLayer
{
    public partial class FormularioPrincipalEmpresas : Form
    {
        public string Empresa;
        public FormularioPrincipalEmpresas()
        {
            InitializeComponent();
        }

        private void FormularioPrincipalEmpresas_Load(object sender, EventArgs e)
        {
            ComboBoxOfici.DataSource = GestioSQL.DataBindingOficio();
        }

        private void FormularioPrincipalEmpresas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void BotoPublicarOferta_Click(object sender, EventArgs e)
        {
            if (GestioSQL.PublicarOferta(CuadroTextoTitulo.Text, CuadroTextoDescripcion.Text, ComboBoxOfici.Text, Empresa)){
                MessageBox.Show("Oferta publicada correctament");
                CuadroTextoTitulo.Text = "";
                CuadroTextoDescripcion.Text = "";
            }
            else
            {
                MessageBox.Show(GestioSQL.ErrorMessage);
            }
        }
    }
}
