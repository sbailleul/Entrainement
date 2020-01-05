using System;
using System.Collections.Generic;
using System.Linq;
using TodoApi.Models;

namespace TodoApi.Services
{
    public class Dijkstra : IPathFinder
    {
        public int[] FindShortestPath(List<int[]> matrix, int[] startVector, int[] endVector)
        {
            var nodes = new Dictionary<int, Node>();
            var doneNodes = new Dictionary<int, Node>();
            var start = startVector[0];
            var end = endVector[0];
            
            Node min;

            for (var i = 0; i < matrix.Count; i++)
            {
                nodes.Add(i,new Node(i, null,  int.MaxValue));
            }
            nodes[start].Cost = 0;

            do
            {
                min = SwitchNodeList(nodes, doneNodes);

                if (min.Id == end)
                {
                    break;
                }
                UpdateNodes(matrix, min, nodes);
            } while (nodes.Count>0 && min.Id != end );
            
            return GetShortestPath(doneNodes, start, end);
        }

        private static void UpdateNodes(List<int[]> matrix, Node min, Dictionary<int, Node> nodes)
        {
            if (matrix == null) throw new ArgumentNullException(nameof(matrix));
            if (min == null) throw new ArgumentNullException(nameof(min));
            if (nodes == null) throw new ArgumentNullException(nameof(nodes));
            
            for (var i = 0; i < matrix[min.Id].Length; i++)
            {
                if (matrix[min.Id][i] == 0 || (min.Parent != null && min.Parent.Id == i)) continue;
                var tmpCost = min.Cost + matrix[min.Id][i];
                if (!nodes.ContainsKey(i) || nodes[i].Cost < tmpCost) continue;
                nodes[i].Cost = tmpCost;
                nodes[i].Parent = min;
            }
        }

        private static int[] GetShortestPath(IReadOnlyDictionary<int, Node> nodes, int start, int end)
        {
            var shortestPath = new List<int>();
            var node = nodes[end];

            while (node.Id != start)
            {
                shortestPath.Add(node.Id);
                node = node.Parent;
            }
            shortestPath.Add(node.Id);
            return shortestPath.ToArray();
        }

        private static Node SwitchNodeList(Dictionary<int, Node> nodes, Dictionary<int, Node> doneNodes)
        {
            if (nodes == null) throw new ArgumentNullException(nameof(nodes));
            if (doneNodes == null) throw new ArgumentNullException(nameof(doneNodes));
            
            var min = nodes.First().Value;
            
            foreach (var (key, value) in nodes.Where(node => node.Value.Cost < min.Cost))
            {
                min = value;
            }
            nodes.Remove(min.Id);
            doneNodes.Add(min.Id,min);
            
            return min;
        }
    }
}