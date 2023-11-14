namespace pryMilagrosChaconIE
{
    partial class FormRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistro));
            this.dgvListado = new System.Windows.Forms.DataGridView();
            this.grpNuevoProv = new System.Windows.Forms.GroupBox();
            this.txtLiqResponsable = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtJurisdiccion = new System.Windows.Forms.TextBox();
            this.txtJuzgado = new System.Windows.Forms.TextBox();
            this.txtNExpediente = new System.Windows.Forms.TextBox();
            this.txtApertura = new System.Windows.Forms.TextBox();
            this.txtEntidad = new System.Windows.Forms.TextBox();
            this.lblLiqResponsable = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblJurisdiccion = new System.Windows.Forms.Label();
            this.lblJuzgado = new System.Windows.Forms.Label();
            this.lblNExpediente = new System.Windows.Forms.Label();
            this.lblApertura = new System.Windows.Forms.Label();
            this.lblEntidad = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnRegistarProv = new System.Windows.Forms.Button();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.pctVolver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.grpNuevoProv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListado
            // 
            this.dgvListado.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvListado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(26, 133);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.Size = new System.Drawing.Size(753, 192);
            this.dgvListado.TabIndex = 4;
            this.dgvListado.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListado_CellContentClick);
            // 
            // grpNuevoProv
            // 
            this.grpNuevoProv.Controls.Add(this.txtLiqResponsable);
            this.grpNuevoProv.Controls.Add(this.txtDireccion);
            this.grpNuevoProv.Controls.Add(this.txtJurisdiccion);
            this.grpNuevoProv.Controls.Add(this.txtJuzgado);
            this.grpNuevoProv.Controls.Add(this.txtNExpediente);
            this.grpNuevoProv.Controls.Add(this.txtApertura);
            this.grpNuevoProv.Controls.Add(this.txtEntidad);
            this.grpNuevoProv.Controls.Add(this.lblLiqResponsable);
            this.grpNuevoProv.Controls.Add(this.lblDireccion);
            this.grpNuevoProv.Controls.Add(this.lblJurisdiccion);
            this.grpNuevoProv.Controls.Add(this.lblJuzgado);
            this.grpNuevoProv.Controls.Add(this.lblNExpediente);
            this.grpNuevoProv.Controls.Add(this.lblApertura);
            this.grpNuevoProv.Controls.Add(this.lblEntidad);
            this.grpNuevoProv.Controls.Add(this.lblNumero);
            this.grpNuevoProv.Controls.Add(this.txtNumero);
            this.grpNuevoProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNuevoProv.Location = new System.Drawing.Point(18, 331);
            this.grpNuevoProv.Name = "grpNuevoProv";
            this.grpNuevoProv.Size = new System.Drawing.Size(776, 241);
            this.grpNuevoProv.TabIndex = 5;
            this.grpNuevoProv.TabStop = false;
            this.grpNuevoProv.Text = "Nuevo Proveedor";
            // 
            // txtLiqResponsable
            // 
            this.txtLiqResponsable.Location = new System.Drawing.Point(531, 168);
            this.txtLiqResponsable.Name = "txtLiqResponsable";
            this.txtLiqResponsable.Size = new System.Drawing.Size(216, 22);
            this.txtLiqResponsable.TabIndex = 34;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(531, 134);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(216, 22);
            this.txtDireccion.TabIndex = 33;
            // 
            // txtJurisdiccion
            // 
            this.txtJurisdiccion.Location = new System.Drawing.Point(531, 98);
            this.txtJurisdiccion.Name = "txtJurisdiccion";
            this.txtJurisdiccion.Size = new System.Drawing.Size(216, 22);
            this.txtJurisdiccion.TabIndex = 32;
            // 
            // txtJuzgado
            // 
            this.txtJuzgado.Location = new System.Drawing.Point(531, 63);
            this.txtJuzgado.Name = "txtJuzgado";
            this.txtJuzgado.Size = new System.Drawing.Size(216, 22);
            this.txtJuzgado.TabIndex = 31;
            // 
            // txtNExpediente
            // 
            this.txtNExpediente.Location = new System.Drawing.Point(130, 169);
            this.txtNExpediente.Name = "txtNExpediente";
            this.txtNExpediente.Size = new System.Drawing.Size(205, 22);
            this.txtNExpediente.TabIndex = 30;
            // 
            // txtApertura
            // 
            this.txtApertura.Location = new System.Drawing.Point(130, 132);
            this.txtApertura.Name = "txtApertura";
            this.txtApertura.Size = new System.Drawing.Size(205, 22);
            this.txtApertura.TabIndex = 29;
            // 
            // txtEntidad
            // 
            this.txtEntidad.Location = new System.Drawing.Point(130, 96);
            this.txtEntidad.Name = "txtEntidad";
            this.txtEntidad.Size = new System.Drawing.Size(205, 22);
            this.txtEntidad.TabIndex = 28;
            // 
            // lblLiqResponsable
            // 
            this.lblLiqResponsable.AutoSize = true;
            this.lblLiqResponsable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLiqResponsable.Location = new System.Drawing.Point(347, 172);
            this.lblLiqResponsable.Name = "lblLiqResponsable";
            this.lblLiqResponsable.Size = new System.Drawing.Size(178, 16);
            this.lblLiqResponsable.TabIndex = 27;
            this.lblLiqResponsable.Text = "Liquidador Responsable";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDireccion.Location = new System.Drawing.Point(452, 135);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(73, 16);
            this.lblDireccion.TabIndex = 26;
            this.lblDireccion.Text = "Dirección";
            // 
            // lblJurisdiccion
            // 
            this.lblJurisdiccion.AutoSize = true;
            this.lblJurisdiccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJurisdiccion.Location = new System.Drawing.Point(435, 99);
            this.lblJurisdiccion.Name = "lblJurisdiccion";
            this.lblJurisdiccion.Size = new System.Drawing.Size(90, 16);
            this.lblJurisdiccion.TabIndex = 25;
            this.lblJurisdiccion.Text = "Jurisdicción";
            // 
            // lblJuzgado
            // 
            this.lblJuzgado.AutoSize = true;
            this.lblJuzgado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblJuzgado.Location = new System.Drawing.Point(459, 67);
            this.lblJuzgado.Name = "lblJuzgado";
            this.lblJuzgado.Size = new System.Drawing.Size(66, 16);
            this.lblJuzgado.TabIndex = 24;
            this.lblJuzgado.Text = "Juzgado";
            // 
            // lblNExpediente
            // 
            this.lblNExpediente.AutoSize = true;
            this.lblNExpediente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNExpediente.Location = new System.Drawing.Point(18, 173);
            this.lblNExpediente.Name = "lblNExpediente";
            this.lblNExpediente.Size = new System.Drawing.Size(106, 16);
            this.lblNExpediente.TabIndex = 23;
            this.lblNExpediente.Text = "Nº Expediente";
            // 
            // lblApertura
            // 
            this.lblApertura.AutoSize = true;
            this.lblApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApertura.Location = new System.Drawing.Point(58, 136);
            this.lblApertura.Name = "lblApertura";
            this.lblApertura.Size = new System.Drawing.Size(66, 16);
            this.lblApertura.TabIndex = 22;
            this.lblApertura.Text = "Apertura";
            // 
            // lblEntidad
            // 
            this.lblEntidad.AutoSize = true;
            this.lblEntidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntidad.Location = new System.Drawing.Point(64, 100);
            this.lblEntidad.Name = "lblEntidad";
            this.lblEntidad.Size = new System.Drawing.Size(60, 16);
            this.lblEntidad.TabIndex = 21;
            this.lblEntidad.Text = "Entidad";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(100, 64);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(24, 16);
            this.lblNumero.TabIndex = 20;
            this.lblNumero.Text = "Nº";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(130, 60);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(205, 22);
            this.txtNumero.TabIndex = 19;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.Location = new System.Drawing.Point(416, 578);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(186, 41);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(224, 578);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(186, 41);
            this.btnEliminar.TabIndex = 15;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnRegistarProv
            // 
            this.btnRegistarProv.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnRegistarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistarProv.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRegistarProv.Location = new System.Drawing.Point(608, 578);
            this.btnRegistarProv.Name = "btnRegistarProv";
            this.btnRegistarProv.Size = new System.Drawing.Size(186, 41);
            this.btnRegistarProv.TabIndex = 14;
            this.btnRegistarProv.Text = "REGISTRAR";
            this.btnRegistarProv.UseVisualStyleBackColor = true;
            this.btnRegistarProv.Click += new System.EventHandler(this.btnRegistarProv_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::pryMilagrosChaconIE.Properties.Resources.logo_huella;
            this.pctLogo.Location = new System.Drawing.Point(316, -14);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(171, 172);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 3;
            this.pctLogo.TabStop = false;
            // 
            // pctVolver
            // 
            this.pctVolver.Image = global::pryMilagrosChaconIE.Properties.Resources.volver;
            this.pctVolver.Location = new System.Drawing.Point(12, 12);
            this.pctVolver.Name = "pctVolver";
            this.pctVolver.Size = new System.Drawing.Size(47, 38);
            this.pctVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVolver.TabIndex = 2;
            this.pctVolver.TabStop = false;
            this.pctVolver.Click += new System.EventHandler(this.pctVolver_Click);
            // 
            // FormRegistro
            // 
            this.AcceptButton = this.btnRegistarProv;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(807, 631);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistarProv);
            this.Controls.Add(this.grpNuevoProv);
            this.Controls.Add(this.dgvListado);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.pctVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de proveedores (ABM)";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.grpNuevoProv.ResumeLayout(false);
            this.grpNuevoProv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctVolver;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.DataGridView dgvListado;
        private System.Windows.Forms.GroupBox grpNuevoProv;
        private System.Windows.Forms.TextBox txtLiqResponsable;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtJurisdiccion;
        private System.Windows.Forms.TextBox txtJuzgado;
        private System.Windows.Forms.TextBox txtNExpediente;
        private System.Windows.Forms.TextBox txtApertura;
        private System.Windows.Forms.TextBox txtEntidad;
        private System.Windows.Forms.Label lblLiqResponsable;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblJurisdiccion;
        private System.Windows.Forms.Label lblJuzgado;
        private System.Windows.Forms.Label lblNExpediente;
        private System.Windows.Forms.Label lblApertura;
        private System.Windows.Forms.Label lblEntidad;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnRegistarProv;
    }
}