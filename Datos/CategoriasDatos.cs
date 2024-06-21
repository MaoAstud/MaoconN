using AccesoDatos;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class CategoriasDatos
    {
        private maoconnEntities contexto;

        public CategoriasDatos()
        {
            contexto = new maoconnEntities();
        }

        public List<CategoriaDTO> ObtenerLista()
        {
            return contexto.Categorias.Select(c => new CategoriaDTO
            {
                IdCategoria = c.id_categoria,
                NombreCategoria = c.nombre_cat,
                DescripcionCategoria = c.descripcion_cat,
                IdPadre = c.id_padre
            }).ToList();
        }

        public CategoriaDTO BuscarPorID(int id)
        {
            var categoria = contexto.Categorias.Find(id);
            if (categoria != null)
            {
                return new CategoriaDTO
                {
                    IdCategoria = categoria.id_categoria,
                    NombreCategoria = categoria.nombre_cat,
                    DescripcionCategoria = categoria.descripcion_cat,
                    IdPadre = categoria.id_padre
                };
            }
            return null;
        }

        public bool Agregar(CategoriaDTO categoriaDTO)
        {
            var categoria = new Categorias
            {
                nombre_cat = categoriaDTO.NombreCategoria,
                descripcion_cat = categoriaDTO.DescripcionCategoria,
                id_padre = categoriaDTO.IdPadre
            };
            contexto.Categorias.Add(categoria);
            contexto.SaveChanges();
            return true;
        }

        public bool Actualizar(CategoriaDTO categoriaDTO)
        {
            var categoria = contexto.Categorias.Find(categoriaDTO.IdCategoria);
            if (categoria != null)
            {
                categoria.nombre_cat = categoriaDTO.NombreCategoria;
                categoria.descripcion_cat = categoriaDTO.DescripcionCategoria;
                categoria.id_padre = categoriaDTO.IdPadre;
                contexto.SaveChanges();
                return true;
            }
            return false;
        }

        public bool Eliminar(int id)
        {
            var categoria = contexto.Categorias.Find(id);
            if (categoria != null)
            {
                contexto.Categorias.Remove(categoria);
                contexto.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
