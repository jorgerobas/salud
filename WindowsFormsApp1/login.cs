using Entidades;
using Logica; //Agregué la referencia a la capa lógica para tener acceso al gestor de usuarios
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {

      

        public login()
        {
            InitializeComponent();
        }

       
    

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta acción cerrará el programa. ¿Confirma que desea salir?","Salir",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }
               
        } //Botón salir de la aplicación

        private void login_Load(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
            btnMostrarContraseña.Visible = false;
            LimpiarCampos();
            //txtUsuario.Text = "ingrese su usuario";
            //txtUsuario.ForeColor = Color.Gray;

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            BorrarMensajesError();
            ValidarCamposCompletos();

            if (ValidarCamposCompletos())
            {
                ValidarUsuarioyClave();
            }
            else
            {
                MessageBox.Show("Debe completar los campos resaltados");           
            }
            
        }

     

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text=="")
            {
                btnMostrarContraseña.Visible = false;
                errorProvider1.SetError(txtPassword, "Debe ingresar una clave de acceso.");
            }
            else
            {
                btnMostrarContraseña.Visible = true;
                errorProvider1.SetError(txtPassword, "");
            }
        }


        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
                errorProvider1.SetError(txtUsuario, "debe escribir un nombre de usuario");
            else
                errorProvider1.SetError(txtUsuario, "");
        }

        private void btnMostrarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnMostrarContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }

        private bool ValidarCamposCompletos()
        {
            bool completo = true;

            if (txtUsuario.Text == "")
            {
                completo = false;
                errorProvider1.SetError(txtUsuario, "debe ingresar un nombre de usuario");
            }

            if (txtPassword.Text == "")
            {
                completo = false;
                errorProvider1.SetError(txtPassword, "debe ingresar un nombre de usuario");
            }

            return completo;     

        }

        private void BorrarMensajesError()
        {
            errorProvider1.SetError(txtPassword, "");
            errorProvider1.SetError(txtUsuario, "");
        }

        private void LimpiarCampos()
        {
            txtPassword.Text = "";
            txtUsuario.Text = "";
            txtUsuario.Focus();
            errorProvider1.SetError(txtUsuario, "");
            errorProvider1.SetError(txtPassword, "");
        }

        private void ValidarUsuarioyClave()
        {
            gestorUsuarios _gestorUsuarios = new gestorUsuarios();
            string nombre = txtUsuario.Text; //La variable nombre guarda el nombre con el que el usuario intenta iniciar sesión
            UsuarioDTO _usuario = new UsuarioDTO();

            _usuario = _gestorUsuarios.ObtenerCuentaPorUsername(nombre);

            if (_usuario != null) //chequea si el nombre que el usuario ingresó existe en la BD
            {
                if (_usuario.password == txtPassword.Text)
                    MessageBox.Show("ingreso correcto");
                else
                {
                    MessageBox.Show("El usuario o contraseña ingresados son incorrectos.");
                    LimpiarCampos();
                }

            }
            else
            {
                //Mensaje de error en el inicio de sesión
                MessageBox.Show("El usuario ingresado o contraseña ingresado son incorrectos.", "Error en el inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LimpiarCampos();
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                ValidarUsuarioyClave();
            }
        }
    }
}
