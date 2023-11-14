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
    public partial class FrmInicio : Form
    {

        private void FrmInicio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        public FrmInicio()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FrmInicio_KeyDown);
        }

        int intentos = 0;
        clsControladorDataBase control = new clsControladorDataBase();
        clsLogs logs = new clsLogs();

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            clsControladorDataBase login = new clsControladorDataBase();

            clsLogs objLogs = new clsLogs();

            if (clsControladorDataBase.acceso == true)
            {
                objLogs.RegistroInicioExitoso();

                this.Hide();
                FrmInicio FrmInicio = new FrmInicio();
                FrmInicio.Show();
            }
            else
            {
                objLogs.RegistroInicioFallido();

                MessageBox.Show("Usuario o contraeña incorrecto", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

    }
}
