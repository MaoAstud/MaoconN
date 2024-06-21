using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Logica;
using DTO;
namespace MaoconN
{
    /// <summary>
    /// Descripción breve de TiendaServicio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    [System.Web.Script.Services.ScriptService]
    public class TiendaServicio : System.Web.Services.WebService
    {

        [WebMethod]
        public List<UsuarioDTO> ObtenerListaUsuarios()
        {
            UsuariosNegocio negocio = new UsuariosNegocio();
            return negocio.ObtenerListaUsuarios();
        }

        [WebMethod]
        public UsuarioDTO BuscarUsuarioPorID(int id)
        {
            UsuariosNegocio negocio = new UsuariosNegocio();
            return negocio.BuscarUsuarioPorID(id);
        }

        [WebMethod]
        public bool AgregarNuevoUsuario(UsuarioDTO usuario)
        {
            UsuariosNegocio negocio = new UsuariosNegocio();
            return negocio.AgregarNuevoUsuario(usuario);
        }

        [WebMethod]
        public bool ActualizarUsuario(UsuarioDTO usuario)
        {
            UsuariosNegocio negocio = new UsuariosNegocio();
            return negocio.ActualizarUsuario(usuario);
        }

        [WebMethod]
        public bool EliminarUsuario(int id)
        {
            UsuariosNegocio negocio = new UsuariosNegocio();
            return negocio.EliminarUsuario(id);
        }

        // Métodos relacionados con Productos

        [WebMethod]
        public List<ProductoDTO> ObtenerListaProductos()
        {
            ProductoNegocio negocio = new ProductoNegocio();
            return negocio.ObtenerListaProductos();
        }

        [WebMethod]
        public ProductoDTO BuscarProductoPorID(int id)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            return negocio.BuscarProductoPorID(id);
        }

        [WebMethod]
        public bool AgregarNuevoProducto(ProductoDTO producto)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            return negocio.AgregarNuevoProducto(producto);
        }

        [WebMethod]
        public bool ActualizarProducto(ProductoDTO producto)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            return negocio.ActualizarProducto(producto);
        }

        [WebMethod]
        public bool EliminarProducto(int id)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            return negocio.EliminarProducto(id);
        }

        // Métodos relacionados con Categorías

        [WebMethod]
        public List<CategoriaDTO> ObtenerListaCategorias()
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            return negocio.ObtenerListaCategorias();
        }
        [WebMethod]
        public CategoriaDTO BuscarCategoriaPorID(int id)
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            return negocio.BuscarCategoriaPorID(id);
        }

        [WebMethod]
        public bool AgregarNuevoCategoria(CategoriaDTO categoria)
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            return negocio.AgregarNuevaCategoria(categoria);
        }

        [WebMethod]
        public bool ActualizarCategoria(CategoriaDTO categoria)
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            return negocio.ActualizarCategoria(categoria);
        }

        [WebMethod]
        public bool EliminarCategoria(int id)
        {
            CategoriasNegocio negocio = new CategoriasNegocio();
            return negocio.EliminarCategoria(id);
        }
        [WebMethod]
        public List<DetalleCarritoDTO> ObtenerListaDetallesCarrito()
        {
            DetalleCarritoNegocio negocio = new DetalleCarritoNegocio();
            return negocio.ObtenerListaDetalles();
        }

        [WebMethod]
        public DetalleCarritoDTO BuscarDetallePorID(int id)
        {
            DetalleCarritoNegocio negocio = new DetalleCarritoNegocio();
            return negocio.BuscarDetallePorID(id);
        }

        [WebMethod]
        public bool AgregarNuevoDetalle(DetalleCarritoDTO categoria)
        {
            DetalleCarritoNegocio negocio = new DetalleCarritoNegocio();
            return negocio.AgregarNuevoDetalle(categoria);
        }

        [WebMethod]
        public bool ActualizarCategoriaDetalle(DetalleCarritoDTO categoria)
        {
            DetalleCarritoNegocio negocio = new DetalleCarritoNegocio();
            return negocio.ActualizarDetalle(categoria);
        }

        [WebMethod]
        public bool EliminarDetalle(int id)
        {
            DetalleCarritoNegocio negocio = new DetalleCarritoNegocio();
            return negocio.EliminarDetalle(id);
        }
        public List<ComentarioValoracionDTO> ObtenerListaComentarioValoracion()
        {
            ComentariosValoracionesNegocio negocio = new ComentariosValoracionesNegocio();
            return negocio.ObtenerListaComentarios();
        }

        [WebMethod]
        public ComentarioValoracionDTO BuscarComentarioPorID(int id)
        {
            ComentariosValoracionesNegocio negocio = new ComentariosValoracionesNegocio();
            return negocio.BuscarComentarioPorID(id);
        }

        [WebMethod]
        public bool AgregarNuevoComentario(ComentarioValoracionDTO categoria)
        {
            ComentariosValoracionesNegocio negocio = new ComentariosValoracionesNegocio();
            return negocio.AgregarNuevoComentario(categoria);
        }

        [WebMethod]
        public bool ActualizarComentario(ComentarioValoracionDTO categoria)
        {
            ComentariosValoracionesNegocio negocio = new ComentariosValoracionesNegocio();
            return negocio.ActualizarComentario(categoria);
        }

        [WebMethod]
        public bool EliminarComentario(int id)
        {
            ComentariosValoracionesNegocio negocio = new ComentariosValoracionesNegocio();
            return negocio.EliminarComentario(id);
        }
    }

}
