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
    public class CategoriasNegocio
    {
        private CategoriasDatos _categoriasDatos;

        public CategoriasNegocio()
        {
            _categoriasDatos = new CategoriasDatos();
        }

        public List<CategoriaDTO> ObtenerListaCategorias()
        {
            return _categoriasDatos.ObtenerLista();
        }

        public CategoriaDTO BuscarCategoriaPorID(int id)
        {
            return _categoriasDatos.BuscarPorID(id);
        }

        public bool AgregarNuevaCategoria(CategoriaDTO categoria)
        {
            return _categoriasDatos.Agregar(categoria);
        }

        public bool ActualizarCategoria(CategoriaDTO categoria)
        {
            return _categoriasDatos.Actualizar(categoria);
        }

        public bool EliminarCategoria(int id)
        {
            return _categoriasDatos.Eliminar(id);
        }
    }
}