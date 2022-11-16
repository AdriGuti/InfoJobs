
namespace InfoJobs.PresentationLayer
{
    partial class FormularioPrincipalEmpresas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.BotoPublicarOferta = new System.Windows.Forms.Button();
            this.ComboBoxOfici = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CuadroTextoDescripcion = new System.Windows.Forms.RichTextBox();
            this.CuadroTextoTitulo = new System.Windows.Forms.TextBox();
            this.dataGridViewOfertes = new System.Windows.Forms.DataGridView();
            this.idOfertaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nifEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOficioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOficioNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nifEmpresaNavigationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.relacioncandidatosofertasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ofertasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfertes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BotoPublicarOferta
            // 
            this.BotoPublicarOferta.Location = new System.Drawing.Point(150, 293);
            this.BotoPublicarOferta.Name = "BotoPublicarOferta";
            this.BotoPublicarOferta.Size = new System.Drawing.Size(75, 31);
            this.BotoPublicarOferta.TabIndex = 21;
            this.BotoPublicarOferta.Text = "Publicar";
            this.BotoPublicarOferta.UseVisualStyleBackColor = true;
            // 
            // ComboBoxOfici
            // 
            this.ComboBoxOfici.FormattingEnabled = true;
            this.ComboBoxOfici.Location = new System.Drawing.Point(122, 229);
            this.ComboBoxOfici.Name = "ComboBoxOfici";
            this.ComboBoxOfici.Size = new System.Drawing.Size(227, 28);
            this.ComboBoxOfici.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Oficio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titulo";
            // 
            // CuadroTextoDescripcion
            // 
            this.CuadroTextoDescripcion.Location = new System.Drawing.Point(122, 81);
            this.CuadroTextoDescripcion.Name = "CuadroTextoDescripcion";
            this.CuadroTextoDescripcion.Size = new System.Drawing.Size(227, 121);
            this.CuadroTextoDescripcion.TabIndex = 16;
            this.CuadroTextoDescripcion.Text = "";
            // 
            // CuadroTextoTitulo
            // 
            this.CuadroTextoTitulo.Location = new System.Drawing.Point(122, 22);
            this.CuadroTextoTitulo.Name = "CuadroTextoTitulo";
            this.CuadroTextoTitulo.Size = new System.Drawing.Size(227, 26);
            this.CuadroTextoTitulo.TabIndex = 15;
            // 
            // dataGridViewOfertes
            // 
            this.dataGridViewOfertes.AutoGenerateColumns = false;
            this.dataGridViewOfertes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfertes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOfertaDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.nifEmpresaDataGridViewTextBoxColumn,
            this.idOficioDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idOficioNavigationDataGridViewTextBoxColumn,
            this.nifEmpresaNavigationDataGridViewTextBoxColumn,
            this.relacioncandidatosofertasDataGridViewTextBoxColumn});
            this.dataGridViewOfertes.DataSource = this.ofertasBindingSource;
            this.dataGridViewOfertes.Location = new System.Drawing.Point(393, 25);
            this.dataGridViewOfertes.Name = "dataGridViewOfertes";
            this.dataGridViewOfertes.RowHeadersWidth = 62;
            this.dataGridViewOfertes.RowTemplate.Height = 28;
            this.dataGridViewOfertes.Size = new System.Drawing.Size(1692, 1009);
            this.dataGridViewOfertes.TabIndex = 22;
            // 
            // idOfertaDataGridViewTextBoxColumn
            // 
            this.idOfertaDataGridViewTextBoxColumn.DataPropertyName = "IdOferta";
            this.idOfertaDataGridViewTextBoxColumn.HeaderText = "IdOferta";
            this.idOfertaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idOfertaDataGridViewTextBoxColumn.Name = "idOfertaDataGridViewTextBoxColumn";
            this.idOfertaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            this.tituloDataGridViewTextBoxColumn.Width = 150;
            // 
            // nifEmpresaDataGridViewTextBoxColumn
            // 
            this.nifEmpresaDataGridViewTextBoxColumn.DataPropertyName = "NifEmpresa";
            this.nifEmpresaDataGridViewTextBoxColumn.HeaderText = "NifEmpresa";
            this.nifEmpresaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nifEmpresaDataGridViewTextBoxColumn.Name = "nifEmpresaDataGridViewTextBoxColumn";
            this.nifEmpresaDataGridViewTextBoxColumn.Width = 150;
            // 
            // idOficioDataGridViewTextBoxColumn
            // 
            this.idOficioDataGridViewTextBoxColumn.DataPropertyName = "IdOficio";
            this.idOficioDataGridViewTextBoxColumn.HeaderText = "IdOficio";
            this.idOficioDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idOficioDataGridViewTextBoxColumn.Name = "idOficioDataGridViewTextBoxColumn";
            this.idOficioDataGridViewTextBoxColumn.Width = 150;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 150;
            // 
            // idOficioNavigationDataGridViewTextBoxColumn
            // 
            this.idOficioNavigationDataGridViewTextBoxColumn.DataPropertyName = "IdOficioNavigation";
            this.idOficioNavigationDataGridViewTextBoxColumn.HeaderText = "IdOficioNavigation";
            this.idOficioNavigationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idOficioNavigationDataGridViewTextBoxColumn.Name = "idOficioNavigationDataGridViewTextBoxColumn";
            this.idOficioNavigationDataGridViewTextBoxColumn.Width = 150;
            // 
            // nifEmpresaNavigationDataGridViewTextBoxColumn
            // 
            this.nifEmpresaNavigationDataGridViewTextBoxColumn.DataPropertyName = "NifEmpresaNavigation";
            this.nifEmpresaNavigationDataGridViewTextBoxColumn.HeaderText = "NifEmpresaNavigation";
            this.nifEmpresaNavigationDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nifEmpresaNavigationDataGridViewTextBoxColumn.Name = "nifEmpresaNavigationDataGridViewTextBoxColumn";
            this.nifEmpresaNavigationDataGridViewTextBoxColumn.Width = 150;
            // 
            // relacioncandidatosofertasDataGridViewTextBoxColumn
            // 
            this.relacioncandidatosofertasDataGridViewTextBoxColumn.DataPropertyName = "Relacioncandidatosofertas";
            this.relacioncandidatosofertasDataGridViewTextBoxColumn.HeaderText = "Relacioncandidatosofertas";
            this.relacioncandidatosofertasDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.relacioncandidatosofertasDataGridViewTextBoxColumn.Name = "relacioncandidatosofertasDataGridViewTextBoxColumn";
            this.relacioncandidatosofertasDataGridViewTextBoxColumn.Width = 150;
            // 
            // ofertasBindingSource
            // 
            this.ofertasBindingSource.DataSource = typeof(InfoJobs.DataLayer.Ofertas);
            // 
            // FormularioPrincipalEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(2282, 1084);
            this.Controls.Add(this.dataGridViewOfertes);
            this.Controls.Add(this.BotoPublicarOferta);
            this.Controls.Add(this.ComboBoxOfici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CuadroTextoDescripcion);
            this.Controls.Add(this.CuadroTextoTitulo);
            this.Name = "FormularioPrincipalEmpresas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPrincipalEmpresas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormularioPrincipalEmpresas_FormClosed);
            this.Load += new System.EventHandler(this.FormularioPrincipalEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfertes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button BotoPublicarOferta;
        private System.Windows.Forms.ComboBox ComboBoxOfici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox CuadroTextoDescripcion;
        private System.Windows.Forms.TextBox CuadroTextoTitulo;
        private System.Windows.Forms.DataGridView dataGridViewOfertes;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOfertaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOficioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOficioNavigationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nifEmpresaNavigationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn relacioncandidatosofertasDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ofertasBindingSource;
    }
}