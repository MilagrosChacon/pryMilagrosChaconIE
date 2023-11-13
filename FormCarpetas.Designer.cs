namespace pryMilagrosChaconIE
{
    partial class FormCarpetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCarpetas));
            this.pctVolver = new System.Windows.Forms.PictureBox();
            this.pctLogo = new System.Windows.Forms.PictureBox();
            this.lstMostrar = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.trvMostrar = new System.Windows.Forms.TreeView();
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pctVolver
            // 
            this.pctVolver.Image = global::pryMilagrosChaconIE.Properties.Resources.volver;
            this.pctVolver.Location = new System.Drawing.Point(12, 12);
            this.pctVolver.Name = "pctVolver";
            this.pctVolver.Size = new System.Drawing.Size(47, 38);
            this.pctVolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctVolver.TabIndex = 3;
            this.pctVolver.TabStop = false;
            this.pctVolver.Click += new System.EventHandler(this.pctVolver_Click);
            // 
            // pctLogo
            // 
            this.pctLogo.Image = global::pryMilagrosChaconIE.Properties.Resources.logo_huella;
            this.pctLogo.Location = new System.Drawing.Point(317, -14);
            this.pctLogo.Name = "pctLogo";
            this.pctLogo.Size = new System.Drawing.Size(171, 172);
            this.pctLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pctLogo.TabIndex = 4;
            this.pctLogo.TabStop = false;
            // 
            // lstMostrar
            // 
            this.lstMostrar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstMostrar.HideSelection = false;
            this.lstMostrar.Location = new System.Drawing.Point(262, 164);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(501, 450);
            this.lstMostrar.SmallImageList = this.imageList1;
            this.lstMostrar.TabIndex = 16;
            this.lstMostrar.UseCompatibleStateImageBehavior = false;
            this.lstMostrar.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tipo";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Última modificación";
            this.columnHeader3.Width = 125;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "carpeta.png");
            this.imageList1.Images.SetKeyName(1, "archivo.png");
            // 
            // trvMostrar
            // 
            this.trvMostrar.ImageIndex = 0;
            this.trvMostrar.ImageList = this.imageList1;
            this.trvMostrar.Location = new System.Drawing.Point(56, 164);
            this.trvMostrar.Name = "trvMostrar";
            this.trvMostrar.SelectedImageIndex = 0;
            this.trvMostrar.Size = new System.Drawing.Size(200, 450);
            this.trvMostrar.TabIndex = 15;
            this.trvMostrar.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.trvMostrar_NodeMouseClick);
            // 
            // FormCarpetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(808, 626);
            this.Controls.Add(this.lstMostrar);
            this.Controls.Add(this.trvMostrar);
            this.Controls.Add(this.pctLogo);
            this.Controls.Add(this.pctVolver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "FormCarpetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carpetas";
            ((System.ComponentModel.ISupportInitialize)(this.pctVolver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pctVolver;
        private System.Windows.Forms.PictureBox pctLogo;
        private System.Windows.Forms.ListView lstMostrar;
        private System.Windows.Forms.TreeView trvMostrar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}