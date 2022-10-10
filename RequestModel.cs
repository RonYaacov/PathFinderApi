namespace PathFinderApi
{
    public class RequestModel
    {
        public string[][] Grid { get; set; }
        public int[] StartPosition { get; set; }
        public int[] EndPosition { get; set; }

        public RequestModel(string[][] grid, int[] startposition, int[] endPosition)
        {
            Grid = grid;    
            StartPosition = startposition;
            EndPosition = endPosition;
        }
    }
}
