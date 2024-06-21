using AccesoDatos;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class DetalleCarritoDatos
    {
        private maoconnEntities contexto;

        public DetalleCarritoDatos()
        {
            contexto = new maoconnEntities();
        }

        public List<DetalleCarritoDTO> ObtenerLista()
        {
            return contexto.DetalleCarrito.Select(d => new DetalleCarritoDTO
            {
                IdDetalleCarrito = d.id_detalle_carrito,
                IdCarrito = d.id_carrito,
                IdProducto = d.id_prod,
                CantidadProducto = d.cantidad_prod,
                FechaAgregado = d.fecha_agregado
            }).ToList();
        }

        public DetalleCarritoDTO BuscarPorID(int id)
        {
            var detalle = contexto.DetalleCarrito.Find(id);
            if (detalle != null)
            {
                return new DetalleCarritoDTO
                {
                    IdDetalleCarrito = detalle.id_detalle_carrito,
                    IdCarrito = detalle.id_carrito,
                    IdProducto = detalle.id_prod,
                    CantidadProducto = detalle.cantidad_prod,
                    FechaAgregado = detalle.fecha_agregado
                };
            }
            return null;
        }

        public bool Agregar(DetalleCarritoDTO detalleDTO)
        {
            var detalle = new DetalleCarrito
            {
                id_carrito = detalleDTO.IdCarrito,
                id_prod = detalleDTO.IdProducto,
                cantidad_prod = detalleDTO.CantidadProducto,
                fecha_agregado = detalleDTO.FechaAgregado
            };
            contexto.DetalleCarrito.Add(detalle);
            contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(DetalleCarritoDTO detalleDTO)
        {
            var detalle = contexto.DetalleCarrito.Find(detalleDTO.IdDetalleCarrito);
            if (detalle != null)
            {
                detalle.id_carrito = detalleDTO.IdCarrito;
                detalle.id_prod = detalleDTO.IdProducto;
                detalle.cantidad_prod = detalleDTO.CantidadProducto;
                detalle.fecha_agregado = detalleDTO.FechaAgregado;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(int id)
        {
            var detalle = contexto.DetalleCarrito.Find(id);
            if (detalle != null)
            {
                contexto.DetalleCarrito.Remove(detalle);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }

}
