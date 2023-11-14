using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Security.Policy;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pryMilagrosChaconIE
{
    internal class clsLogs
    {
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataReader lectorBD;

        OleDbDataAdapter adaptadorBD;
        DataSet objDataSet = new DataSet();

        string rutaBD;
        public string estadoConexion;
        string cadenaConexionBD = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\bdUsers.accdb";
        string cadenaConexionELCLUB = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

        public clsLogs()
        {
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();
            try
            {
                cadenaConexionBD = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\bdUsers.accdb";

                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionBD;
                conexionBD.Open();

                objDataSet = new DataSet();

                estadoConexion = "Conectado";
            }
            catch (Exception EX)
            {
                estadoConexion = "Error: " + EX.Message;
            }
        }

        public void ConectarBD()
        {
            try
            {
                string cadenaconexionBD = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\bdUsers.accdb";

                conexionBD.ConnectionString = cadenaConexionBD;
                conexionBD.Open();

            }
            catch (Exception EX)
            {
                MessageBox.Show(Convert.ToString(EX));
            }

        }

        public void RegistroInicioExitoso()
        {
            try
            {
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

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
            catch (Exception EX)
            {
                estadoConexion = EX.Message;
            }

        }

        public void RegistroInicioFallido()
        {
            try
            {
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDataSet, "Logs");

                DataTable objTabla = objDataSet.Tables["Logs"];
                DataRow registro = objTabla.NewRow();
                registro["Categoría"] = "Iniciar sesión";
                registro["Fecha/Hora"] = DateTime.Now;
                registro["Descripción"] = "Inicio de sesión fallido";

                objTabla.Rows.Add(registro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDataSet, "Logs");
                estadoConexion = "Registro fallido";
            }
            catch (Exception EX)
            {
                estadoConexion = EX.Message;
            }
        }

        public void RegistroCarpetas()
        {
            try
            {
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDataSet, "Logs");

                DataTable objTabla = objDataSet.Tables["Logs"];
                DataRow registro = objTabla.NewRow();
                registro["Categoría"] = "Ver carpetas";
                registro["Fecha/Hora"] = DateTime.Now;
                registro["Descripción"] = "Exitoso";

                objTabla.Rows.Add(registro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDataSet, "Logs");
                estadoConexion = "Se ha registrado con éxito";
            }
            catch (Exception EX)
            {
                estadoConexion = EX.Message;
            }
        }

        public void RegistroRegistrar()
        {
            try
            {
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDataSet, "Logs");

                DataTable objTabla = objDataSet.Tables["Logs"];
                DataRow registro = objTabla.NewRow();
                registro["Categoría"] = "Registrar";
                registro["Fecha/Hora"] = DateTime.Now;
                registro["Descripción"] = "Exitoso";

                objTabla.Rows.Add(registro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDataSet, "Logs");
                estadoConexion = "Se ha registrado con éxito";
            }
            catch (Exception EX)
            {
                estadoConexion = EX.Message;
            }
        }

        public void RegistroModificar()
        {
            try
            {
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDataSet, "Logs");

                DataTable objTabla = objDataSet.Tables["Logs"];
                DataRow registro = objTabla.NewRow();
                registro["Categoría"] = "Modificar";
                registro["Fecha/Hora"] = DateTime.Now;
                registro["Descripción"] = "Exitoso";

                objTabla.Rows.Add(registro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDataSet, "Logs");
                estadoConexion = "Se ha registrado con éxito";
            }
            catch (Exception EX)
            {
                estadoConexion = EX.Message;
            }
        }

        public void RegistroEliminar()
        {
            try
            {
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDataSet, "Logs");

                DataTable objTabla = objDataSet.Tables["Logs"];
                DataRow registro = objTabla.NewRow();
                registro["Categoría"] = "Eliminar";
                registro["Fecha/Hora"] = DateTime.Now;
                registro["Descripción"] = "Exitoso";

                objTabla.Rows.Add(registro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDataSet, "Logs");
                estadoConexion = "Se ha registrado con éxito";
            }
            catch (Exception EX)
            {
                estadoConexion = EX.Message;
            }
        }

        public void RegistroBuscarClienteID()
        {
            try
            {
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDataSet, "Logs");

                DataTable objTabla = objDataSet.Tables["Logs"];
                DataRow registro = objTabla.NewRow();
                registro["Categoría"] = "Buscar cliente por ID";
                registro["Fecha/Hora"] = DateTime.Now;
                registro["Descripción"] = "Exitoso";

                objTabla.Rows.Add(registro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDataSet, "Logs");
                estadoConexion = "Se ha registrado con éxito";
            }
            catch (Exception EX)
            {
                estadoConexion = EX.Message;
            }
        }
        public void RegistroBuscarClienteApellido()
        {
            try
            {
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDataSet, "Logs");

                DataTable objTabla = objDataSet.Tables["Logs"];
                DataRow registro = objTabla.NewRow();
                registro["Categoría"] = "Buscar cliente por Apellido";
                registro["Fecha/Hora"] = DateTime.Now;
                registro["Descripción"] = "Exitoso";

                objTabla.Rows.Add(registro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDataSet, "Logs");
                estadoConexion = "Se ha registrado con éxito";
            }
            catch (Exception EX)
            {
                estadoConexion = EX.Message;
            }
        }

        public void RegistroEstadoActivo()
        {
            try
            {
                ConectarBD();
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;

                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDataSet, "Logs");

                DataTable objTabla = objDataSet.Tables["Logs"];
                DataRow registro = objTabla.NewRow();
                registro["Categoría"] = "Cambiar estado";
                registro["Fecha/Hora"] = DateTime.Now;
                registro["Descripción"] = "Exitoso";

                objTabla.Rows.Add(registro);

                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                adaptadorBD.Update(objDataSet, "Logs");
                estadoConexion = "Se ha registrado con éxito";
            }
            catch (Exception EX)
            {
                estadoConexion = EX.Message;
            }
        }
    }
}
