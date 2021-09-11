using System.Collections.Generic;

namespace Server.ApiModel
{
    public class GameBoard
    {
        public string PlayerOne { get; set; }

        public string PlayerTwo { get; set; }

        public string GameResult { get; set; }

        public List<List<int>> Board { get; set; }

        public string CurrentTurn { get; set; }

        public int RemainingMoves{ get; set; }

        public GameBoard InitializeGameBoard()
            => new GameBoard
            {
                PlayerOne = null,
                PlayerTwo = null,
                Board = InitializeBoard(),
                GameResult = string.Empty,
                CurrentTurn = "p1",
                RemainingMoves = 42,
            };

        private List<List<int>> InitializeBoard()
        {
            var board = new List<List<int>>();

            for (var i = 0; i < 6; i++)
            {
                var tempList = new List<int>();

                for (var j = 0; j < 7; j++)
                {
                    tempList.Add(0);
                }

                board.Add(tempList);
            }

            return board;
        }
    }
}
