using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MamasRezepte.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MamasRezepte.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private DatabaseContext FDb;
        public CategoriesController(DatabaseContext _Db)
        {
            FDb = _Db;
        }

        // GET: api/<CategoriesController>
        [HttpGet]
        public async Task<List<Category>> Get()
        {
            return await FDb.Categories.ToListAsync();
        }

        // GET: api/<CategoriesController>/ByUsageFrequency
        [HttpGet("ByUsageFrequency")]
        public async Task<List<Category>> GetByUsageFrequency()
        {
            return await FDb.Categories.OrderByDescending(_ => FDb.Recipes.Where(_0 => _.Id == _0.CategoryId).Count()).ToListAsync();
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{_Id}")]
        public async Task<Category> Get(long _Id)
        {
            return await FDb.Categories.FindAsync(_Id);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Category _Value)
        {
            if(ModelState.IsValid)
            {
                FDb.Add(_Value);
                try
                {
                    await FDb.SaveChangesAsync();
                    return true;
                }
                catch (DbUpdateException)
                {
                    return false;
                }
            }
            return false;
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{_Id}")]
        public async Task<bool> Put(long _Id, [FromBody] Category _Value)
        {
            if (_Id != _Value.Id) return false;
            FDb.Entry(_Value).State = EntityState.Modified;
            await FDb.SaveChangesAsync();
            return true;
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{_Id}")]
        public async Task<bool> Delete(int _Id)
        {
            var hValue = await FDb.Categories.FindAsync(_Id);
            if (hValue == null) return false;
            FDb.Categories.Remove(hValue);
            await FDb.SaveChangesAsync();
            return true;
        }
    }
}
