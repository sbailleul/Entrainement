namespace TodoApi.Models
{
    public class Node
    {
        public int Id { get; set; }
        public Node Parent { get; set; }
        public int Cost { get; set; }

        public Node(int id, Node parent, int cost)
        {
            Id = id;
            Parent = parent;
            Cost = cost;
        }
    }
}