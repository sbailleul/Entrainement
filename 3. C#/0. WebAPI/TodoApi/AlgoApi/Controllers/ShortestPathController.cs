using System.Collections.Generic;
using System.Threading.Tasks;
using AlgoApi.Models;
using AlgoApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    // GET
    [Route("api/[controller]")]
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
            return _pathFinder.FindShortestPath(graphRequest.Matrix, graphRequest.StartVector, graphRequest.EndVector);
        }
    }
}