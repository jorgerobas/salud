using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Logica;   

namespace WindowsFormsApp1
{
    public partial class consultaUsuarios : Form
    {
        gestorUsuarios obj_gestorUsuarios = new gestorUsuarios(); 

        public consultaUsuarios()
        {
            InitializeComponent();
        }

        private void consultaUsuarios_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj_gestorUsuarios.ListarUsuarios();
        }
    }
}
