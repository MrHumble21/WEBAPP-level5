using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;
using WebAPI.Repositories;
using System.Transactions;

namespace WebAPI.Controllers
{
    [Route("api/Category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IcategoryRepo _categoryRepo;
        public CategoryController(IcategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        // GET: api/Category
        [HttpGet]
        public IActionResult Get()
        {
            var category = _categoryRepo.Get_Cat();
            return new OkObjectResult(category);
        }
        // GET: api/Category/5
        [HttpGet("{id}", Name = "GetC")]
        public IActionResult Get(int id)
        {
            var category = _categoryRepo.Get_Cat_ById(id);
            return new OkObjectResult(category);
        }
        // POST: api/Category
        [HttpPost]
        public IActionResult Post([FromBody] Category category)
        {
            using (var scope = new TransactionScope())
            {
                _categoryRepo.Insert_Cat(category);
                scope.Complete();
                return CreatedAtAction(nameof(Get), new { id = category.ID }, category);
            }
        }
        // PUT: api/Category/5
        [HttpPut("{id}")]
        public IActionResult Put([FromBody] Category category)
        {
            if (category != null)
            {
                using (var scope = new TransactionScope())
                {
                    _categoryRepo.Update_Cat(category);
                    scope.Complete();
                    return new OkResult();
                }
            }
            return new NoContentResult();
        }
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _categoryRepo.Delete_Cat(id);
            return new OkResult();
        }
    }
}
