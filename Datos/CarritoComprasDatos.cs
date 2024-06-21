using AccesoDatos;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CarritoComprasDatos
    {
        private maoconnEntities contexto;

        public CarritoComprasDatos()
        {
            contexto = new maoconnEntities();
        }

        public List<CarritoComprasDTO> ObtenerLista()
        {
            return contexto.CarritoCompras.Select(c => new CarritoComprasDTO
            {
                IdCarrito = c.id_carrito,
                IdUsuario = c.id_user,
                FechaCreacion = c.fecha_creacion,
                EstadoCarrito = c.carrito_estado
            }).ToList();
        }

        public CarritoComprasDTO BuscarPorID(int id)
        {
            var carrito = contexto.CarritoCompras.Find(id);
            if (carrito != null)
            {
                return new CarritoComprasDTO
                {
                    IdCarrito = carrito.id_carrito,
                    IdUsuario = carrito.id_user,
                    FechaCreacion = carrito.fecha_creacion,
                    EstadoCarrito = carrito.carrito_estado
                };
            }
            return null;
        }

        public bool Agregar(CarritoComprasDTO carritoDTO)
        {
            var carrito = new CarritoCompras
            {
                id_user = carritoDTO.IdUsuario,
                fecha_creacion = carritoDTO.FechaCreacion,
                carrito_estado = carritoDTO.EstadoCarrito
            };
            contexto.CarritoCompras.Add(carrito);
            contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(CarritoComprasDTO carritoDTO)
        {
            var carrito = contexto.CarritoCompras.Find(carritoDTO.IdCarrito);
            if (carrito != null)
            {
                carrito.id_user = carritoDTO.IdUsuario;
                carrito.fecha_creacion = carritoDTO.FechaCreacion;
                carrito.carrito_estado = carritoDTO.EstadoCarrito;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(int id)
        {
            var carrito = contexto.CarritoCompras.Find(id);
            if (carrito != null)
            {
                contexto.CarritoCompras.Remove(carrito);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
