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
    public class ProductsController : ControllerBase
    {
        private DatabaseContext FDb;
        public ProductsController(DatabaseContext _Db)
        {
            FDb = _Db;
        }

        // GET: api/<ProductsController>
        [HttpGet]
        public async Task<List<Product>> Get()
        {
            return await FDb.Products.ToListAsync();
        }

        // GET: api/<ProductsController>/ByUsageFrequency
        [HttpGet("ByUsageFrequency")]
        public async Task<List<Product>> GetByUsageFrequency()
        {
            var hGrouped = FDb.Ingredients.GroupBy(_ => _.ProductId);
            return await FDb.Products.OrderByDescending(_ => hGrouped.Single(_0 => _0.Key == _.Id).Count()).ToListAsync();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{_Id}")]
        public async Task<Product> Get(long _Id)
        {
            return await FDb.Products.FindAsync(_Id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Product _Value)
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

        // PUT api/<ProductsController>/5
        [HttpPut("{_Id}")]
        public async Task<bool> Put(long _Id, [FromBody] Product _Value)
        {
            if (_Id != _Value.Id) return false;
            FDb.Entry(_Value).State = EntityState.Modified;
            await FDb.SaveChangesAsync();
            return true;
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{_Id}")]
        public async Task<bool> Delete(int _Id)
        {
            var hValue = await FDb.Products.FindAsync(_Id);
            if (hValue == null) return false;
            FDb.Products.Remove(hValue);
            await FDb.SaveChangesAsync();
            return true;
        }
    }
}
