﻿using System;
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
        public FormularioPrincipalEmpresas()
        {
            InitializeComponent();
        }

        private void FormularioPrincipalEmpresas_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = GestioSQL.DataBindingOficio();
        }

        private void FormularioPrincipalEmpresas_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
