using System.Collections.Generic;
using TodoApi.Models;

namespace TodoApi.Services
{
    public interface IPathFinder
    {
        int[] FindShortestPath(List<int[]> matrix, int[] startVector, int[] endVector);
    }
}