using Ardalis.Specification;
using Domain.Entities;

namespace Application.Specifications
{
    public class ProductoIncludeSpecification : Specification<Productos>
    {

        public ProductoIncludeSpecification()
        {
            Query.Include("Categorias");
        }

        public ProductoIncludeSpecification(string nombre, string descripcion, string categoria)
        {
            var query = Query.Include("Categorias");
            if (!string.IsNullOrEmpty(nombre))
            {
                query = query.Where(s => s.Nombre.Contains(nombre));
            }

            if (!string.IsNullOrEmpty( descripcion))
            {
                query = query.Where(s => s.Descripcion.Contains(descripcion));
            }

            if (!string.IsNullOrEmpty(categoria))
            {
                query = query.Where(s => s.Categorias.Nombre.Contains(nombre));
            }
        }
    }
}
