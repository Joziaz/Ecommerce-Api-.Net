using System.Threading.Tasks;
using api.Shared.Domain;
using api.Shared.Domain.Exeptions;
using Microsoft.AspNetCore.Mvc;

namespace api.Shared.Infrastructure
{
    public abstract class BaseController<T> : Controller where T : BaseEntity
    {
        private readonly IRepository<T> _repository;

        protected BaseController(IRepository<T> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var all = _repository.GetAll();

            return Ok(await all);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            var result = await _repository.Get(id);

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] T instance)
        {
            await _repository.Create(instance);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] T instance)
        {   
            instance.Id = id;
            try
            {
                await _repository.Update(instance);
            }
            catch (RegistryNotFoundException)
            {
                return NotFound("Invalid Id");
            }
            catch (System.Exception)
            {
                return BadRequest();
            }

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {   
            await _repository.Delete(id);
            return Ok();
        }
    }
}