using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace pryMilagrosChaconIE
{
    public partial class FormListado : Form
    {
        string leerLinea;
        string[] separarDatos;

        private void FormListado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public FormListado()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormListado_KeyDown);
        }

        clsLogs logs = new clsLogs();

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(@"../../" + "Resources/Listado de aseguradores.csv");

            leerLinea = sr.ReadLine();
            separarDatos = leerLinea.Split(';');

            for (int indice = 0; indice < separarDatos.Length; indice++)
            {
                dgvListado.Columns.Add(separarDatos[indice], separarDatos[indice]);
            }

            while (sr.EndOfStream == false)
            {
                leerLinea = sr.ReadLine();
                separarDatos = leerLinea.Split(';');
                dgvListado.Rows.Add(separarDatos);
            }

            sr.Close();
        }

        private void btnNuevoProv_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form registro = new FormRegistro();
            registro.Show();
        }

        private void pctVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form volver = new FormMenú();
            volver.Show();
        }
    }
}
