using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DetalleCarritoDTO
    {
        public int IdDetalleCarrito { get; set; }
        public int? IdCarrito { get; set; }
        public int? IdProducto { get; set; }
        public int? CantidadProducto { get; set; }
        public DateTime? FechaAgregado { get; set; }
    }
}

