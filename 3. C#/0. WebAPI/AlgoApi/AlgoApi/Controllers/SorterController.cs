using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TodoApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ReorderController : ControllerBase
    {
        [HttpPost]
        public List<List<string>> SortMatrix(List<List<string>> matrix)
        {
            return new List<List<string>>();
        }
    }
}