using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMilagrosChaconIE
{
    public partial class FormMenú : Form
    {
        private void FormMenú_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
        public FormMenú()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormMenú_KeyDown);
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form listado = new FormListado();
            listado.Show();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registro = new FormRegistro();
            registro.Show();
        }

        private void btnCarpetas_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Carpetas = new FormCarpetas();
            Carpetas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form ELCLUB = new FormELCLUB();
            ELCLUB.Show();
        }

        private void pctVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form volver = new FrmInicio();
            volver.Show();
        }

    }
}
