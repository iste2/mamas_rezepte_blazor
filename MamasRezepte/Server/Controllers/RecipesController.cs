using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            var hRecipes = FDb.Recipes.ToList();
            foreach(var hRecipe in hRecipes)
            {
                hRecipe.Images = FDb.RecipeImages.Where(_ => _.RecipeId == hRecipe.Id)
                    .Select(_0 => new RecipeImage { Id = _0.Id, ImageData = _0.ImageData, RecipeId = _0.RecipeId }).ToList();
                hRecipe.Tags = FDb.RecipeToTagRelations.Where(_ => _.RecipeId == hRecipe.Id)
                    .Select(_0 => new RecipeToTagRelation { Id = _0.Id, TagId = _0.TagId, RecipeId = _0.RecipeId }).ToList();
                foreach(var hTag in hRecipe.Tags)
                {
                    var hHTag = FDb.Tags.FirstOrDefault(_ => _.Id == hTag.TagId);
                    hTag.Tag = new Tag { Id = hHTag.Id, Name = hHTag.Name };
                }
                hRecipe.Ingredients = FDb.Ingredients.Where(_ => _.RecipeId == hRecipe.Id)
                    .Select(_0 => new Ingredient { Id = _0.Id, Amount = _0.Amount, Unit = _0.Unit, ProductId = _0.ProductId, RecipeId = _0.RecipeId }).ToList();
                foreach (var hIngredient in hRecipe.Ingredients)
                {
                    var hProduct = FDb.Products.FirstOrDefault(_ => _.Id == hIngredient.ProductId);
                    hIngredient.Product = new Product { Id = hProduct.Id, Name = hProduct.Name };
                }
                var hCategory = FDb.Categories.FirstOrDefault(_ => hRecipe.CategoryId == _.Id);
                hRecipe.Category = new Category { Id = hCategory.Id, Name = hCategory.Name };
                var hDurationCategory = FDb.DurationCategories.FirstOrDefault(_ => hRecipe.DurationCategoryId == _.Id);
                hRecipe.DurationCategory = new DurationCategory { Id = hDurationCategory.Id, Name = hDurationCategory.Name };
                hRecipe.Clicks = FDb.Clicks.Where(_ => _.RecipeId == hRecipe.Id)
                    .Select(_0 => new Click { Id = _0.Id, Time = _0.Time, RecipeId = _0.RecipeId }).ToList();
            }

            return hRecipes;
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
                        //Tags = _Value.Tags.ToList(),
                        //Ingredients = _Value.Ingredients.ToList(),
                    };
                    FDb.Add(hRecipe);

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

            try
            {
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
                    //Tags = _Value.Tags.ToList(),
                    //Ingredients = _Value.Ingredients.ToList(),
                };
                FDb.Entry(hRecipe).State = EntityState.Modified;
                await FDb.SaveChangesAsync();

                // add images
                foreach(var hImage in _Value.Images)
                {
                    if(hImage.Id == 0)
                    {
                        FDb.Add(hImage);
                    }
                }
                await FDb.SaveChangesAsync();

                // delete images
                var hDbImages = FDb.RecipeImages.Where(_ => _.RecipeId == _Value.Id).ToList();
                foreach(var hDbImage in hDbImages)
                {
                    if(!_Value.Images.Any(_ => _.Id == hDbImage.Id))
                    {
                        FDb.RecipeImages.Remove(hDbImage);
                        await FDb.SaveChangesAsync();
                    }
                }

                // add tags
                foreach(var hTag in _Value.Tags)
                {
                    if(hTag.Tag.Id == 0)
                    {
                        FDb.Add(hTag.Tag);
                        await FDb.SaveChangesAsync();
                    }
                    if (hTag.Id == 0)
                    {
                        hTag.RecipeId = _Value.Id;
                        hTag.TagId = hTag.Tag.Id;
                        hTag.Tag = null;
                        FDb.Add(hTag);
                        await FDb.SaveChangesAsync();
                    }
                }
                

                // delete tags
                var hDbTags = FDb.RecipeToTagRelations.Where(_ => _.RecipeId == _Value.Id).ToList();
                foreach(var hDbTag in hDbTags)
                {
                    if(!_Value.Tags.Any(_ => _.TagId == hDbTag.TagId))
                    {
                        FDb.RecipeToTagRelations.Remove(hDbTag);
                        await FDb.SaveChangesAsync();
                    }
                }

                // add ingredients
                foreach(var hIngredient in _Value.Ingredients)
                {
                    if(hIngredient.Product.Id == 0)
                    {
                        FDb.Add(hIngredient.Product);
                        await FDb.SaveChangesAsync();
                    }
                    if(hIngredient.Id == 0)
                    {
                        hIngredient.RecipeId = _Value.Id;
                        hIngredient.ProductId = hIngredient.Product.Id;
                        hIngredient.Product = null;
                        FDb.Add(hIngredient);
                        await FDb.SaveChangesAsync();
                    }
                }

                // delete ingredient
                var hDbIngredients = FDb.Ingredients.Where(_ => _.RecipeId == _Value.Id).ToList();
                foreach(var hDbIngredient in hDbIngredients)
                {
                    if(!_Value.Ingredients.Any(_ => _.Id == hDbIngredient.Id))
                    {
                        FDb.Ingredients.Remove(hDbIngredient);
                        await FDb.SaveChangesAsync();
                    }
                }

                return true;
            } catch(DbUpdateException _Exception)
            {
                return false;
            }

            
        }

        // DELETE api/<RecipesController>/5
        [HttpDelete("{_Id}")]
        public async Task<bool> Delete(long _Id)
        {
            var hValue = await FDb.Recipes.FindAsync(_Id);
            if (hValue == null) return false;
            FDb.Recipes.Remove(hValue);
            await FDb.SaveChangesAsync();
            return true;
        }
    }
}
