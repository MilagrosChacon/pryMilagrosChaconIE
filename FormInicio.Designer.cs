namespace pryMilagrosChaconIE
{
    partial class FrmInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lblCyberSecure = new System.Windows.Forms.Label();
            this.lblEslogan = new System.Windows.Forms.Label();
            this.grpIniciarSesion = new System.Windows.Forms.GroupBox();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.grpIniciarSesion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pctLogo
            // 
            this.pctLogo.BackColor = System.Drawing.Color.Transparent;
            this.pctLogo.Image = global::pryMilagrosChaconIE.Properties.Resources.logo_huella;
            this.pctLogo.Location = new System.Drawing.Point(-18, 28);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(170, 144);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 0;
            this.pctLogo.TabStop = false;
            // 
            // lblCyberSecure
            // 
            this.lblCyberSecure.AutoSize = true;
            this.lblCyberSecure.BackColor = System.Drawing.Color.Transparent;
            this.lblCyberSecure.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCyberSecure.ForeColor = System.Drawing.SystemColors.Window;
            this.lblCyberSecure.Location = new System.Drawing.Point(103, 78);
            this.lblCyberSecure.Name = "lblCyberSecure";
            this.lblCyberSecure.Size = new System.Drawing.Size(237, 42);
            this.lblCyberSecure.TabIndex = 1;
            this.lblCyberSecure.Text = "CyberSecure";
            // 
            // lblEslogan
            // 
            this.lblEslogan.AutoSize = true;
            this.lblEslogan.BackColor = System.Drawing.Color.Transparent;
            this.lblEslogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEslogan.ForeColor = System.Drawing.SystemColors.Window;
            this.lblEslogan.Location = new System.Drawing.Point(106, 120);
            this.lblEslogan.Name = "lblEslogan";
            this.lblEslogan.Size = new System.Drawing.Size(228, 20);
            this.lblEslogan.TabIndex = 2;
            this.lblEslogan.Text = "Tu seguridad, nuestra prioridad";
            // 
            // grpIniciarSesion
            // 
            this.grpIniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.grpIniciarSesion.Controls.Add(this.btnIniciarSesion);
            this.grpIniciarSesion.Controls.Add(this.txtContraseña);
            this.grpIniciarSesion.Controls.Add(this.txtUsuario);
            this.grpIniciarSesion.Controls.Add(this.lblContraseña);
            this.grpIniciarSesion.Controls.Add(this.lblUsuario);
            this.grpIniciarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpIniciarSesion.ForeColor = System.Drawing.SystemColors.Window;
            this.grpIniciarSesion.Location = new System.Drawing.Point(26, 152);
            this.grpIniciarSesion.Name = "grpIniciarSesion";
            this.grpIniciarSesion.Size = new System.Drawing.Size(308, 157);
            this.grpIniciarSesion.TabIndex = 3;
            this.grpIniciarSesion.TabStop = false;
            this.grpIniciarSesion.Text = "Iniciar Sesión";
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnIniciarSesion.Location = new System.Drawing.Point(151, 107);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(135, 33);
            this.btnIniciarSesion.TabIndex = 8;
            this.btnIniciarSesion.Text = "Iniciar Sesión";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.btnIniciarSesion_Click);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(118, 68);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(168, 24);
            this.txtContraseña.TabIndex = 7;
            this.txtContraseña.UseSystemPasswordChar = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(118, 36);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(168, 24);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.ForeColor = System.Drawing.SystemColors.Window;
            this.lblContraseña.Location = new System.Drawing.Point(16, 74);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(96, 20);
            this.lblContraseña.TabIndex = 5;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.Window;
            this.lblUsuario.Location = new System.Drawing.Point(44, 42);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 20);
            this.lblUsuario.TabIndex = 4;
            this.lblUsuario.Text = "Usuario:";
            // 
            // FrmInicio
            // 
            this.AcceptButton = this.btnIniciarSesion;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::pryMilagrosChaconIE.Properties.Resources.fondo_inicio;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.grpIniciarSesion);
            this.Controls.Add(this.lblEslogan);
            this.Controls.Add(this.lblCyberSecure);
            this.Controls.Add(this.pctLogo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FrmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CyberSecure";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.grpIniciarSesion.ResumeLayout(false);
            this.grpIniciarSesion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblCyberSecure;
        private System.Windows.Forms.Label lblEslogan;
        private System.Windows.Forms.GroupBox grpIniciarSesion;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Button btnIniciarSesion;
    }
}

