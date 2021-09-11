using System;

namespace Server.DomainModel
{
    public class Player
    {
        public string PlayerName { get; }

        public Color? SelectedColor { get; }

        public Status ColoerStatus => SelectedColor != null ? Status.ColorPicked : Status.ColorNotPicked;

        public Endpoint CurrentPosition { get; }

        public Player(
            string playerName,
            Color? selectedColor,
            Endpoint currentPosition)
        {
            PlayerName = playerName ?? throw new ArgumentNullException(nameof(playerName));
            SelectedColor = selectedColor;
            CurrentPosition = currentPosition ?? throw new ArgumentNullException(nameof(currentPosition));
        }

        public Player WithPosition(Endpoint newPosition)
            => new Player(
                PlayerName,
                SelectedColor,
                newPosition);

        public Player WithColor(Color color)
            => new Player(
                PlayerName,
                color,
                CurrentPosition);
    }
}
