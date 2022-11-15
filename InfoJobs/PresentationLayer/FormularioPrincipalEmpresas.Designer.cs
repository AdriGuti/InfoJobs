
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCrearOfertas = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CuadroTextoDescripcion = new System.Windows.Forms.RichTextBox();
            this.CuadroTextoTitulo = new System.Windows.Forms.TextBox();
            this.TabVerOfertas = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.TabCrearOfertas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabCrearOfertas);
            this.tabControl1.Controls.Add(this.TabVerOfertas);
            this.tabControl1.Location = new System.Drawing.Point(5, 6);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(769, 441);
            this.tabControl1.TabIndex = 0;
            // 
            // TabCrearOfertas
            // 
            this.TabCrearOfertas.Controls.Add(this.comboBox1);
            this.TabCrearOfertas.Controls.Add(this.label1);
            this.TabCrearOfertas.Controls.Add(this.label3);
            this.TabCrearOfertas.Controls.Add(this.label2);
            this.TabCrearOfertas.Controls.Add(this.CuadroTextoDescripcion);
            this.TabCrearOfertas.Controls.Add(this.CuadroTextoTitulo);
            this.TabCrearOfertas.Location = new System.Drawing.Point(4, 29);
            this.TabCrearOfertas.Name = "TabCrearOfertas";
            this.TabCrearOfertas.Padding = new System.Windows.Forms.Padding(3);
            this.TabCrearOfertas.Size = new System.Drawing.Size(761, 408);
            this.TabCrearOfertas.TabIndex = 0;
            this.TabCrearOfertas.Text = "CrearOfertas";
            this.TabCrearOfertas.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(324, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(227, 28);
            this.comboBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Oficio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(159, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(159, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulo";
            // 
            // CuadroTextoDescripcion
            // 
            this.CuadroTextoDescripcion.Location = new System.Drawing.Point(324, 130);
            this.CuadroTextoDescripcion.Name = "CuadroTextoDescripcion";
            this.CuadroTextoDescripcion.Size = new System.Drawing.Size(227, 121);
            this.CuadroTextoDescripcion.TabIndex = 1;
            this.CuadroTextoDescripcion.Text = "";
            // 
            // CuadroTextoTitulo
            // 
            this.CuadroTextoTitulo.Location = new System.Drawing.Point(324, 71);
            this.CuadroTextoTitulo.Name = "CuadroTextoTitulo";
            this.CuadroTextoTitulo.Size = new System.Drawing.Size(227, 26);
            this.CuadroTextoTitulo.TabIndex = 0;
            // 
            // TabVerOfertas
            // 
            this.TabVerOfertas.Location = new System.Drawing.Point(4, 29);
            this.TabVerOfertas.Name = "TabVerOfertas";
            this.TabVerOfertas.Padding = new System.Windows.Forms.Padding(3);
            this.TabVerOfertas.Size = new System.Drawing.Size(761, 408);
            this.TabVerOfertas.TabIndex = 1;
            this.TabVerOfertas.Text = "VerOfertasPublicadas";
            this.TabVerOfertas.UseVisualStyleBackColor = true;
            // 
            // FormularioPrincipalEmpresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormularioPrincipalEmpresas";
            this.Text = "FormularioPrincipalEmpresas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormularioPrincipalEmpresas_FormClosed);
            this.Load += new System.EventHandler(this.FormularioPrincipalEmpresas_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabCrearOfertas.ResumeLayout(false);
            this.TabCrearOfertas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabCrearOfertas;
        private System.Windows.Forms.TabPage TabVerOfertas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox CuadroTextoDescripcion;
        private System.Windows.Forms.TextBox CuadroTextoTitulo;
    }
}