using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
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
        DataSet objDataSet;

        string rutaBD;
        public string estadoConexion;
        string cadenaConexion = @"Provider = Microsoft.ACE.OLEDB.12.0;" + " Data Source = ..\\..\\Resources\\EL_CLUB.accdb";

        public void ConectarBD()
        {
            try
            {
                conexionBD = new OleDbConnection();
                conexionBD.ConnectionString = cadenaConexion;
                conexionBD.Open();
                estadoConexion = "Conectado";
            }
            catch (Exception EX)
            {
                estadoConexion = "Error: " + EX.Message;
            }

        }
    }
}
