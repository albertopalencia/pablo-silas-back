using Application.Feautures.Editorial.Queries.GetAllProducto;
using Application.Feautures.Producto.Commands.CreateProductoCommand;
using Application.Feautures.Producto.Commands.DeleteProductoCommand;
using Application.Feautures.Producto.Commands.EditProductoCommand;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace WebApi.Controllers.v1
{
    [ApiVersion("1.0")]
    public class ProductoController : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await Mediator.Send(new GetAllProductoQuery()));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(await Mediator.Send(new GetByProductoIdQuery { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductoCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpPut]
        public async Task<IActionResult> Put([FromBody] EditProductoCommand command)
        {
            return Ok(await Mediator.Send(command));
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return Ok(await Mediator.Send(new DeleteProductoCommand { Id = id }));
        }
    }
}