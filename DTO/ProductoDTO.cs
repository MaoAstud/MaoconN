using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ProductoDTO
    {
        public int IdProducto { get; set; }
        public string NombreZapato { get; set; }
        public string DescripcionZapato { get; set; }
        public decimal? PrecioZapato { get; set; }
        public int? IdCategoria { get; set; }
        public string TallaZapato { get; set; }
        public string ColorZapato { get; set; }
        public string MaterialZapato { get; set; }
        public string UrlImagen { get; set; }
        public int? StockZapato { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string MarcaZapato { get; set; }
    }
}
