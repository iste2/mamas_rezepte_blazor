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
    public class TagsController : ControllerBase
    {
        private DatabaseContext FDb;
        public TagsController(DatabaseContext _Db)
        {
            FDb = _Db;
        }

        // GET: api/<TagsController>
        [HttpGet]
        public async Task<List<Tag>> Get()
        {
            return await FDb.Tags.ToListAsync();
        }

        // GET: api/<TagsController>/ByUsageFrequency
        [HttpGet("ByUsageFrequency")]
        public async Task<List<Tag>> GetByUsageFrequency()
        {
            return await FDb.Tags.OrderByDescending(_ => FDb.RecipeToTagRelations.Where(_0 => _.Id == _0.TagId).Count()).ToListAsync();
        }

        // GET api/<TagsController>/5
        [HttpGet("{_Id}")]
        public async Task<Tag> Get(long _Id)
        {
            return await FDb.Tags.FindAsync(_Id);
        }

        // POST api/<TagsController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Tag _Value)
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

        // PUT api/<TagsController>/5
        [HttpPut("{_Id}")]
        public async Task<bool> Put(long _Id, [FromBody] Tag _Value)
        {
            if (_Id != _Value.Id) return false;
            FDb.Entry(_Value).State = EntityState.Modified;
            await FDb.SaveChangesAsync();
            return true;
        }

        // DELETE api/<TagsController>/5
        [HttpDelete("{_Id}")]
        public async Task<bool> Delete(int _Id)
        {
            var hValue = await FDb.Tags.FindAsync(_Id);
            if (hValue == null) return false;
            FDb.Tags.Remove(hValue);
            await FDb.SaveChangesAsync();
            return true;
        }
    }
}
