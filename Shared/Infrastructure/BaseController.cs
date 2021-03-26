using System.Threading.Tasks;
using api.Shared.Domain;
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
    }
}