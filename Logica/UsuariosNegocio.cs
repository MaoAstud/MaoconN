using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccesoDatos;
using Datos;
using DTO;

namespace Logica
{
    public class UsuariosNegocio
    {
        private UsuariosDatos _usuarioDatos;

        public UsuariosNegocio()
        {
            _usuarioDatos = new UsuariosDatos();
        }

        public List<UsuarioDTO> ObtenerListaUsuarios()
        {
            return _usuarioDatos.ObtenerLista();
        }

        public UsuarioDTO BuscarUsuarioPorID(int id)
        {
            return _usuarioDatos.BuscarPorID(id);
        }

        public bool AgregarNuevoUsuario(UsuarioDTO usuario)
        {
            return _usuarioDatos.Agregar(usuario);
        }

        public bool ActualizarUsuario(UsuarioDTO usuario)
        {
            return _usuarioDatos.Actualizar(usuario);
        }

        public bool EliminarUsuario(int id)
        {
            return _usuarioDatos.Eliminar(id);
        }
    }
}
