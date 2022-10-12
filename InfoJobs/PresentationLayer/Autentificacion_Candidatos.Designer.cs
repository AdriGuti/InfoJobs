
namespace InfoJobs
{
    partial class Autentificacion_Candidatos
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
            this.CuadroTextoUsuario = new System.Windows.Forms.TextBox();
            this.CuadroTextoContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BotonLogin = new System.Windows.Forms.Button();
            this.BotonRetroceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CuadroTextoUsuario
            // 
            this.CuadroTextoUsuario.Location = new System.Drawing.Point(214, 59);
            this.CuadroTextoUsuario.Name = "CuadroTextoUsuario";
            this.CuadroTextoUsuario.Size = new System.Drawing.Size(299, 26);
            this.CuadroTextoUsuario.TabIndex = 0;
            // 
            // CuadroTextoContraseña
            // 
            this.CuadroTextoContraseña.Location = new System.Drawing.Point(214, 109);
            this.CuadroTextoContraseña.Name = "CuadroTextoContraseña";
            this.CuadroTextoContraseña.Size = new System.Drawing.Size(299, 26);
            this.CuadroTextoContraseña.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "NIF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña";
            // 
            // BotonLogin
            // 
            this.BotonLogin.Location = new System.Drawing.Point(242, 170);
            this.BotonLogin.Name = "BotonLogin";
            this.BotonLogin.Size = new System.Drawing.Size(82, 35);
            this.BotonLogin.TabIndex = 4;
            this.BotonLogin.Text = "Login";
            this.BotonLogin.UseVisualStyleBackColor = true;
            this.BotonLogin.Click += new System.EventHandler(this.BotonLogin_Click);
            // 
            // BotonRetroceder
            // 
            this.BotonRetroceder.Location = new System.Drawing.Point(23, 12);
            this.BotonRetroceder.Name = "BotonRetroceder";
            this.BotonRetroceder.Size = new System.Drawing.Size(75, 32);
            this.BotonRetroceder.TabIndex = 12;
            this.BotonRetroceder.Text = "BACK";
            this.BotonRetroceder.UseVisualStyleBackColor = true;
            this.BotonRetroceder.Click += new System.EventHandler(this.BotonRetroceder_Click);
            // 
            // Autentificacion_Candidatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 235);
            this.Controls.Add(this.BotonRetroceder);
            this.Controls.Add(this.BotonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuadroTextoContraseña);
            this.Controls.Add(this.CuadroTextoUsuario);
            this.Name = "Autentificacion_Candidatos";
            this.Text = "Autentificacion_Candidatos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Autentificacion_Candidatos_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CuadroTextoUsuario;
        private System.Windows.Forms.TextBox CuadroTextoContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BotonLogin;
        private System.Windows.Forms.Button BotonRetroceder;
    }
}