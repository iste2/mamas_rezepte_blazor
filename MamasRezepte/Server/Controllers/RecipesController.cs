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
            return await FDb.Recipes
                .Include(_ => _.Images)
                .Include(_ => _.Tags)
                    .ThenInclude(_ => _.Tag)
                .Include(_ => _.Ingredients)
                    .ThenInclude(_ => _.Product)
                .Include(_ => _.Category)
                .Include(_ => _.DurationCategory)
                .Include(_ => _.Clicks)
                .FirstOrDefaultAsync(_ => _.Id == _Id);
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
                    // save recipe (id)
                    var hRecipe = new Recipe()
                    {
                        Id = _Value.Id,
                        Name = _Value.Name,
                        Subtitle = _Value.Subtitle,
                        PublishDate = DateTime.Now,
                        NumberOfPersons = _Value.NumberOfPersons,
                        Instruction = _Value.Instruction,
                        CategoryId = _Value.CategoryId,
                        DurationCategoryId = _Value.DurationCategoryId,
                        Tags = _Value.Tags.ToList(),
                        Ingredients = _Value.Ingredients.ToList(),
                    };
                    if(FDb.Recipes.Any(_ => _.Id == hRecipe.Id))
                    {
                        FDb.Entry(hRecipe).State = EntityState.Modified;
                    } else
                    {
                        FDb.Add(hRecipe);
                    }
                    
                    await FDb.SaveChangesAsync();
                    var hRecipeId = hRecipe.Id;
                
                    // save images
                    foreach(var hImage in _Value.Images)
                    {
                        hImage.RecipeId = hRecipeId;
                        if (FDb.Recipes.Any(_ => _.Id == hImage.Id))
                        {
                            FDb.Entry(hImage).State = EntityState.Modified;
                        }
                        else
                        {
                            FDb.Add(hImage);
                        }
                    }
                    await FDb.SaveChangesAsync();

                    // save tags
                    foreach (var hRecipeToTagRelation in _Value.Tags)
                    {
                        // ensure tag exists
                        if (!FDb.Tags.Any(_ => _.Name == hRecipeToTagRelation.Tag.Name))
                        {
                            FDb.Add(hRecipeToTagRelation.Tag);
                            await FDb.SaveChangesAsync();
                            hRecipeToTagRelation.TagId = hRecipeToTagRelation.Tag.Id;
                        }
                        // add if tag is not assigned to recipe
                        if(!FDb.RecipeToTagRelations.Any(_ => _.RecipeId == hRecipeId && _.TagId == hRecipeToTagRelation.Tag.Id))
                        {
                            hRecipeToTagRelation.TagId = hRecipeToTagRelation.Tag.Id;
                            hRecipeToTagRelation.RecipeId = hRecipeId;

                            hRecipeToTagRelation.Tag = null;

                            FDb.Add(hRecipeToTagRelation);
                            await FDb.SaveChangesAsync();
                        }
                        
                    }
                    

                    // save ingredients
                    foreach (var hIngredient in _Value.Ingredients)
                    {
                        if (!FDb.Products.Any(_ => _.Name == hIngredient.Product.Name))
                        {
                            FDb.Add(hIngredient.Product);
                            await FDb.SaveChangesAsync();
                            hIngredient.ProductId = hIngredient.Product.Id;
                        }

                        if(!FDb.Ingredients.Any(_ =>_.RecipeId == hRecipeId && _.Amount == hIngredient.Amount && _.Unit == hIngredient.Unit && _.ProductId == hIngredient.ProductId))
                        {
                            hIngredient.ProductId = hIngredient.Product.Id;
                            hIngredient.RecipeId = hRecipeId;

                            hIngredient.Product = null;

                            FDb.Add(hIngredient);
                            await FDb.SaveChangesAsync();
                        }
                    }


                    return true;
                }
                catch (DbUpdateException hException)
                {
                    Console.Error.WriteLine(hException.Message.ToString());
                    Console.Error.WriteLine(hException.InnerException.Message.ToString());
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
