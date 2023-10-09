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
        public FormMenú()
        {
            InitializeComponent();
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

        private void pctVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form volver = new FrmInicio();
            volver.Show();
        }
    }
}
