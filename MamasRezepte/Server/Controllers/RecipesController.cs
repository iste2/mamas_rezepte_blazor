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
    public class RecipesController : ControllerBase
    {
        private DatabaseContext FDb;
        public RecipesController(DatabaseContext _Db)
        {
            FDb = _Db;
        }

        // GET: api/<RecipesController>
        [HttpGet]
        public async Task<List<Recipe>> Get()
        {
            return await FDb.Recipes.ToListAsync();
        }

        // GET api/<RecipesController>/5
        [HttpGet("{id}")]
        public async Task<Recipe> Get(long _Id)
        {
            return await FDb.Recipes.FindAsync(_Id);
        }

        // POST api/<RecipesController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Recipe _Value)
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

        // PUT api/<RecipesController>/5
        [HttpPut("{id}")]
        public async Task<bool> Put(long _Id, [FromBody] Recipe _Value)
        {
            if (_Id != _Value.Id) return false;
            FDb.Entry(_Value).State = EntityState.Modified;
            await FDb.SaveChangesAsync();
            return true;
        }

        // DELETE api/<RecipesController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int _Id)
        {
            var hValue = await FDb.Recipes.FindAsync(_Id);
            if (hValue == null) return false;
            FDb.Recipes.Remove(hValue);
            await FDb.SaveChangesAsync();
            return true;
        }
    }
}
