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
        public List<UsuarioDTO> ListarUsuarios() //DEVUELVE UN LIST DE USUARIOS
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    var Query = (from n in dbContext.usuario
                                 select new UsuarioDTO
                                 {
                                     Id = n.Id,
                                     nombre = n.nombre,
                                     password = n.password,
                                     tipo_usuario = n.tipo_usuario

                                 }).ToList();
                    return Query;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public UsuarioDTO ObtenerCuentaPorUsername(string username) //BUSCA UN USUARIO POR "USERNAME": SI LO ENCUENTRA DEVUELVE EL OBJETO. sINO DEVUELVE NULL
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    return (from n in dbContext.usuario
                                   where n.nombre == username
                                   select new UsuarioDTO
                                   {
                                       Id = n.Id,
                                       nombre = n.nombre,
                                       password = n.password,
                                       tipo_usuario = n.tipo_usuario
                                   }).SingleOrDefault();
                
                    
                }
            }
            catch (Exception)
            {
                throw;
            }   
        }

        public UsuarioDTO IniciarSesion(string username, string clave) //FUNCION INICIAR SESION
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    return (from n in dbContext.usuario
                            where n.nombre == username && n.password == clave
                            select new UsuarioDTO
                            {
                                Id = n.Id,
                                nombre = n.nombre,
                                password = n.password,
                                tipo_usuario = n.tipo_usuario
                            }).SingleOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AgregarUsuario (string nombre, string clave, string tipo)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    usuario entidad = new usuario();
                    entidad.nombre = nombre;
                    entidad.password = clave;
                    entidad.tipo_usuario = tipo;
                    dbContext.usuario.Add(entidad);
                    dbContext.SaveChanges();
                }
                    

            }
            catch (Exception)
            {
                throw;
            }
        }

        
        public void ModificarUsuario (UsuarioDTO _Usuario)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    usuario Entidad = (from n in dbContext.usuario
                                       where n.Id == _Usuario.Id
                                       select n).FirstOrDefault();
                    Entidad.nombre = _Usuario.nombre;
                    Entidad.password = _Usuario.password;
                    Entidad.tipo_usuario = _Usuario.tipo_usuario;
                    dbContext.Entry(Entidad).CurrentValues.SetValues(Entidad);
                    dbContext.SaveChanges();
                }
                    
            }
            catch (Exception)
            {

            }
        }
        
        
        public void EliminarUsuario (UsuarioDTO _Usuario)
        {
            try
            {
                using (consultoriosEntities dbContext = new consultoriosEntities())
                {
                    usuario Entidad = (from n in dbContext.usuario
                                       where n.Id == _Usuario.Id
                                       select n).FirstOrDefault();
                    dbContext.usuario.Remove(Entidad);
                    dbContext.SaveChanges();
                }
                
            }
            catch (Exception)
            {
                throw;
            }
        }

       
    }

   
}
