using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ComentarioValoracionDTO
    {
        public int IdComentario { get; set; }
        public int? IdUsuario { get; set; }
        public int? IdProducto { get; set; }
        public string Comentario { get; set; }
        public int? Valor { get; set; }
        public DateTime? Fecha { get; set; }
    }

}
