using AccesoDatos;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class ProductoDatos
    {
        private maoconnEntities contexto;

        public ProductoDatos()
        {
            contexto = new maoconnEntities();
        }

        public List<ProductoDTO> ObtenerLista()
        {
            return contexto.Productos.Select(p => new ProductoDTO
            {
                IdProducto = p.id_producto,
                NombreZapato = p.nombre_zapato,
                DescripcionZapato = p.descripcion_zapato,
                PrecioZapato = p.precio_zapato,
                IdCategoria = p.id_cat,
                TallaZapato = p.talla_zap,
                ColorZapato = p.color_zap,
                MaterialZapato = p.material_zap,
                UrlImagen = p.url_img,
                StockZapato = p.stock_zap,
                FechaAlta = p.fecha_alta,
                MarcaZapato = p.marca_zap
            }).ToList();
        }

        public ProductoDTO BuscarPorID(int id)
        {
            var producto = contexto.Productos.Find(id);
            if (producto != null)
            {
                return new ProductoDTO
                {
                    IdProducto = producto.id_producto,
                    NombreZapato = producto.nombre_zapato,
                    DescripcionZapato = producto.descripcion_zapato,
                    PrecioZapato = producto.precio_zapato,
                    IdCategoria = producto.id_cat,
                    TallaZapato = producto.talla_zap,
                    ColorZapato = producto.color_zap,
                    MaterialZapato = producto.material_zap,
                    UrlImagen = producto.url_img,
                    StockZapato = producto.stock_zap,
                    FechaAlta = producto.fecha_alta,
                    MarcaZapato = producto.marca_zap
                };
            }
            return null;
        }

        public bool Agregar(ProductoDTO productoDTO)
        {
            var producto = new Productos
            {
                nombre_zapato = productoDTO.NombreZapato,
                descripcion_zapato = productoDTO.DescripcionZapato,
                precio_zapato = productoDTO.PrecioZapato,
                id_cat = productoDTO.IdCategoria,
                talla_zap = productoDTO.TallaZapato,
                color_zap = productoDTO.ColorZapato,
                material_zap = productoDTO.MaterialZapato,
                url_img = productoDTO.UrlImagen,
                stock_zap = productoDTO.StockZapato,
                fecha_alta = productoDTO.FechaAlta,
                marca_zap = productoDTO.MarcaZapato
            };
            contexto.Productos.Add(producto);
            contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(ProductoDTO productoDTO)
        {
            var producto = contexto.Productos.Find(productoDTO.IdProducto);
            if (producto != null)
            {
                producto.nombre_zapato = productoDTO.NombreZapato;
                producto.descripcion_zapato = productoDTO.DescripcionZapato;
                producto.precio_zapato = productoDTO.PrecioZapato;
                producto.id_cat = productoDTO.IdCategoria;
                producto.talla_zap = productoDTO.TallaZapato;
                producto.color_zap = productoDTO.ColorZapato;
                producto.material_zap = productoDTO.MaterialZapato;
                producto.url_img = productoDTO.UrlImagen;
                producto.stock_zap = productoDTO.StockZapato;
                producto.fecha_alta = productoDTO.FechaAlta;
                producto.marca_zap = productoDTO.MarcaZapato;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(int id)
        {
            var producto = contexto.Productos.Find(id);
            if (producto != null)
            {
                contexto.Productos.Remove(producto);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
