using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public class TextBoxAutoexplicativo : TextBox
    {
        //Nuevas propiedades
        private string textoVacio;
        [Category("Texto Vacio")]//le agregamos una categoria
        public string TextoVacio //contendrá el texto que se mostrará cuándo el textbox esté vacío
        {
            get { return textoVacio; }
            set { textoVacio = value; }
        }
        private Color colorTextoVacio;
        public Color ColorTextoVacio
        {
            get { return colorTextoVacio; }
            set { colorTextoVacio = value; }
        }
        //Variables privadas
        bool bndTextoVacio = false;//Bandera que nos indica si esta activo el TextoVacio
        //Constructor
        public TextBoxAutoexplicativo()
        {//Iniciamos los valores por defecto
            colorTextoVacio = Color.Gray;
            textoVacio = "<Descripcion>";
        }
        //Creamos un metodo que nos ayudara a verificar si se inserta el texto vacio o no
        private void VerificarTextoVacio()
        {
            if (this.Text.Length > 0)
                bndTextoVacio = false; //como el textbox tiene contenido desactivamos el textoVacio
            else
                bndTextoVacio = true; //en caso contrario activamos la bandera

            this.SetStyle(ControlStyles.UserPaint, bndTextoVacio); //Esto nos permitira acceder al evento Paint del 
            this.Refresh();//Refrescamos el textbox
        }
        //Sobreescribimos los metodos del textbox
        protected override void OnCreateControl()//Cuando se crea el control en el form
        {
            base.OnCreateControl();
            VerificarTextoVacio();//Verificamos si se debe activar el texto vacio
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //Aqui mostramos en el textbox el contenido del TextoVacio, o el contenido del TextBox segun sea el caso    
            if (bndTextoVacio) //si esta activo el texto vacio
                e.Graphics.DrawString(textoVacio, new Font(this.Font, FontStyle.Italic), new SolidBrush(colorTextoVacio), new Point(0, 0));
            else
                e.Graphics.DrawString(this.Text, this.Font, new SolidBrush(this.ForeColor), new Point(0, 0));
            base.OnPaint(e);
        }
    }
}
