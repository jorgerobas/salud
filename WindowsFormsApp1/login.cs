using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void login_Load(object sender, EventArgs e)
        {

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
