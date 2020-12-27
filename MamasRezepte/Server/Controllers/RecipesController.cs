using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MamasRezepte.Shared.Helper;
using MamasRezepte.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

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
        [HttpGet("{_Id}")]
        public async Task<Recipe> Get(long _Id)
        {
            return await FDb.Recipes.FindAsync(_Id);
        }

        // GET api/<RecipesController>/Feed
        [HttpGet("Feed")]
        public async Task<IAsyncEnumerable<Recipe>> GetFeed()
        {
            var hClicks = FDb.Clicks.AsEnumerable();
            return FDb.Recipes
                //.Include(_ => _.Images)
                .Include(_ => _.Clicks)
                .AsAsyncEnumerable();
        }

        // POST api/<RecipesController>
        [HttpPost]
        public async Task<bool> Post([FromBody] Recipe _Value)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    // save recipe
                    var hRecipe = new Recipe()
                    {
                        Name = _Value.Name,
                        Subtitle = _Value.Subtitle,
                        PublishDate = DateTime.Now,
                        NumberOfPersons = _Value.NumberOfPersons,
                        Instruction = _Value.Instruction,
                        CategoryId = _Value.CategoryId,
                        DurationCategoryId = _Value.DurationCategoryId,
                    };
                    FDb.Add(hRecipe);
                    await FDb.SaveChangesAsync();
                    var hRecipeId = hRecipe.Id;
                
                    // save images
                    foreach(var hImage in _Value.Images)
                    {
                        hImage.RecipeId = hRecipeId;
                        FDb.Add(hImage);
                    }
                    await FDb.SaveChangesAsync();

                    // save tags
                    foreach (var hRecipeToTagRelation in _Value.Tags)
                    {
                        var hTagId = hRecipeToTagRelation.Tag.Id;
                        if (hRecipeToTagRelation.Tag.Id == 0)
                        {
                            FDb.Add(hRecipeToTagRelation.Tag);
                            await FDb.SaveChangesAsync();
                            hTagId = hRecipeToTagRelation.Tag.Id;
                        }
                        var hNewRecipeToTagRelation = new RecipeToTagRelation()
                        {
                            RecipeId = hRecipeId,
                            TagId = hTagId,
                        };
                        FDb.Add(hNewRecipeToTagRelation);
                    }
                    await FDb.SaveChangesAsync();

                    // save ingredients
                    foreach (var hIngredient in _Value.Ingredients)
                    {
                        var hProductId = hIngredient.Product.Id;
                        if(hProductId == 0)
                        {
                            FDb.Add(hIngredient.Product);
                            await FDb.SaveChangesAsync();
                            hProductId = hIngredient.Product.Id;
                        }
                        var hNewIngredient = new Ingredient()
                        {
                            Amount = hIngredient.Amount,
                            Unit = hIngredient.Unit,
                            ProductId = hProductId,
                            RecipeId = hRecipeId,
                        };
                        FDb.Add(hNewIngredient);
                    }
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
        [HttpPut("{_Id}")]
        public async Task<bool> Put(long _Id, [FromBody] Recipe _Value)
        {
            if (_Id != _Value.Id) return false;
            FDb.Entry(_Value).State = EntityState.Modified;
            await FDb.SaveChangesAsync();
            return true;
        }

        // DELETE api/<RecipesController>/5
        [HttpDelete("{_Id}")]
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
