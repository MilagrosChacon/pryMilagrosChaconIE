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
        // Definición de variables de conexión y adaptador
        OleDbConnection conexionBD;
        OleDbCommand comandoBD;
        OleDbDataAdapter adaptadorBD;
        DataSet objDataSet = new DataSet();

        // Definición de variables relacionadas con la base de datos y estado de la conexión
        string rutaBD;
        public string estadoConexion;

        // Cadena de conexión a la base de datos
        string cadenaConexionBD = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\bdUsers.accdb";

        public clsLogs()
        {
            // Inicialización de objetos de conexión y comando
            conexionBD = new OleDbConnection();
            comandoBD = new OleDbCommand();

            try
            {
                // Establece la cadena de conexión y abre la conexión a la base de datos
                conexionBD = new OleDbConnection(cadenaConexionBD);
                conexionBD.Open();
                objDataSet = new DataSet();
                estadoConexion = "Conectado"; // Estado de conexión exitosa
            }
            catch (Exception ex)
            {
                // En caso de error, establece el estado de la conexión con un mensaje de error
                estadoConexion = "Error: " + ex.Message;
            }
        }

        public void ConectarBD()
        {
            try
            {
                // Configuración de la cadena de conexión
                conexionBD.ConnectionString = cadenaConexionBD;
                conexionBD.Open();

            }
            catch (Exception ex)
            {
                // En caso de error, muestra un mensaje de MessageBox con la información de la excepción
                MessageBox.Show(Convert.ToString(ex));
            }

        }

        public void InsertarLog(string usuario, string contraseña)  // Método para insertar un registro de log en la base de datos
        {
            try
            {
                // Llama al método ConectarBD
                ConectarBD();

                // Configuración del comando para trabajar con la tabla "Logs"
                comandoBD = new OleDbCommand();
                {
                    comandoBD.Connection = conexionBD;
                    comandoBD.CommandType = System.Data.CommandType.TableDirect;
                    comandoBD.CommandText = "Logs";
                }

                // Configuración de un adaptador y llena el DataSet con los datos de la tabla "Logs"
                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDataSet, "Logs");

                // Obtiene la tabla "Logs" del DataSet
                DataTable objTabla = objDataSet.Tables["Logs"];

                // Crea un nuevo registro con información específica
                DataRow registro = objTabla.NewRow();
                registro["Categoría"] = "Iniciar sesión";
                registro["Fecha/Hora"] = DateTime.Now;
                registro["Descripción"] = "Inicio de sesión exitoso";

                // Agrega el nuevo registro a la tabla
                objTabla.Rows.Add(registro);

                // Crea un constructor de comandos para el adaptador
                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                // Actualiza la base de datos con el nuevo registro
                adaptadorBD.Update(objDataSet, "Logs");

                // Actualiza el estado de la conexión con un mensaje de éxito
                estadoConexion = "Se ha registrado con éxito";
            }
            catch (Exception ex)
            {
                // En caso de error, actualiza el estado de la conexión con el mensaje de error
                estadoConexion = ex.Message;
            }

        }

        public void RegistroInicioExitoso()  // Método para registrar eventos específicos de inicio de sesión exitoso

        {
            InsertarLog("Iniciar sesión", "Inicio de sesión exitoso");
        }

        public void RegistroInicioFallido() // Método para registrar eventos específicos de inicio de sesión fallido
        {
            InsertarLog("Iniciar sesión", "Inicio de sesión fallido");
        }

        public void RegistroEstadoActivo()
        {
            try
            {
                // Establezco la conexión con la base de datos
                ConectarBD();

                // Creación de un nuevo comando para trabajar con la tabla "Logs"
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "Logs";

                // Creación de un adaptador de datos y llena el DataSet con los datos de la tabla "Logs"
                adaptadorBD = new OleDbDataAdapter(comandoBD);
                adaptadorBD.Fill(objDataSet, "Logs");

                // Creación de un nuevo registro en la tabla "Logs"
                DataTable objTabla = objDataSet.Tables["Logs"];
                DataRow registro = objTabla.NewRow();
                registro["Categoría"] = "Cambiar estado";
                registro["Fecha/Hora"] = DateTime.Now;
                registro["Descripción"] = "Exitoso";

                // Agrega el nuevo registro a la tabla "Logs"
                objTabla.Rows.Add(registro);

                // Creación de un constructor de comandos para el adaptador
                OleDbCommandBuilder constructor = new OleDbCommandBuilder(adaptadorBD);

                // Actualización de la base de datos con los cambios en el DataSet
                adaptadorBD.Update(objDataSet, "Logs");

                // Establezco el estado de conexión como "Se ha registrado con éxito"
                estadoConexion = "Se ha registrado con éxito";
            }
            catch (Exception EX)
            {
                // En caso de error, establecezco el estado de conexión con el mensaje de la excepción
                estadoConexion = EX.Message;
            }
        }
    }
}
