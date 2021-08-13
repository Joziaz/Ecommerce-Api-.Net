using System.Threading.Tasks;
using Ecommerce.BackOffice.Infrastructure.Persistance;
using Ecommerce.BackOffice.Inventory.Application;
using Ecommerce.BackOffice.Inventory.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Api.BackOffice.Controllers
{

    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
       private readonly ProductService _service;

        public ProductController(ProductService service)
        {
            _service = service;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await _service.GetAll();
            return Ok(products);
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> Get(int id)
        {
            try 
            {
                var product = await _service.GetProduct(id);
                return Ok(product);
            }
            catch(System.Exception e)
            {
                return NotFound(e.Message);
            }
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductAsync([FromBody] Product product)
        {
            try
            {
                await _service.CreateProduct(product);
                return Created("",product);
            }
            catch (System.Exception e)
            {
              return BadRequest(e.Message);
            }
        }
        
        [HttpPut]
        public async Task<IActionResult> UpdateProduct([FromBody] Product product)
        {
            await _service.Update(product);
            return Ok();
        }

        [HttpDelete("/{id}")]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            try
            {
                await _service.DeleteProduct(id);
                return Ok();
            }
            catch (System.Exception e)
            {
                return BadRequest(e.Message);
            }
        }
        
    }
}