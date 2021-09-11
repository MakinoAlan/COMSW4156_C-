using System;

namespace Server.DomainModel
{
    public class MoveResult
    {
        public GameBoard CurrentBoard{ get; }

        public bool IsInvalidMove { get; }

        public string CurrentWinner { get; }

        public string FailureReason { get; }

        public string Winner => CurrentWinner;

        public MoveResult(
            GameBoard currentBoard,
            bool isInvalidMove,
            string currentWinner,
            string failureReason)
        {
            CurrentBoard = currentBoard ?? throw new ArgumentNullException(nameof(currentBoard));
            IsInvalidMove = isInvalidMove;
            CurrentWinner = currentWinner ?? throw new ArgumentNullException(nameof(currentWinner));
            FailureReason = failureReason ?? throw new ArgumentNullException(nameof(failureReason));
        }
    }
}
