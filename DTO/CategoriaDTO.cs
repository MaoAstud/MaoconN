using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CategoriaDTO
    {
        public int IdCategoria { get; set; }
        public string NombreCategoria { get; set; }
        public string DescripcionCategoria { get; set; }
        public int? IdPadre { get; set; }
    }
}
