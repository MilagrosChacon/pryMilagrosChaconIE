using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Security.Policy;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace pryMilagrosChaconIE
{
    internal class clsLogs
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataAdapter adaptadorBD;
        DataSet objDataSet = new DataSet();

        string rutaBD;
        public string estadoConexion;

        string cadenaConexionBD = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\bdUsers.accdb";

        public clsLogs()
        {
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
            try
            {
                conexionBD = new OleDbConnection(cadenaConexionBD);
                conexionBD.Open();
                objDataSet = new DataSet();
                estadoConexion = "Conectado";
            }
            catch (Exception ex)
            {
                estadoConexion = "Error: " + ex.Message;
            }
        }

        public void ConectarBD()
        {
            try
            {
                conexionBD.ConnectionString = cadenaConexionBD;
                conexionBD.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }

        }

        public void InsertarLog(string usuario, string contraseña)
        {
            try
            {
                ConectarBD();

                comandoBD = new OleDbCommand();
                {
                    comandoBD.Connection = conexionBD;
                    comandoBD.CommandType = System.Data.CommandType.TableDirect;
                    comandoBD.CommandText = "Logs";
                }

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDataSet, "Logs");

                DataTable objTabla = objDataSet.Tables["Logs"];
                DataRow registro = objTabla.NewRow();
                registro["Categoría"] = "Iniciar sesión";
                registro["Fecha/Hora"] = DateTime.Now;
                registro["Descripción"] = "Inicio de sesión exitoso";

                objTabla.Rows.Add(registro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDataSet, "Logs");
                estadoConexion = "Se ha registrado con éxito";
            }
            catch (Exception ex)
            {
                estadoConexion = ex.Message;
            }

        }

        public void RegistroInicioExitoso()
        {
            InsertarLog("Iniciar sesión", "Inicio de sesión exitoso");
        }

        public void RegistroInicioFallido()
        {
            InsertarLog("Iniciar sesión", "Inicio de sesión fallido");
        }
    }
}
