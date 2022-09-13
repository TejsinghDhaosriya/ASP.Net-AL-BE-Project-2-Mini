using GovtPincodeApp.Domain.requests;
using GovtPincodeApp.Domain.response;
using GovtPincodeApp.Service;
using Microsoft.AspNetCore.Mvc;

namespace GovtPincodeApp.Controllers
{
    [ApiController]
    [Route("api/")]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService _searchService;

        public SearchController(ISearchService iSearchService)
        {
            _searchService = iSearchService;
        }


        [HttpGet("search")]
        public ActionResult<SearchResponse>? GetMeters([FromQuery] QueryParameters queryParameters)
        {
            try
            {
                return Ok(new SearchResponse(_searchService.Search(queryParameters)));
            }
            catch (Exception ex)
            {
                return NotFound(new SearchResponse(error: ex.Message));
            }
        }
    }
}