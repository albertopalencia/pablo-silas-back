using Application.Parameters;

namespace Application.Feautures.Productos.Queries.GetAllProducto
{
    public class GetAllProductoParameters : RequestParameter
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
    }
}
