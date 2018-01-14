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

namespace WindowsFormsApp1
{
    public partial class login : Form
    {

        bool flag1, flag2 = true; //VARIABLES BOOL PARA MANIPULAR LOS TEXTBOX

        public login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;

            if (flag1)
            {
                flag1 = false;
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;

            if (flag2)
            {
                flag2 = false;
                textBox2.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } //Botón salir de la aplicación

        private void login_Load(object sender, EventArgs e)
        {

        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = textBox1.Text; //La variable nombre guarda el nombre con el que el usuario intenta iniciar sesión

            if (Logica.gestorUsuarios.obtenerUsuario(nombre) == null) //chequea si el nombre que el usuario ingresó existe en la BD
            {

            }
            else
            {
                //Mensaje de error en el inicio de sesión
                MessageBox.Show("El usuario ingresado no existe", "Error en el inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e) //MOSTRAR / OCULTAR CONTRASEÑA
        {
            if (checkBox1.Checked == true)
            {
                checkBox1.Text = "Ocultar contraseña";
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                checkBox1.Text = "Mostrar contraseña";
                textBox2.UseSystemPasswordChar = true;
            }
        }
    }
}
