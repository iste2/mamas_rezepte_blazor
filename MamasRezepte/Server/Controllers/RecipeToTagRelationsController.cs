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
    public class RecipeToTagRelationsController : ControllerBase
    {
        private DatabaseContext FDb;
        public RecipeToTagRelationsController(DatabaseContext _Db)
        {
            FDb = _Db;
        }

        // GET: api/<RecipeToTagRelationsController>
        [HttpGet]
        public async Task<List<RecipeToTagRelation>> Get()
        {
            return await FDb.RecipeToTagRelations.ToListAsync();
        }

        // GET api/<RecipeToTagRelationsController>/5
        [HttpGet("{id}")]
        public async Task<RecipeToTagRelation> Get(long _Id)
        {
            return await FDb.RecipeToTagRelations.FindAsync(_Id);
        }

        // POST api/<RecipeToTagRelationsController>
        [HttpPost]
        public async Task<bool> Post([FromBody] RecipeToTagRelation _Value)
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

        // PUT api/<RecipeToTagRelationsController>/5
        [HttpPut("{id}")]
        public async Task<bool> Put(long _Id, [FromBody] RecipeToTagRelation _Value)
        {
            if (_Id != _Value.Id) return false;
            FDb.Entry(_Value).State = EntityState.Modified;
            await FDb.SaveChangesAsync();
            return true;
        }

        // DELETE api/<RecipeToTagRelationsController>/5
        [HttpDelete("{id}")]
        public async Task<bool> Delete(int _Id)
        {
            var hValue = await FDb.RecipeToTagRelations.FindAsync(_Id);
            if (hValue == null) return false;
            FDb.RecipeToTagRelations.Remove(hValue);
            await FDb.SaveChangesAsync();
            return true;
        }
    }
}
