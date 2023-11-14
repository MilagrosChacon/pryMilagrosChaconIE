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
        // Definición de variables de conexión y adaptador
        OleDbConnection conexionBD = new OleDbConnection();
        OleDbCommand comandoBD = new OleDbCommand();
        OleDbDataReader lectorBD;
        OleDbDataAdapter adaptadorBD;

        // DataSet para almacenar datos
        DataSet objDataSet = new DataSet();

        // Ruta y estado de conexión
        string rutaBD;
        public string estadoConexion = "";

        // Variable estática para indicar acceso
        public static bool acceso;

        // Cadena de conexión a la base de datos
        string cadenaConexionBD = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\bdUsers.accdb";
        string cadenaConexionELCLUB = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

        public clsControladorDataBase()
        {
            try
            {
                // Configura la conexión a la base de datos EL_CLUB en el constructor
                conexionBD = new OleDbConnection();
                comandoBD = new OleDbCommand();
                conexionBD.ConnectionString = cadenaConexionELCLUB;
                conexionBD.Open();

                // Inicializa el DataSet
                objDataSet = new DataSet();

                // Establece el estado de conexión como "Conectado"
                estadoConexion = "Conectado";
            }
            catch (Exception EX)
            {
                // En caso de error, registra el mensaje de error
                estadoConexion = EX.Message;
            }
        }

        public void ConectarBD() // Método para conectar a la base de datos bdUsers
        {
            try
            {
                // Configura la cadena de conexión y abre la conexión
                conexionBD.ConnectionString = cadenaConexionBD;
                conexionBD.Open();
            }
            catch (Exception EX)
            {
                // En caso de error, muestra un MessageBox con la información de la excepción
                MessageBox.Show(Convert.ToString(EX));
            }
        }

        public void ConectarBDElClub() // Método para conectar a la base de datos EL_CLUB
        {
            try
            {
                // Configura la conexión a la base de datos EL_CLUB
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionELCLUB;
                conexionBD.Open();

                // Establece el estado de conexión como "Conectado"
                estadoConexion = "Conectado";
            }
            catch (Exception EX)
            {
                // En caso de error, establece el estado de conexión con un mensaje de error
                estadoConexion = "Error:" + EX.Message;
            }
        }

        public void Traer_Datos(DataGridView grilla) // Método para traer datos y mostrarlos en un DataGridView
        {
            string estadoCliente = "";

            try
            {
                // Configura el comando para trabajar con la tabla "SOCIOS"
                comandoBD = new OleDbCommand();
                comandoBD.Connection = conexionBD;
                comandoBD.CommandType = System.Data.CommandType.TableDirect;
                comandoBD.CommandText = "SOCIOS";

                // Ejecuta el comando y obtiene un lector de datos
                lectorBD = comandoBD.ExecuteReader();

                // Agregado de columnas al DataGridView
                grilla.Columns.Add("ID", "ID");
                grilla.Columns.Add("Nombre", "Nombre");
                grilla.Columns.Add("Apellido", "Apellido");
                grilla.Columns.Add("Nacionalidad", "Nacionalidad");
                grilla.Columns.Add("Edad", "Edad");
                grilla.Columns.Add("Sexo", "Sexo");
                grilla.Columns.Add("Ingreso", "Ingreso");
                grilla.Columns.Add("Puntaje", "Puntaje");
                grilla.Columns.Add("Estado", "Estado");

                // Llena el DataGridView con los datos del lector
                if (lectorBD.HasRows)
                {
                    while (lectorBD.Read())
                    {
                        // Determina el estado del cliente
                        estadoCliente = lectorBD.GetBoolean(8) ? "Activo" : "Inactivo";

                        // Agrega una nueva fila al DataGridView
                        grilla.Rows.Add(lectorBD[0], lectorBD[1], lectorBD[2], lectorBD[3], lectorBD[4], lectorBD[6], lectorBD[7], estadoCliente);
                    }
                }
            }
            catch (Exception EX)
            {
                // En caso de error, establece el estado de conexión con un mensaje de error
                estadoConexion = "Error:" + EX.Message;
            }
        }

        public void BuscarUsuario(int Usuario) // Método para buscar un usuario por ID
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
                        // Muestra un MessageBox indicando que el cliente existe
                        MessageBox.Show("Cliente Existe",
                            "Consulta",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        existe = true;
                        break;
                    }
                }
                if (!existe)
                {
                    // Muestra un MessageBox indicando que el cliente no existe
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
                // Ejecuta el lector de datos
                OleDbDataReader lector;
                lector = comandoBD.ExecuteReader();

                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        // Verifica si el usuario y la contraseña coinciden
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
                // Configuración de la conexión a la base de datos EL_CLUB
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexionELCLUB;
                conexionBD.Open();

                // Se establece el estado de conexión como "Conectado"
                estadoConexion = "Conectado";

            }
            catch (Exception EX)
            {
                // En caso de error, se establece el estado de conexión con un mensaje de error
                estadoConexion = "Error" + EX.Message;
            }

            // Configura el comando para trabajar con la tabla "SOCIO"
            comandoBD.Connection = conexionBD;
            comandoBD.CommandType = CommandType.TableDirect;
            comandoBD.CommandText = "SOCIO";

            // Configura el adaptador y llena el DataSet con los datos de la tabla "SOCIO"
            objAdaptador = new OleDbDataAdapter(comandoBD);
            objAdaptador.Fill(objDataSet, "SOCIO");

            // Obtiene la tabla "SOCIO" del DataSet
            DataTable dt = objDataSet.Tables["SOCIO"];

            foreach (DataRow registro in dt.Rows)
            {
                if ((int)registro["CODIGO_SOCIO"] == id)
                {
                    registro.BeginEdit();

                    // Cambia el estado del socio
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

            // Constructor de comandos para el adaptador
            OleDbCommandBuilder constructor = new OleDbCommandBuilder(objAdaptador);

            // Actualización de la base de datos con el cambio de estado
            objAdaptador.Update(objDataSet, "SOCIOS");

            // Muestra un MessageBox indicando que el cambio de estado fue exitoso
            MessageBox.Show("Cambio de estado exitoso");
        }
    }
}
