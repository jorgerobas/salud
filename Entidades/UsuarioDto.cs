using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class UsuarioDTO
    {
       public int Id { get; set; }
       public string nombre { get; set; }
       public string password { get; set; }
       public string tipo_usuario { get; set; }
    }
}
