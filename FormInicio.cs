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
        private int intentosFallidos = 0;
        private const int intentosMaximos = 3;
        private const string usuarioCorrecto = "Milagros";
        private const string contraseñaCorrecta = "1913";

        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contraseña = txtContraseña.Text;

            if (usuario == usuarioCorrecto && contraseña == contraseñaCorrecta)
            {
                Form menu = new FormMenú();
                menu.Show();
                this.Hide();

            }
            else
            {
                intentosFallidos++;
                MessageBox.Show("El nombre de usuario o contraseña son incorrectos");
                txtUsuario.Text = "";
                txtContraseña.Text = "";

                if (intentosFallidos >= intentosMaximos)
                {
                    MessageBox.Show("Has excedido el número máximo de intentos permitidos. Tu cuenta ha sido bloqueada.");
                    this.Close();
                }
            }
        }
    }
}
