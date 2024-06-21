using Datos;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class DetalleCarritoNegocio
    {
        private DetalleCarritoDatos _detalleDatos;

        public DetalleCarritoNegocio()
        {
            _detalleDatos = new DetalleCarritoDatos();
        }

        public List<DetalleCarritoDTO> ObtenerListaDetalles()
        {
            return _detalleDatos.ObtenerLista();
        }

        public DetalleCarritoDTO BuscarDetallePorID(int id)
        {
            return _detalleDatos.BuscarPorID(id);
        }

        public bool AgregarNuevoDetalle(DetalleCarritoDTO detalle)
        {
            return _detalleDatos.Agregar(detalle);
        }

        public bool ActualizarDetalle(DetalleCarritoDTO detalle)
        {
            return _detalleDatos.Actualizar(detalle);
        }

        public bool EliminarDetalle(int id)
        {
            return _detalleDatos.Eliminar(id);
        }
    }
}
