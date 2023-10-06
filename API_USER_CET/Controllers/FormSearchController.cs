using API_USER_CET.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace API_USER_CET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FormSearchController : ControllerBase
    {
        private readonly TnDbContext _DbContext;
        public FormSearchController (TnDbContext context)
        {
            _DbContext = context;
        }
        //api/FormSearch
        [HttpGet("FormSearch/{key}")]
        public async Task<ActionResult<IEnumerable<SearchResults>>> FormSearch(string key)
        {
            var searchResults = new List<SearchResults>();
           
            var introduceResults = await _DbContext.Introduces.Where(
                                 i => i.Name.Contains(key)
                                 || i.Description.Contains(key)
                                 || i.Creator.Contains(key))
                .Select(i => new SearchResults
                {
                    Type = "Introduce",
                    Name = i.Name,
                    Description = i.Description,
                    Content = i.Content,
                    Creator = i.Creator
                }).ToListAsync();

            var NewArticleResults = await _DbContext.NewsArticles.Where(
                                n => n.Name.Contains(key)
                                || n.Description.Contains(key)
                                || n.Content.Contains(key)
                                || n.Created.Contains(key))
                .Select(n => new SearchResults
                {
                    Type = "NewsArticle",
                    Name = n.Name,
                    Description = n.Description,
                    Content = n.Content,
                    Created = n.Created
                }).ToListAsync();

            searchResults.AddRange(introduceResults);
            searchResults.AddRange(NewArticleResults);

            return searchResults;

        }
    }
}
