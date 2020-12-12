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
    public class RecipeImagesController : ControllerBase
    {
        private DatabaseContext FDb;
        public RecipeImagesController(DatabaseContext _Db)
        {
            FDb = _Db;
        }

        // GET: api/<RecipeImagesController>
        [HttpGet]
        public async Task<List<RecipeImage>> Get()
        {
            return await FDb.RecipeImages.ToListAsync();
        }

        // GET api/<RecipeImagesController>/5
        [HttpGet("{_Id}")]
        public async Task<RecipeImage> Get(long _Id)
        {
            return await FDb.RecipeImages.FindAsync(_Id);
        }

        // POST api/<RecipeImagesController>
        [HttpPost]
        public async Task<bool> Post([FromBody] RecipeImage _Value)
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

        // PUT api/<RecipeImagesController>/5
        [HttpPut("{_Id}")]
        public async Task<bool> Put(long _Id, [FromBody] RecipeImage _Value)
        {
            if (_Id != _Value.Id) return false;
            FDb.Entry(_Value).State = EntityState.Modified;
            await FDb.SaveChangesAsync();
            return true;
        }

        // DELETE api/<RecipeImagesController>/5
        [HttpDelete("{_Id}")]
        public async Task<bool> Delete(int _Id)
        {
            var hValue = await FDb.RecipeImages.FindAsync(_Id);
            if (hValue == null) return false;
            FDb.RecipeImages.Remove(hValue);
            await FDb.SaveChangesAsync();
            return true;
        }
    }
}
