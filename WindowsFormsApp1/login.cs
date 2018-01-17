using Entidades;
using Logica; //Agregué la referencia a la capa lógica para tener acceso al gestor de usuarios
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class login : Form
    {
<<<<<<< HEAD
        //VARIABLES
        string nombre, clave;
        //
=======

      

>>>>>>> origin/master
        public login()
        {
            InitializeComponent();
            this.ActiveControl = label1;
        }
<<<<<<< HEAD
        
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
=======

       
    

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
 
           /* if (MessageBox.Show("Esta acción cerrará el programa. ¿Confirma que desea salir?","Salir",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                this.Close();
                Application.Exit();
            }*/
               
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
>>>>>>> origin/master
            }
            
        }

<<<<<<< HEAD
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
=======
     

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
>>>>>>> origin/master
        }

        private void btnMostrarContraseña_MouseDown(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = false;
        }

        private void btnMostrarContraseña_MouseUp(object sender, MouseEventArgs e)
        {
            txtPassword.UseSystemPasswordChar = true;
        }
<<<<<<< HEAD
        
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (nombre != "" && clave != "") iniciarSesion(nombre, clave); else txtUsuario.Focus();
        }
       
        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
=======

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
                {
                    MessageBox.Show("ingreso correcto");
                    this.Hide();
                }    
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
>>>>>>> origin/master
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==Convert.ToChar(Keys.Enter))
            {
                ValidarUsuarioyClave();
            }

  
        }



        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Esta acción cerrará el programa. ¿Confirma que desea salir?", "Salir", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                e.Cancel=false;
            }
            else
            {
                e.Cancel = true;
            }
        }

<<<<<<< HEAD
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

=======
        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
>>>>>>> origin/master
    }
}
