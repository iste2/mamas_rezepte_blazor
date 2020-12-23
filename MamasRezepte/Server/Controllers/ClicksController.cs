using MamasRezepte.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MamasRezepte.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClicksController : ControllerBase
    {
        private DatabaseContext FDb;
        public ClicksController(DatabaseContext _Db)
        {
            FDb = _Db;
        }

        // GET: api/<ClicksController>
        [HttpGet]
        public async Task<List<Click>> Get()
        {
            return await FDb.Clicks.ToListAsync();
        }

        // GET api/<ClicksController>/5
        [HttpGet("{_Id}")]
        public async Task<Click> Get(long _Id)
        {
            return await FDb.Clicks.FindAsync(_Id);
        }

        // POST api/<ClicksController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Click _Value)
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

        // PUT api/<ClicksController>/5
        [HttpPut("{_Id}")]
        public async Task<bool> Put(long _Id, [FromBody] Click _Value)
        {
            if (_Id != _Value.Id) return false;
            FDb.Entry(_Value).State = EntityState.Modified;
            await FDb.SaveChangesAsync();
            return true;
        }

        // DELETE api/<ClicksController>/5
        [HttpDelete("{_Id}")]
        public async Task<bool> Delete(int _Id)
        {
            var hValue = await FDb.Clicks.FindAsync(_Id);
            if (hValue == null) return false;
            FDb.Clicks.Remove(hValue);
            await FDb.SaveChangesAsync();
            return true;
        }
    }
}
