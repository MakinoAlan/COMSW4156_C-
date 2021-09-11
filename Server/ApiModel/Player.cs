namespace Server.ApiModel
{
    public class Player
    {
        public string PlayerName { get; set; }

        public string SelectedColor { get; set; }

        public string ColoerStatus { get; set; }

        public Endpoint CurrentPosition { get; }
    }
}
