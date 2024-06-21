using Datos;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class CarritoComprasNegocio
    {
        private CarritoComprasDatos _carritoDatos;

        public CarritoComprasNegocio()
        {
            _carritoDatos = new CarritoComprasDatos();
        }

        public List<CarritoComprasDTO> ObtenerListaCarritos()
        {
            return _carritoDatos.ObtenerLista();
        }

        public CarritoComprasDTO BuscarCarritoPorID(int id)
        {
            return _carritoDatos.BuscarPorID(id);
        }

        public bool AgregarNuevoCarrito(CarritoComprasDTO carrito)
        {
            return _carritoDatos.Agregar(carrito);
        }

        public bool ActualizarCarrito(CarritoComprasDTO carrito)
        {
            return _carritoDatos.Actualizar(carrito);
        }

        public bool EliminarCarrito(int id)
        {
            return _carritoDatos.Eliminar(id);
        }
    }
}
