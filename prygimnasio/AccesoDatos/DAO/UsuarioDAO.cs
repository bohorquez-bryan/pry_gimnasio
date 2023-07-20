using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.DAO
{
    public class UsuarioDAO
    {
        //funciones con el usuario sp, views, etc
        //conexion con la BD
        private ConexionBD conexion = new ConexionBD();
        SqlCommand ejecutarSql = new SqlCommand();
        SqlParameter param = new SqlParameter();
        //metodos CRUD
        public void InsertarUsuario (Usuario nuevoUsuario)
        {
            ejecutarSql.Connection = conexion.openConnection();
            try
            {

                ejecutarSql.CommandText = "insert into USUARIO(NOMBRE,APELLIDO,DIRECCION,FECHA_NAC,CEDULA,PESO_INICIAL,ESTADO) values(@NOMBRE,@APELLIDO,@DIRECCION,@FECHA_NAC,@CEDULA,@PESO_INICIAL,@ESTADO)";
                ejecutarSql.Parameters.AddWithValue("@NOMBRE", nuevoUsuario.Nombre);
                ejecutarSql.Parameters.AddWithValue("@APELLIDO", nuevoUsuario.Apellido);
                ejecutarSql.Parameters.AddWithValue("@DIRECCION", nuevoUsuario.Direccion);
                ejecutarSql.Parameters.AddWithValue("@FECHA_NAC", nuevoUsuario.Fecha_nac);
                ejecutarSql.Parameters.AddWithValue("@CEDULA", nuevoUsuario.Cedula);
                ejecutarSql.Parameters.AddWithValue("@PESO_INICIAL", nuevoUsuario.Peso_inicial);
                ejecutarSql.Parameters.AddWithValue("@ESTADO", nuevoUsuario.Estado);
                ejecutarSql.ExecuteNonQuery();
                conexion.closeConnection();
                Console.WriteLine("USUARIO INSERTADO");
                
            }
            catch (Exception ex) {
                Console.WriteLine("ERROR AL INSERTAR");
                throw new Exception("Error al insertar usuario"+ ex.Message);
                
            }
            
        }
        public void listarUsuario()
        {
            ejecutarSql.Connection = conexion.openConnection();
            try
            {
                ejecutarSql.CommandText = "select NOMBRE,APELLIDO,DIRECCION,FECHA_NAC,CEDULA,PESO_INCIAL from USUARIO order by ID_USR desc";
                ejecutarSql.ExecuteNonQuery();
               
                DataTable dt = new DataTable();
                
                conexion.closeConnection();
                Console.WriteLine("LISTADO");
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR AL LISTAR");
                throw new Exception("Error al listar usuario" + ex.Message);
            }

        }

    }
}
