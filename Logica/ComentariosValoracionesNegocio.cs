using Datos;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ComentariosValoracionesNegocio
    {
        private ComentariosValoracionesDatos _comentariosDatos;

        public ComentariosValoracionesNegocio()
        {
            _comentariosDatos = new ComentariosValoracionesDatos();
        }

        public List<ComentarioValoracionDTO> ObtenerListaComentarios()
        {
            return _comentariosDatos.ObtenerLista();
        }

        public ComentarioValoracionDTO BuscarComentarioPorID(int id)
        {
            return _comentariosDatos.BuscarPorID(id);
        }

        public bool AgregarNuevoComentario(ComentarioValoracionDTO comentario)
        {
            return _comentariosDatos.Agregar(comentario);
        }

        public bool ActualizarComentario(ComentarioValoracionDTO comentario)
        {
            return _comentariosDatos.Actualizar(comentario);
        }

        public bool EliminarComentario(int id)
        {
            return _comentariosDatos.Eliminar(id);
        }
    }
}
