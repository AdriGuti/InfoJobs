
namespace InfoJobs.PresentationLayer
{
    partial class Autentificacion_Empresas
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
            this.BotonLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CuadroTextoContraseña = new System.Windows.Forms.TextBox();
            this.CuadroTextoUsuario = new System.Windows.Forms.TextBox();
            this.BotonRetroceder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotonLogin
            // 
            this.BotonLogin.Location = new System.Drawing.Point(262, 189);
            this.BotonLogin.Name = "BotonLogin";
            this.BotonLogin.Size = new System.Drawing.Size(82, 35);
            this.BotonLogin.TabIndex = 9;
            this.BotonLogin.Text = "Login";
            this.BotonLogin.UseVisualStyleBackColor = true;
            this.BotonLogin.Click += new System.EventHandler(this.BotonLogin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Contraseña";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "NIF";
            // 
            // CuadroTextoContraseña
            // 
            this.CuadroTextoContraseña.Location = new System.Drawing.Point(234, 128);
            this.CuadroTextoContraseña.Name = "CuadroTextoContraseña";
            this.CuadroTextoContraseña.Size = new System.Drawing.Size(299, 26);
            this.CuadroTextoContraseña.TabIndex = 6;
            // 
            // CuadroTextoUsuario
            // 
            this.CuadroTextoUsuario.Location = new System.Drawing.Point(234, 78);
            this.CuadroTextoUsuario.Name = "CuadroTextoUsuario";
            this.CuadroTextoUsuario.Size = new System.Drawing.Size(299, 26);
            this.CuadroTextoUsuario.TabIndex = 5;
            // 
            // BotonRetroceder
            // 
            this.BotonRetroceder.Location = new System.Drawing.Point(26, 24);
            this.BotonRetroceder.Name = "BotonRetroceder";
            this.BotonRetroceder.Size = new System.Drawing.Size(75, 32);
            this.BotonRetroceder.TabIndex = 11;
            this.BotonRetroceder.Text = "BACK";
            this.BotonRetroceder.UseVisualStyleBackColor = true;
            this.BotonRetroceder.Click += new System.EventHandler(this.BotonRetroceder_Click);
            // 
            // Autentificacion_Empresas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 302);
            this.Controls.Add(this.BotonRetroceder);
            this.Controls.Add(this.BotonLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CuadroTextoContraseña);
            this.Controls.Add(this.CuadroTextoUsuario);
            this.Name = "Autentificacion_Empresas";
            this.Text = "Autentificacion_Empresas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Autentificacion_Empresas_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CuadroTextoContraseña;
        private System.Windows.Forms.TextBox CuadroTextoUsuario;
        private System.Windows.Forms.Button BotonRetroceder;
    }
}