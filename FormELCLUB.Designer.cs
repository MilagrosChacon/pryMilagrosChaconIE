namespace pryMilagrosChaconIE
{
    partial class FormELCLUB
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
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.tabBuscarCliente = new System.Windows.Forms.TabControl();
            this.tabID = new System.Windows.Forms.TabPage();
            this.btnBuscarID = new System.Windows.Forms.Button();
            this.lblIDCliente = new System.Windows.Forms.Label();
            this.txtIDCliente = new System.Windows.Forms.TextBox();
            this.tabApellido = new System.Windows.Forms.TabPage();
            this.txtApellidoCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarApellido = new System.Windows.Forms.Button();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.pctVolver = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.grpBuscarCliente = new System.Windows.Forms.GroupBox();
            this.grpEstado = new System.Windows.Forms.GroupBox();
            this.btnCambiar = new System.Windows.Forms.Button();
            this.lblIDClienteEstado = new System.Windows.Forms.Label();
            this.txtIDClienteEstado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.tabBuscarCliente.SuspendLayout();
            this.tabID.SuspendLayout();
            this.tabApellido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.grpBuscarCliente.SuspendLayout();
            this.grpEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(12, 126);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(782, 192);
            this.dgvListado.TabIndex = 5;
            // 
            // tabBuscarCliente
            // 
            this.tabBuscarCliente.Controls.Add(this.tabID);
            this.tabBuscarCliente.Controls.Add(this.tabApellido);
            this.tabBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabBuscarCliente.Location = new System.Drawing.Point(27, 35);
            this.tabBuscarCliente.Name = "tabBuscarCliente";
            this.tabBuscarCliente.SelectedIndex = 0;
            this.tabBuscarCliente.Size = new System.Drawing.Size(340, 158);
            this.tabBuscarCliente.TabIndex = 6;
            // 
            // tabID
            // 
            this.tabID.Controls.Add(this.btnBuscarID);
            this.tabID.Controls.Add(this.lblIDCliente);
            this.tabID.Controls.Add(this.txtIDCliente);
            this.tabID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabID.Location = new System.Drawing.Point(4, 24);
            this.tabID.Name = "tabID";
            this.tabID.Padding = new System.Windows.Forms.Padding(3);
            this.tabID.Size = new System.Drawing.Size(332, 130);
            this.tabID.TabIndex = 0;
            this.tabID.Text = "ID";
            this.tabID.UseVisualStyleBackColor = true;
            // 
            // btnBuscarID
            // 
            this.btnBuscarID.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarID.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarID.Location = new System.Drawing.Point(176, 76);
            this.btnBuscarID.Name = "btnBuscarID";
            this.btnBuscarID.Size = new System.Drawing.Size(89, 29);
            this.btnBuscarID.TabIndex = 15;
            this.btnBuscarID.Text = "Buscar";
            this.btnBuscarID.UseVisualStyleBackColor = true;
            this.btnBuscarID.Click += new System.EventHandler(this.btnBuscarID_Click);
            // 
            // lblIDCliente
            // 
            this.lblIDCliente.AutoSize = true;
            this.lblIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDCliente.Location = new System.Drawing.Point(57, 30);
            this.lblIDCliente.Name = "lblIDCliente";
            this.lblIDCliente.Size = new System.Drawing.Size(98, 16);
            this.lblIDCliente.TabIndex = 22;
            this.lblIDCliente.Text = "ID del cliente";
            // 
            // txtIDCliente
            // 
            this.txtIDCliente.Location = new System.Drawing.Point(60, 49);
            this.txtIDCliente.Name = "txtIDCliente";
            this.txtIDCliente.Size = new System.Drawing.Size(205, 21);
            this.txtIDCliente.TabIndex = 21;
            // 
            // tabApellido
            // 
            this.tabApellido.Controls.Add(this.txtApellidoCliente);
            this.tabApellido.Controls.Add(this.btnBuscarApellido);
            this.tabApellido.Controls.Add(this.lblApellidoCliente);
            this.tabApellido.Location = new System.Drawing.Point(4, 24);
            this.tabApellido.Name = "tabApellido";
            this.tabApellido.Padding = new System.Windows.Forms.Padding(3);
            this.tabApellido.Size = new System.Drawing.Size(332, 130);
            this.tabApellido.TabIndex = 1;
            this.tabApellido.Text = "Apellido";
            this.tabApellido.UseVisualStyleBackColor = true;
            // 
            // txtApellidoCliente
            // 
            this.txtApellidoCliente.Location = new System.Drawing.Point(61, 48);
            this.txtApellidoCliente.Name = "txtApellidoCliente";
            this.txtApellidoCliente.Size = new System.Drawing.Size(205, 21);
            this.txtApellidoCliente.TabIndex = 26;
            // 
            // btnBuscarApellido
            // 
            this.btnBuscarApellido.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnBuscarApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarApellido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarApellido.Location = new System.Drawing.Point(177, 75);
            this.btnBuscarApellido.Name = "btnBuscarApellido";
            this.btnBuscarApellido.Size = new System.Drawing.Size(89, 29);
            this.btnBuscarApellido.TabIndex = 23;
            this.btnBuscarApellido.Text = "Buscar";
            this.btnBuscarApellido.UseVisualStyleBackColor = true;
            this.btnBuscarApellido.Click += new System.EventHandler(this.btnBuscarApellido_Click);
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoCliente.Location = new System.Drawing.Point(58, 29);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(141, 16);
            this.lblApellidoCliente.TabIndex = 25;
            this.lblApellidoCliente.Text = "Apellido del cliente";
            // 
            // pctVolver
            // 
            this.pctVolver.Image = global::pryMilagrosChaconIE.Properties.Resources.volver;
            this.pctVolver.Location = new System.Drawing.Point(12, 12);
            this.pctVolver.Name = "pctVolver";
            this.pctVolver.Size = new System.Drawing.Size(47, 38);
            this.pctVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVolver.TabIndex = 7;
            this.pctVolver.TabStop = false;
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::pryMilagrosChaconIE.Properties.Resources.logo_huella;
            this.pctLogo.Location = new System.Drawing.Point(316, -18);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(171, 172);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 8;
            this.pctLogo.TabStop = false;
            // 
            // grpBuscarCliente
            // 
            this.grpBuscarCliente.Controls.Add(this.tabBuscarCliente);
            this.grpBuscarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBuscarCliente.Location = new System.Drawing.Point(35, 343);
            this.grpBuscarCliente.Name = "grpBuscarCliente";
            this.grpBuscarCliente.Size = new System.Drawing.Size(387, 212);
            this.grpBuscarCliente.TabIndex = 10;
            this.grpBuscarCliente.TabStop = false;
            this.grpBuscarCliente.Text = "Buscar Cliente";
            // 
            // grpEstado
            // 
            this.grpEstado.Controls.Add(this.btnCambiar);
            this.grpEstado.Controls.Add(this.lblIDClienteEstado);
            this.grpEstado.Controls.Add(this.txtIDClienteEstado);
            this.grpEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEstado.Location = new System.Drawing.Point(449, 343);
            this.grpEstado.Name = "grpEstado";
            this.grpEstado.Size = new System.Drawing.Size(323, 152);
            this.grpEstado.TabIndex = 11;
            this.grpEstado.TabStop = false;
            this.grpEstado.Text = "Estado de activo";
            // 
            // btnCambiar
            // 
            this.btnCambiar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCambiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCambiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCambiar.Location = new System.Drawing.Point(183, 100);
            this.btnCambiar.Name = "btnCambiar";
            this.btnCambiar.Size = new System.Drawing.Size(89, 29);
            this.btnCambiar.TabIndex = 23;
            this.btnCambiar.Text = "Cambiar";
            this.btnCambiar.UseVisualStyleBackColor = true;
            this.btnCambiar.Click += new System.EventHandler(this.btnCambiar_Click);
            // 
            // lblIDClienteEstado
            // 
            this.lblIDClienteEstado.AutoSize = true;
            this.lblIDClienteEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDClienteEstado.Location = new System.Drawing.Point(64, 54);
            this.lblIDClienteEstado.Name = "lblIDClienteEstado";
            this.lblIDClienteEstado.Size = new System.Drawing.Size(98, 16);
            this.lblIDClienteEstado.TabIndex = 25;
            this.lblIDClienteEstado.Text = "ID del cliente";
            // 
            // txtIDClienteEstado
            // 
            this.txtIDClienteEstado.Location = new System.Drawing.Point(67, 73);
            this.txtIDClienteEstado.Name = "txtIDClienteEstado";
            this.txtIDClienteEstado.Size = new System.Drawing.Size(205, 22);
            this.txtIDClienteEstado.TabIndex = 24;
            // 
            // FormELCLUB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(806, 587);
            this.Controls.Add(this.grpEstado);
            this.Controls.Add(this.grpBuscarCliente);
            this.Controls.Add(this.pctVolver);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.pctLogo);
            this.Name = "FormELCLUB";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EL CLUB - BD";
            this.Load += new System.EventHandler(this.FormELCLUB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.tabBuscarCliente.ResumeLayout(false);
            this.tabID.ResumeLayout(false);
            this.tabID.PerformLayout();
            this.tabApellido.ResumeLayout(false);
            this.tabApellido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.grpBuscarCliente.ResumeLayout(false);
            this.grpEstado.ResumeLayout(false);
            this.grpEstado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.TabControl tabBuscarCliente;
        private System.Windows.Forms.TabPage tabID;
        private System.Windows.Forms.TabPage tabApellido;
        private System.Windows.Forms.PictureBox pctVolver;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.Label lblIDCliente;
        private System.Windows.Forms.TextBox txtIDCliente;
        private System.Windows.Forms.Button btnBuscarID;
        private System.Windows.Forms.Button btnBuscarApellido;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.TextBox txtApellidoCliente;
        private System.Windows.Forms.GroupBox grpBuscarCliente;
        private System.Windows.Forms.GroupBox grpEstado;
        private System.Windows.Forms.Button btnCambiar;
        private System.Windows.Forms.Label lblIDClienteEstado;
        private System.Windows.Forms.TextBox txtIDClienteEstado;
    }
}