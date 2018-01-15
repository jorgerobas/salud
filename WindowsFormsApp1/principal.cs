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
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaUsuarios consultaUsuarios = new consultaUsuarios();
            consultaUsuarios.Show();    
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login _login = new login();
            _login.Show();
        }
    }
}
