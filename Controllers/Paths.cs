using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PathFinder;

namespace PathFinderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Paths : ControllerBase
    {
        [Route("BFS")]
        [HttpPut]
        public ISearchResponse PutBFS([FromBody]RequestModel request) 
        {            
            var  GridSearchBFS = Factory.CreateGridSearchBFS();
            return GridSearchBFS.BFS(request.Grid, request.StartPosition, request.EndPosition, Factory.CreateEmptyResponse());
        }

        [Route("DFS")]
        [HttpPut]
        public ISearchResponse PutDFS([FromBody] RequestModel request)
        {
            var GridSearchBFS = Factory.CreateGridSearchDFS();
            return GridSearchBFS.DFS(request.Grid, request.StartPosition, request.EndPosition, Factory.CreateEmptyResponse());
        }


    }
}
