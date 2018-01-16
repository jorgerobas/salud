using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica; //Agregué la referencia a la capa lógica para tener acceso al gestor de usuarios
using Entidades;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
        //VARIABLES
        string nombre, clave;
        //
        public login()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }
        
        // USUARIO ---------------------------------------------------------
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtUsuario.ForeColor = Color.Black;
        }
        
        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void txtUsuario_LostFocus(object sender, EventArgs e) //Cuando se saca foco, guarda el usuario
        {
            nombre = txtUsuario.Text;
        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e) //con enter hace foco en el campo password
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        // PASSWORD ---------------------------------------------------------
        private void txtPassword_Enter(object sender, EventArgs e) //GET FOCUS
        {
            txtPassword.Text = "";
            txtPassword.ForeColor = Color.Black;
        }

        private void txtPassword_LostFocus(object sender, EventArgs e)
        {
           // clave = txtPassword.Text;
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                clave = txtPassword.Text;
                iniciarSesion(nombre, clave);
            }
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (nombre != "" && clave != "") iniciarSesion(nombre, clave); else txtUsuario.Focus();
        }
       
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //MOSTRAR / OCULTAR CONTRASEÑA
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Ocultar contraseña";
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                checkBox1.Text = "Mostrar contraseña";
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void iniciarSesion(string nombre, string clave)
        {
            gestorUsuarios _gestorUsuarios = new gestorUsuarios();
            //string nombre = txtUsuario.Text; //La variable nombre guarda el nombre con el que el usuario intenta iniciar sesión
            UsuarioDTO _usuario = new UsuarioDTO();

            //_usuario = _gestorUsuarios.ObtenerCuentaPorUsername(nombre);
            _usuario = _gestorUsuarios.IniciarSesion(nombre, clave);

            if (_usuario != null)
            {
                MessageBox.Show("Bienvenido al sistema " + _usuario.nombre, "Ha iniciado sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se pudo iniciar sesión, controle los datos ingresados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            /*if (_usuario != null) //chequea si el nombre que el usuario ingresó existe en la BD
            {
                MessageBox.Show("se encontró el usuario: " + _usuario.nombre + " " + _usuario.password + " " + _usuario.tipo_usuario);
            }
            else
            {
                //Mensaje de error en el inicio de sesión
                MessageBox.Show("El usuario ingresado no existe", "Error en el inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtUsuario.Focus();
            }*/
        }

    }
}
