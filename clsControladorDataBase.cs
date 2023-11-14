using System;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Security.Policy;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pryMilagrosChaconIE
{
    internal class clsControladorDataBase
    {
        OleDbConnection conexionBD = new OleDbConnection();
        OleDbCommand comandoBD = new OleDbCommand();
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD;

        DataSet objDataSet = new DataSet();

        string rutaBD;
        public string estadoConexion = "";
        public static bool acceso;
        string cadenaConexionBD = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\bdUsers.accdb";
        string cadenaConexionELCLUB = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EL_CLUB.accdb";


        public clsControladorDataBase()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionELCLUB;
                conexionBD.Open();

                objDataSet = new DataSet();

                estadoConexion = "Conectado";
            }
            catch (Exception EX)
            {
                estadoConexion = EX.Message;
            }

            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
        }

        public void ConectarBD()
        {
            try
            {
                conexionBD.ConnectionString = cadenaConexionBD;
                conexionBD.Open();
            }
            catch (Exception EX)
            {
                MessageBox.Show(Convert.ToString(EX));
            }
        }

        public void ConectarBDElClub()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionELCLUB;
                conexionBD.Open();
                estadoConexion = "Conectado";
            }
            catch (Exception EX)
            {
                estadoConexion = "Error:" + EX.Message;
            }
        }

        public void Traer_Datos(DataGridView grilla)
        {
            string estadoCliente = "";

            try
            {
                comandoBD = new OleDbCommand();

                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SOCIOS";

                lectorBD = comandoBD.ExecuteReader();

                grilla.Columns.Add("ID", "ID");
                grilla.Columns.Add("Nombre", "Nombre");
                grilla.Columns.Add("Apellido", "Apellido");
                grilla.Columns.Add("Nacionalidad", "Nacionalidad");
                grilla.Columns.Add("Edad", "Edad");
                grilla.Columns.Add("Sexo", "Sexo");
                grilla.Columns.Add("Ingreso", "Ingreso");
                grilla.Columns.Add("Puntaje", "Puntaje");
                grilla.Columns.Add("Estado", "Estado");

                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        if (lectorBD.GetBoolean(8) == true)
                        {
                            estadoCliente = "Activo";
                        }
                        else
                        {
                            estadoCliente = "Inactivo";
                        }

                        grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[6], lectorBD[7], estadoCliente);

                    }
                }
            }
            catch (Exception EX)
            {
                estadoConexion = "Error:" + EX.Message;
            }
        }
        public void BuscarUsuario(int Usuario)
        {
            OleDbDataReader lector;
            lector = comandoBD.ExecuteReader();
            if (lector.HasRows)
            {
                bool existe = false;
                while (lector.Read())
                {
                    if (int.Parse(lector[0].ToString()) == Usuario)
                    {
                        MessageBox.Show("Cliente Existe",
                            "Consulta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        existe = true;
                        break;
                    }
                }
                if (existe == false)
                {
                    MessageBox.Show("Este cliente No Existe",
                            "Consulta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                }
                lector.Close();
            }
        }

        public Boolean BuscarContraseña(string Usuario, string Contraseña)
        {
            Boolean coincide = false;
            try
            {
                OleDbDataReader lector;
                lector = comandoBD.ExecuteReader();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        if (lector[1].ToString() == Usuario && lector[2].ToString() == Contraseña)
                        {
                            coincide = true;
                            lector.Close();
                            return coincide;
                        }
                    }
                }
                lector.Close();
                return coincide;
            }
            catch (Exception)
            {
                return coincide;
            }
        }

        public void ModificarEstado(int id)
        {
            OleDbCommand comandoBD = new OleDbCommand();
            OleDbDataAdapter objAdaptador;

            DataSet objDataSet = new DataSet();

            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionELCLUB;
                conexionBD.Open();

                estadoConexion = "Conectado";

            }
            catch (Exception EX)
            {
                estadoConexion = "Error" + EX.Message;
            }

            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "SOCIO";

            objAdaptador = new OleDbDataAdapter(comandoBD);
            objAdaptador.Fill(objDataSet, "SOCIO");

            DataTable dt = objDataSet.Tables["SOCIO"];

            foreach (DataRow registro in dt.Rows)
            {
                if ((int)registro["CODIGO_SOCIO"] == id)
                {
                    registro.BeginEdit();

                    if ((bool)registro["ESTADO"])
                    {
                        registro["ESTADO"] = false;
                    }
                    else
                    {
                        registro["ESTADO"] = true;
                    }

                    registro.EndEdit();

                    break;
                }
            }

            OleDbCommandBuilder constructor = new OleDbCommandBuilder(objAdaptador);

            objAdaptador.Update(objDataSet, "SOCIOS");

            MessageBox.Show("Cambio de estado exitoso");
        }
    }
}
