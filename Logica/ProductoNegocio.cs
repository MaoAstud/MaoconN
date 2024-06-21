using AccesoDatos;
using Datos;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ProductoNegocio
    {
        private ProductoDatos _productoDatos;

        public ProductoNegocio()
        {
            _productoDatos = new ProductoDatos();
        }

        public List<ProductoDTO> ObtenerListaProductos()
        {
            return _productoDatos.ObtenerLista();
        }

        public ProductoDTO BuscarProductoPorID(int id)
        {
            return _productoDatos.BuscarPorID(id);
        }

        public bool AgregarNuevoProducto(ProductoDTO producto)
        {
            return _productoDatos.Agregar(producto);
        }

        public bool ActualizarProducto(ProductoDTO producto)
        {
            return _productoDatos.Actualizar(producto);
        }

        public bool EliminarProducto(int id)
        {
            return _productoDatos.Eliminar(id);
        }
    }
}