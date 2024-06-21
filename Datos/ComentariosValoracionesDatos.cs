using AccesoDatos;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ComentariosValoracionesDatos
    {
        private maoconnEntities contexto;

        public ComentariosValoracionesDatos()
        {
            contexto = new maoconnEntities();
        }

        public List<ComentarioValoracionDTO> ObtenerLista()
        {
            return contexto.ComentariosValoraciones.Select(c => new ComentarioValoracionDTO
            {
                IdComentario = c.id_coment,
                IdUsuario = c.id_user,
                IdProducto = c.id_prod,
                Comentario = c.comentario,
                Valor = c.valor,
                Fecha = c.fecha
            }).ToList();
        }

        public ComentarioValoracionDTO BuscarPorID(int id)
        {
            var comentarioValoracion = contexto.ComentariosValoraciones.Find(id);
            if (comentarioValoracion != null)
            {
                return new ComentarioValoracionDTO
                {
                    IdComentario = comentarioValoracion.id_coment,
                    IdUsuario = comentarioValoracion.id_user,
                    IdProducto = comentarioValoracion.id_prod,
                    Comentario = comentarioValoracion.comentario,
                    Valor = comentarioValoracion.valor,
                    Fecha = comentarioValoracion.fecha
                };
            }
            return null;
        }

        public bool Agregar(ComentarioValoracionDTO comentarioDTO)
        {
            var comentario = new ComentariosValoraciones
            {
                id_user = comentarioDTO.IdUsuario,
                id_prod = comentarioDTO.IdProducto,
                comentario = comentarioDTO.Comentario,
                valor = comentarioDTO.Valor,
                fecha = comentarioDTO.Fecha
            };
            contexto.ComentariosValoraciones.Add(comentario);
            contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(ComentarioValoracionDTO comentarioDTO)
        {
            var comentario = contexto.ComentariosValoraciones.Find(comentarioDTO.IdComentario);
            if (comentario != null)
            {
                comentario.id_user = comentarioDTO.IdUsuario;
                comentario.id_prod = comentarioDTO.IdProducto;
                comentario.comentario = comentarioDTO.Comentario;
                comentario.valor = comentarioDTO.Valor;
                comentario.fecha = comentarioDTO.Fecha;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(int id)
        {
            var comentario = contexto.ComentariosValoraciones.Find(id);
            if (comentario != null)
            {
                contexto.ComentariosValoraciones.Remove(comentario);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
