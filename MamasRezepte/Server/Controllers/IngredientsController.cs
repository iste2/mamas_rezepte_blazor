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
    public class IngredientsController : ControllerBase
    {
        private DatabaseContext FDb;
        public IngredientsController(DatabaseContext _Db)
        {
            FDb = _Db;
        }

        // GET: api/<IngredientsController>
        [HttpGet]
        public async Task<List<Ingredient>> Get()
        {
            return await FDb.Ingredients.ToListAsync();
        }

        // GET api/<IngredientsController>/5
        [HttpGet("{id}")]
        public async Task<Ingredient> Get(long _Id)
        {
            return await FDb.Ingredients.FindAsync(_Id);
        }

        // POST api/<IngredientsController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Ingredient _Value)
        {
            if (ModelState.IsValid)
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

        // PUT api/<IngredientsController>/5
        [HttpPut("{id}")]
        public async Task<bool> Put(long _Id, [FromBody] Ingredient _Value)
        {
            if (_Id != _Value.Id) return false;
            FDb.Entry(_Value).State = EntityState.Modified;
            await FDb.SaveChangesAsync();
            return true;
        }

        // DELETE api/<IngredientsController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int _Id)
        {
            var hValue = await FDb.Ingredients.FindAsync(_Id);
            if (hValue == null) return false;
            FDb.Ingredients.Remove(hValue);
            await FDb.SaveChangesAsync();
            return true;
        }
    }
}
