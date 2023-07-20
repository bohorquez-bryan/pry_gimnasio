using AccesoDatos.DAO;
using AccesoDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicaNegocio
{
    public class UsuarioLogica
    {
        private UsuarioDAO usuarioDao = new UsuarioDAO();

        public void InsertarUsuario(Usuario usuario)
        {
            usuarioDao.InsertarUsuario(usuario);
        }   
    }
}
