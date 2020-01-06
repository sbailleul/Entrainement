using System;
using System.Collections.Generic;
using System.Linq;
using AlgoApi.Models;

namespace AlgoApi.Services
{
    public class Dijkstra :  IPathFinder
    {
        public List<List<int>> FindShortestPath(List<int[]> matrix, List<int> startVector, List<int> endVector)
        {
            var doneNodes = new List<Node>();
            var start = startVector[0];
            var end = endVector[0];
            Node min;
            var nodes = InitNodes(matrix, startVector);

            do
            {
                min = GetMinimalCostNode(nodes, doneNodes);

                if (min.Pos[0] == end)
                {
                    break;
                }
                UpdateNodes(matrix, min, nodes);
            } while (nodes.Count>0 && min.Pos[0] != end );
            
            return GetShortestPath(doneNodes, startVector, endVector);
        }

        private static List<Node> InitNodes(List<int[]> matrix, List<int> start)
        {
            var nodes =  new List<Node>();
            for (var i = 0; i < matrix.Count; i++)
            {
                nodes.Add(new Node(new List<int>{i}, null, int.MaxValue));
            }

            var startNode = nodes.FirstOrDefault(node => node.Pos.SequenceEqual(start));
            if (startNode != null)
            {
                startNode.Cost = 0;
            }
            return nodes;
        }

        private static void UpdateNodes(List<int[]> matrix, Node min, List<Node> nodes)
        {
            if (matrix == null) throw new ArgumentNullException(nameof(matrix));
            if (min == null) throw new ArgumentNullException(nameof(min));
            if (nodes == null) throw new ArgumentNullException(nameof(nodes));
            
            for (var i = 0; i < matrix[min.Pos[0]].Length; i++)
            {
                if (matrix[min.Pos[0]][i] == 0 || (min.Parent != null && min.Parent.Pos[0] == i)) continue;
                var tmpCost = min.Cost + matrix[min.Pos[0]][i];
                var updatedNode = nodes.FirstOrDefault(node => node.Pos.SequenceEqual(new List<int>{i}));
                if ( updatedNode == null || updatedNode.Cost < tmpCost) continue;
                updatedNode.Cost = tmpCost;
                updatedNode.Parent = min;
            }
        }

        private static List<List<int>> GetShortestPath(IReadOnlyList<Node> nodes, List<int> start, List<int> end)
        {
            var shortestPath = new List<List<int>>();
            var node = nodes.FirstOrDefault(nodeEl => nodeEl.Pos.SequenceEqual(end));
            
            while (node != null && !node.Pos.SequenceEqual(start))
            {
                shortestPath.Add(node.Pos);
                node = node.Parent;
            }

            if (node != null) shortestPath.Add(node.Pos);

            return shortestPath;
        }

        private static Node GetMinimalCostNode(List<Node> nodes, List<Node> doneNodes)
        {
            if (nodes == null) throw new ArgumentNullException(nameof(nodes));
            if (doneNodes == null) throw new ArgumentNullException(nameof(doneNodes));
            
            var min = nodes.First();
            
            foreach (var node in nodes.Where(node => node.Cost < min.Cost))
            {
                min = node;
            }
            nodes.Remove(min);
            doneNodes.Add(min);
            
            return min;
        }
    }
}