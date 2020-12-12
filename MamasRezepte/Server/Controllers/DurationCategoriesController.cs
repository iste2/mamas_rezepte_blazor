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
    public class DurationCategoriesController : ControllerBase
    {
        private DatabaseContext FDb;
        public DurationCategoriesController(DatabaseContext _Db)
        {
            FDb = _Db;
        }

        // GET: api/<DurationCategoriesController>
        [HttpGet]
        public async Task<List<DurationCategory>> Get()
        {
            return await FDb.DurationCategories.ToListAsync();
        }

        // GET api/<DurationCategoriesController>/5
        [HttpGet("{_Id}")]
        public async Task<DurationCategory> Get(long _Id)
        {
            return await FDb.DurationCategories.FirstOrDefaultAsync(_ => _.Id == _Id);
        }

        // POST api/<DurationCategoriesController>
        [HttpPost]
        public async Task<bool> Post([FromBody] DurationCategory _Value)
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

        // PUT api/<DurationCategoriesController>/5
        [HttpPut("{_Id}")]
        public async Task<bool> Put(long _Id, [FromBody] DurationCategory _Value)
        {
            if (_Id != _Value.Id) return false;
            FDb.Entry(_Value).State = EntityState.Modified;
            await FDb.SaveChangesAsync();
            return true;
        }

        // DELETE api/<DurationCategoriesController>/5
        [HttpDelete("{_Id}")]
        public async Task<bool> Delete(int _Id)
        {
            var hValue = await FDb.DurationCategories.FindAsync(_Id);
            if (hValue == null) return false;
            FDb.DurationCategories.Remove(hValue);
            await FDb.SaveChangesAsync();
            return true;
        }
    }
}
