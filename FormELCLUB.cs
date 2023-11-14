using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices.ComTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMilagrosChaconIE
{
    public partial class FormELCLUB : Form
    {
        public FormELCLUB()
        {
            InitializeComponent();
        }

        clsControladorDataBase objBaseDatos;

        private void FormELCLUB_Load(object sender, EventArgs e)
        {
            objBaseDatos = new clsControladorDataBase();

            objBaseDatos.ConectarBDElClub();

            lblIDClienteEstado.Text = objBaseDatos.estadoConexion;

            lblIDClienteEstado.BackColor = Color.Green;


            objBaseDatos.Traer_Datos (dgvListado);

            btnBuscarID.Enabled = false;

            btnBuscarApellido.Enabled = false;

            btnCambiar.Enabled = false;
        }

        int ID = 0;

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            clsControladorDataBase objLogs = new clsControladorDataBase();

            objLogs.Traer_Datos(dgvListado);


            objBaseDatos.BuscarUsuario(int.Parse(txtIDCliente.Text));

            txtIDCliente.Clear();
        }

        private void btnBuscarApellido_Click(object sender, EventArgs e)
        {
            clsControladorDataBase objLogs = new clsControladorDataBase();

            objLogs.Traer_Datos(dgvListado);


            objBaseDatos.BuscarUsuario(int.Parse(txtApellidoCliente.Text));

            txtApellidoCliente.Clear();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            ID = Convert.ToInt32(txtIDClienteEstado.Text);

            clsControladorDataBase objLogin = new clsControladorDataBase();

            objLogin.ModificarEstado(ID);


            clsLogs objLogs = new clsLogs();

            objLogs.RegistroEstadoActivo();

            txtIDClienteEstado.Clear();
        }
    }
}
