using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CarritoComprasDTO
    {
        public int IdCarrito { get; set; }
        public int? IdUsuario { get; set; }
        public DateTime? FechaCreacion { get; set; }
        public string EstadoCarrito { get; set; }
    }
}
