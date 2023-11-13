namespace pryMilagrosChaconIE
{
    partial class FormMenú
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenú));
            this.lblComencemos = new System.Windows.Forms.Label();
            this.btnListado = new System.Windows.Forms.Button();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.btnCarpetas = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // lblComencemos
            // 
            this.lblComencemos.AutoSize = true;
            this.lblComencemos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComencemos.Location = new System.Drawing.Point(113, 178);
            this.lblComencemos.Name = "lblComencemos";
            this.lblComencemos.Size = new System.Drawing.Size(175, 29);
            this.lblComencemos.TabIndex = 2;
            this.lblComencemos.Text = "¡Comencemos!";
            // 
            // btnListado
            // 
            this.btnListado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListado.Location = new System.Drawing.Point(74, 234);
            this.btnListado.Name = "btnListado";
            this.btnListado.Size = new System.Drawing.Size(254, 51);
            this.btnListado.TabIndex = 3;
            this.btnListado.Text = "LISTADO DE PROVEEDORES";
            this.btnListado.UseVisualStyleBackColor = true;
            this.btnListado.Click += new System.EventHandler(this.btnListado_Click);
            // 
            // btnRegistro
            // 
            this.btnRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistro.Location = new System.Drawing.Point(74, 291);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(254, 51);
            this.btnRegistro.TabIndex = 4;
            this.btnRegistro.Text = "REGISTRO DE PROVEEDORES";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // btnCarpetas
            // 
            this.btnCarpetas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarpetas.Location = new System.Drawing.Point(74, 348);
            this.btnCarpetas.Name = "btnCarpetas";
            this.btnCarpetas.Size = new System.Drawing.Size(254, 51);
            this.btnCarpetas.TabIndex = 5;
            this.btnCarpetas.Text = "CARPETAS";
            this.btnCarpetas.UseVisualStyleBackColor = true;
            this.btnCarpetas.Click += new System.EventHandler(this.btnCarpetas_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::pryMilagrosChaconIE.Properties.Resources.logo_huella;
            this.pctLogo.Location = new System.Drawing.Point(118, 3);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(171, 172);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 1;
            this.pctLogo.TabStop = false;
            // 
            // pctVolver
            // 
            this.pctVolver.Image = global::pryMilagrosChaconIE.Properties.Resources.volver;
            this.pctVolver.Location = new System.Drawing.Point(12, 12);
            this.pctVolver.Name = "pctVolver";
            this.pctVolver.Size = new System.Drawing.Size(47, 38);
            this.pctVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVolver.TabIndex = 0;
            this.pctVolver.TabStop = false;
            this.pctVolver.Click += new System.EventHandler(this.pctVolver_Click);
            // 
            // FormMenú
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.btnCarpetas);
            this.Controls.Add(this.btnRegistro);
            this.Controls.Add(this.btnListado);
            this.Controls.Add(this.lblComencemos);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.pctVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormMenú";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctVolver;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblComencemos;
        private System.Windows.Forms.Button btnListado;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Button btnCarpetas;
    }
}