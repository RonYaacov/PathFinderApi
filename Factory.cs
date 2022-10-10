using PathFinder;
using PathFinder.Abstractions;
using PathFinder.Models;
using PathFinder.SearchMethods;

namespace PathFinderApi
{
    public static class Factory
    {
        public static ISearchResponse CreateEmptyResponse()
        {
            return new SearchResponse(0, new List<int[]>(), false, null, "");
        }
        public static GridBFS CreateGridSearchBFS()
        {
            return new GridBFS();
        }
        public static GridDFS CreateGridSearchDFS()
        {
            return new GridDFS();
        }
    }
}
