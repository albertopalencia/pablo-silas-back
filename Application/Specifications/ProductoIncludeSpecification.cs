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
    }
}
