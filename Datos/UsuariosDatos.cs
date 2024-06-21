using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using DTO;

namespace Datos
{
    public class UsuariosDatos : IDatos<Usuarios>
    {
        private maoconnEntities contexto;

        public UsuariosDatos()
        {
            contexto = new maoconnEntities();
        }

        public List<UsuarioDTO> ObtenerLista()
        {
            return contexto.Usuarios.Select(u => new UsuarioDTO
            {
                IdUsuario = u.id_usuario,
                Nombre = u.nombre,
                Correo = u.correo,
                Telefono = u.telefono,
                Domicilio = u.domicilio,
                FechaReg = u.fecha_reg
            }).ToList();
        }

        public UsuarioDTO BuscarPorID(int id_usuario)
        {
            var usuario = contexto.Usuarios.Find(id_usuario);
            if (usuario != null)
            {
                return new UsuarioDTO
                {
                    IdUsuario = usuario.id_usuario,
                    Nombre = usuario.nombre,
                    Correo = usuario.correo,
                    Telefono = usuario.telefono,
                    Domicilio = usuario.domicilio,
                    FechaReg = usuario.fecha_reg
                };
            }
            return null;
        }

        public bool Agregar(UsuarioDTO usuarioDTO)
        {
            var usuario = new Usuarios
            {
                nombre = usuarioDTO.Nombre,
                correo = usuarioDTO.Correo,
                telefono = usuarioDTO.Telefono,
                domicilio = usuarioDTO.Domicilio,
                fecha_reg = usuarioDTO.FechaReg
            };
            contexto.Usuarios.Add(usuario);
            contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(UsuarioDTO usuarioDTO)
        {
            var usuario = contexto.Usuarios.Find(usuarioDTO.IdUsuario);
            if (usuario != null)
            {
                usuario.nombre = usuarioDTO.Nombre;
                usuario.correo = usuarioDTO.Correo;
                usuario.telefono = usuarioDTO.Telefono;
                usuario.domicilio = usuarioDTO.Domicilio;
                usuario.fecha_reg = usuarioDTO.FechaReg;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(int id_usuario)
        {
            var usuario = contexto.Usuarios.Find(id_usuario);
            if (usuario != null)
            {
                contexto.Usuarios.Remove(usuario);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public List<Usuarios> Listar()
        {
            throw new NotImplementedException();
        }

        public bool Actualizar(Usuarios item)
        {
            throw new NotImplementedException();
        }

        public bool Nuevo(Usuarios item)
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(Usuarios item)
        {
            throw new NotImplementedException();
        }
    }
}
