
namespace InfoJobs
{
    partial class Login
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
            this.BotonAccesoEmpresas = new System.Windows.Forms.Button();
            this.BotonAccesoCandidatos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonAccesoEmpresas
            // 
            this.BotonAccesoEmpresas.Location = new System.Drawing.Point(114, 79);
            this.BotonAccesoEmpresas.Name = "BotonAccesoEmpresas";
            this.BotonAccesoEmpresas.Size = new System.Drawing.Size(200, 31);
            this.BotonAccesoEmpresas.TabIndex = 0;
            this.BotonAccesoEmpresas.Text = "Acceso Empresas";
            this.BotonAccesoEmpresas.UseVisualStyleBackColor = true;
            this.BotonAccesoEmpresas.Click += new System.EventHandler(this.BotonAccesoEmpresas_Click);
            // 
            // BotonAccesoCandidatos
            // 
            this.BotonAccesoCandidatos.Location = new System.Drawing.Point(114, 133);
            this.BotonAccesoCandidatos.Name = "BotonAccesoCandidatos";
            this.BotonAccesoCandidatos.Size = new System.Drawing.Size(200, 31);
            this.BotonAccesoCandidatos.TabIndex = 1;
            this.BotonAccesoCandidatos.Text = "Acceso Candidatos";
            this.BotonAccesoCandidatos.UseVisualStyleBackColor = true;
            this.BotonAccesoCandidatos.Click += new System.EventHandler(this.BotonAccesoCandidatos_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 238);
            this.Controls.Add(this.BotonAccesoCandidatos);
            this.Controls.Add(this.BotonAccesoEmpresas);
            this.Name = "Login";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotonAccesoEmpresas;
        private System.Windows.Forms.Button BotonAccesoCandidatos;
    }
}