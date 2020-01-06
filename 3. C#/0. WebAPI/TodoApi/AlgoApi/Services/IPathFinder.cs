using System.Collections.Generic;

namespace AlgoApi.Services
{
    public interface IPathFinder
    {
        List<List<int>> FindShortestPath(List<int[]> matrix, List<int> startVector, List<int> endVector);
    }
}