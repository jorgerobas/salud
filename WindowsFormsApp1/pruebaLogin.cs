using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;
using Entidades;

namespace WindowsFormsApp1
{
    public partial class pruebaLogin : Form
    {
        public pruebaLogin()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            gestorUsuarios gestor = new gestorUsuarios();

            UsuarioDTO _usuario = gestor.ObtenerCuentaPorUsername(txtUserName.Text);

               
            if (_usuario==null)
            {
                MessageBox.Show("El usuario o contraseña están incorrectos");
            }
            else
            {
                MessageBox.Show("El usuario es tipo " + _usuario.tipo_usuario);
            }

        }
    }
}
