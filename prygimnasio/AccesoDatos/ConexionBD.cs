using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class ConexionBD
    {
        //conexion a la BD
        //private SqlConnection connection = new SqlConnection("Server=DESKTOP-3J95KAB; DataBase=PRYGIMNASIO; Integrated Security=true");
        private SqlConnection connection = new SqlConnection("Data Source = DESKTOP-3J95KAB;Initial Catalog = PRYGIMNASIO; Integrated Security=true");
        //metodo para la conexion
        public SqlConnection openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }
        //metodo para cerrar la conexion
        public SqlConnection closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}
