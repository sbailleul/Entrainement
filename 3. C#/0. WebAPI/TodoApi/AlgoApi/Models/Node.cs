using System.Collections.Generic;

namespace AlgoApi.Models
{
    public class Node
    {
        public List<int> Pos { get; set; }
        public Node Parent { get; set; }
        public int Cost { get; set; }

        public Node(List<int> pos, Node parent, int cost)
        {
            Pos = pos;
            Parent = parent;
            Cost = cost;
        }
    }
}