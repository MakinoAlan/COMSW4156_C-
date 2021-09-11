using System;
using System.Collections.Generic;

namespace Server.DomainModel
{
    public class GameBoard
    {
        public Color PlayerOne { get; }

        public Color PlayerTwo { get; }

        public string GameResult { get; }

        public List<List<int>> Board { get; }

        public string CurrentTurn { get; }

        public int RemainingMoves { get; }

        public GameBoard(
            Color playerOne,
            Color playerTwo,
            string gameResult,
            List<List<int>> board,
            string currentTurn,
            int remainingMoves)
        {
            PlayerOne = playerOne;
            PlayerTwo = playerTwo;
            GameResult = gameResult ?? throw new ArgumentNullException(nameof(gameResult));
            Board = board ?? throw new ArgumentNullException(nameof(board));
            CurrentTurn = currentTurn ?? throw new ArgumentNullException(nameof(currentTurn));
            RemainingMoves = remainingMoves;
        }
    }
}
