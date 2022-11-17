
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
            this.BotoPublicarOferta = new System.Windows.Forms.Button();
            this.ComboBoxOfici = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CuadroTextoDescripcion = new System.Windows.Forms.RichTextBox();
            this.CuadroTextoTitulo = new System.Windows.Forms.TextBox();
            this.dataGridViewOfertasEmpresa = new System.Windows.Forms.DataGridView();
            this.dataGridViewCandidatosOfertas = new System.Windows.Forms.DataGridView();
            this.ofertasEmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BotoRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfertasEmpresa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidatosOfertas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertasEmpresaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BotoPublicarOferta
            // 
            this.BotoPublicarOferta.Location = new System.Drawing.Point(133, 234);
            this.BotoPublicarOferta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BotoPublicarOferta.Name = "BotoPublicarOferta";
            this.BotoPublicarOferta.Size = new System.Drawing.Size(67, 25);
            this.BotoPublicarOferta.TabIndex = 21;
            this.BotoPublicarOferta.Text = "Publicar";
            this.BotoPublicarOferta.UseVisualStyleBackColor = true;
            this.BotoPublicarOferta.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BotoPublicarOferta_Click);
            // 
            // ComboBoxOfici
            // 
            this.ComboBoxOfici.FormattingEnabled = true;
            this.ComboBoxOfici.Location = new System.Drawing.Point(108, 183);
            this.ComboBoxOfici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxOfici.Name = "ComboBoxOfici";
            this.ComboBoxOfici.Size = new System.Drawing.Size(202, 24);
            this.ComboBoxOfici.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Oficio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "Titulo";
            // 
            // CuadroTextoDescripcion
            // 
            this.CuadroTextoDescripcion.Location = new System.Drawing.Point(108, 65);
            this.CuadroTextoDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CuadroTextoDescripcion.Name = "CuadroTextoDescripcion";
            this.CuadroTextoDescripcion.Size = new System.Drawing.Size(202, 98);
            this.CuadroTextoDescripcion.TabIndex = 16;
            this.CuadroTextoDescripcion.Text = "";
            // 
            // CuadroTextoTitulo
            // 
            this.CuadroTextoTitulo.Location = new System.Drawing.Point(108, 18);
            this.CuadroTextoTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CuadroTextoTitulo.Name = "CuadroTextoTitulo";
            this.CuadroTextoTitulo.Size = new System.Drawing.Size(202, 22);
            this.CuadroTextoTitulo.TabIndex = 15;
            // 
            // dataGridViewOfertasEmpresa
            // 
            this.dataGridViewOfertasEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfertasEmpresa.Location = new System.Drawing.Point(341, 20);
            this.dataGridViewOfertasEmpresa.Name = "dataGridViewOfertasEmpresa";
            this.dataGridViewOfertasEmpresa.RowHeadersWidth = 51;
            this.dataGridViewOfertasEmpresa.RowTemplate.Height = 24;
            this.dataGridViewOfertasEmpresa.Size = new System.Drawing.Size(608, 800);
            this.dataGridViewOfertasEmpresa.TabIndex = 22;
            // 
            // dataGridViewCandidatosOfertas
            // 
            this.dataGridViewCandidatosOfertas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCandidatosOfertas.Location = new System.Drawing.Point(1010, 20);
            this.dataGridViewCandidatosOfertas.Name = "dataGridViewCandidatosOfertas";
            this.dataGridViewCandidatosOfertas.RowHeadersWidth = 51;
            this.dataGridViewCandidatosOfertas.RowTemplate.Height = 24;
            this.dataGridViewCandidatosOfertas.Size = new System.Drawing.Size(500, 800);
            this.dataGridViewCandidatosOfertas.TabIndex = 23;
            // 
            // BotoRefresh
            // 
            this.BotoRefresh.Location = new System.Drawing.Point(260, 236);
            this.BotoRefresh.Name = "BotoRefresh";
            this.BotoRefresh.Size = new System.Drawing.Size(75, 34);
            this.BotoRefresh.TabIndex = 24;
            this.BotoRefresh.Text = "Refresh";
            this.BotoRefresh.UseVisualStyleBackColor = true;
            this.BotoRefresh.Click += new System.EventHandler(this.BotoRefresh_Click);
            // 
            // FormularioPrincipalEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1924, 844);
            this.Controls.Add(this.BotoRefresh);
            this.Controls.Add(this.dataGridViewCandidatosOfertas);
            this.Controls.Add(this.dataGridViewOfertasEmpresa);
            this.Controls.Add(this.BotoPublicarOferta);
            this.Controls.Add(this.ComboBoxOfici);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CuadroTextoDescripcion);
            this.Controls.Add(this.CuadroTextoTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormularioPrincipalEmpresas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioPrincipalEmpresas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormularioPrincipalEmpresas_FormClosed);
            this.Load += new System.EventHandler(this.FormularioPrincipalEmpresas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfertasEmpresa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCandidatosOfertas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ofertasEmpresaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BotoPublicarOferta;
        private System.Windows.Forms.ComboBox ComboBoxOfici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox CuadroTextoDescripcion;
        private System.Windows.Forms.TextBox CuadroTextoTitulo;
        private System.Windows.Forms.DataGridView dataGridViewOfertasEmpresa;
        private System.Windows.Forms.DataGridView dataGridViewCandidatosOfertas;
        private System.Windows.Forms.BindingSource ofertasEmpresaBindingSource;
        private System.Windows.Forms.Button BotoRefresh;
    }
}