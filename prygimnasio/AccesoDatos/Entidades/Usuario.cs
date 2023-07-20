using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos.Entidades
{
    public class Usuario
    {
        //public int Id_usr { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Fecha_nac { get; set; }
        public string Cedula { get; set; }
        public double Peso_inicial { get; set; }
        public int Estado { get; set; }
    }
}
