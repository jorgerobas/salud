using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using Entidades;

namespace Logica
{
    public class gestorUsuarios
    {
        public List<Usuario> ListarUsuarios()
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    var Query = (from n in dbContext.usuarios
                                 select new Usuario
                                 {
                                     Id = n.Id,
                                     nombre=n.nombre,
                                     password=n.password,
                                     tipo_usuario=n.tipo_usuario
                                     
                                 }).ToList();
                    return Query;
                }
            }
            catch (Exception)
            {
                throw;  
            }
        }

        //public Usuario obtenerUsuario(string nombreUsuario)
        //{
            //return ;
        //}
    
    }

   
}
