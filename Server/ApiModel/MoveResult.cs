namespace Server.ApiModel
{
    public class MoveResult
    {
        public GameBoard CurrentBoard { get; set; }

        public bool IsInvalidMove { get; set; }

        public string CurrentWinner { get; set; }

        public string FailureReason { get; set; }

        public string Winner => CurrentWinner;
    }
}
