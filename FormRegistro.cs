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
using System.Xml.Linq;

namespace pryMilagrosChaconIE
{
    public partial class FormRegistro : Form
    {
        private void FormRegistro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public FormRegistro()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormRegistro_KeyDown);

            string leerlinea = "";
            string[] separarDatos = new string[0];

            dgvListado.Columns.Clear();
            dgvListado.DataSource = null;

            StreamReader grilla = new StreamReader(@"../../" + "Resources/Listado de aseguradores.csv");
            leerlinea = grilla.ReadLine();
            separarDatos = leerlinea.Split(';');

            foreach (String var in separarDatos)
            {
                dgvListado.Columns.Add(var, var);
            }
            while (grilla.EndOfStream == false)
            {
                leerlinea = grilla.ReadLine();
                separarDatos = leerlinea.Split(';');
                dgvListado.Rows.Add(separarDatos);
            }

            grilla.Close();
        }

        clsLogs logs = new clsLogs();

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Int32 ID = dgvListado.CurrentCell.RowIndex;
            dgvListado.Rows[ID].SetValues(txtNumero.Text, txtEntidad.Text, txtApertura.Text, txtNExpediente.Text, txtJuzgado.Text, txtJurisdiccion.Text, txtDireccion, txtLiqResponsable.Text);
            MessageBox.Show("Fila modificada exitosamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Int32 ID = dgvListado.CurrentCell.RowIndex;
            dgvListado.Rows.RemoveAt(ID);
            MessageBox.Show("Fila eliminada exitosamente");
        }

        private void btnRegistarProv_Click(object sender, EventArgs e)
        {
            dgvListado.Rows.Add(txtNumero.Text, txtEntidad.Text, txtApertura.Text, txtNExpediente.Text, txtJuzgado.Text, txtJurisdiccion.Text, txtDireccion, txtLiqResponsable.Text);

            MessageBox.Show("Registrado");
            txtNumero.Text = "";
            txtEntidad.Text = "";
            txtApertura.Text = "";
            txtNExpediente.Text = "";
            txtJuzgado.Text = "";
            txtJurisdiccion.Text = "";
            txtDireccion.Text = "";
            txtLiqResponsable.Text = "";
            txtNumero.Focus();
            txtEntidad.Focus();
            txtApertura.Focus();
            txtNExpediente.Focus();
            txtJuzgado.Focus();
            txtJurisdiccion.Focus();
            txtDireccion.Focus();
            txtLiqResponsable.Focus();
            btnRegistarProv.Enabled = false;
            txtNumero.Enabled = true;
            txtEntidad.Enabled = true;
            txtApertura.Enabled = true;
            txtNExpediente.Enabled = true;
            txtJuzgado.Enabled = true;
            txtJurisdiccion.Enabled = true;
            txtDireccion.Enabled = true;
            txtLiqResponsable.Enabled = true;

        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEliminar.Enabled = true;
            btnModificar.Enabled = true;
            Int32 FilaActual = dgvListado.CurrentRow.Index;
            txtNumero.Text = dgvListado.Rows[FilaActual].Cells[0].Value.ToString();
            txtEntidad.Text = dgvListado.Rows[FilaActual].Cells[1].Value.ToString();
            txtApertura.Text = dgvListado.Rows[FilaActual].Cells[2].Value.ToString();
            txtNExpediente.Text = dgvListado.Rows[FilaActual].Cells[3].Value.ToString();
            txtJuzgado.Text = dgvListado.Rows[FilaActual].Cells[4].Value.ToString();
            txtJurisdiccion.Text = dgvListado.Rows[FilaActual].Cells[5].Value.ToString();
            txtDireccion.Text = dgvListado.Rows[FilaActual].Cells[6].Value.ToString();
            txtLiqResponsable.Text = dgvListado.Rows[FilaActual].Cells[7].Value.ToString();
        }

        private void pctVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form volver = new FormMenú();
            volver.Show();
        }
    }
}
