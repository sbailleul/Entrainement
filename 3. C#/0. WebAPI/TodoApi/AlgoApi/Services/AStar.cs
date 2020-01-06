using System.Collections.Generic;
using AlgoApi.Models;

namespace AlgoApi.Services
{
    public class AStar: IPathFinder
    {
        public List<List<int>> FindShortestPath(List<int[]> matrix, List<int> startVector, List<int> endVector)
        {
//            var nodes = InitNodes(matrix, startVector);
            var doneNodes = new Dictionary<int[], Node>();
            Node min;

            return new List<List<int>>();
        }
        
//        private static Dictionary<int[], Node> InitNodes(List<int[]> matrix, int[] start)
//        {
//            var nodes =  new Dictionary<int[], Node>();
//            for (var i = 0; i < matrix.Count; i++)
//            {
//                for (int j = 0; j < matrix[i].Length; j++)
//                {
//                    if (matrix[i][j] == 0) continue;
//                    nodes.Add(new []{i,j}, new Node(new[] {i,j}, null, int.MaxValue));
//                }
//            }
//            nodes[start].Cost = 0;
//            return nodes;
//        }
    }
}