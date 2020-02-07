using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using AlgoApi.Models;
using AlgoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    // GET
    [Route("[controller]")]
    [ApiController]
    public class ShortestPathController : ControllerBase
    {
        private readonly IPathFinder _pathFinder;

        public ShortestPathController(IPathFinder pathFinder)
        {
            _pathFinder = pathFinder;
        }

        [HttpPost]
        public ActionResult<List<List<int>>> CalculateShortestPath(GraphRequest graphRequest)
        {
            var shortestPath = _pathFinder.FindShortestPath(graphRequest.Matrix, graphRequest.StartVector, graphRequest.EndVector);
            
            Thread.Sleep(10000);
            
            if (shortestPath == null) return NoContent();

            return shortestPath;
        }
    }
}