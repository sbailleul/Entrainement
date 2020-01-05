using System.Collections.Generic;

namespace TodoApi.Models
{
    public class GraphRequest
    {
        public List<int[]> matrix { get; set; }
        public int[] startVector { get; set; }
        public int[] endVector { get; set; }
    }
}