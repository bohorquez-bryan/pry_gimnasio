using AccesoDatos.Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class Form1 : Form

    {
        private UsuarioLogica usuarioLogica;
        public Form1()
        {
            InitializeComponent();
        usuarioLogica = new UsuarioLogica(); 
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsuario = new Usuario();
            nuevoUsuario.Nombre = txtNombre.Text;
            nuevoUsuario.Apellido = txtApellido.Text;
            nuevoUsuario.Direccion = txtDireccion.Text;
            nuevoUsuario.Fecha_nac = dateNac.Value.ToString("yyyy-MM-dd");
            nuevoUsuario.Cedula = txtCedula.Text;
            nuevoUsuario.Peso_inicial = double.Parse(txtPeso.Text, CultureInfo.InvariantCulture.NumberFormat); ;

            if (txtEstado.Checked)
            {
                nuevoUsuario.Estado = 1;
            }
            else
            {
                nuevoUsuario.Estado = 0;
            }

            usuarioLogica.InsertarUsuario(nuevoUsuario);
            MessageBox.Show("Usuario Agregado Correctamente");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtPesoIni_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if (txtPeso.Text.Length > 0)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"^(?=.)([+-]?([0-9]*)(\.([0-9]+))?)$");
                System.Text.RegularExpressions.Match match = regex.Match(txtPeso.Text);
                if (match.Success)
                {
                    lblPeso.Text = "Peso Valido";
                }
                else
                {
                     lblPeso.Text ="Peso Invalido";
                }
            }
        }
    }
}
