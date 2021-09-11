using Server.DomainModel;
using System;

namespace Server.Controller
{
    public class ServerGameController
    {
        public Status GetInitialStatus()
            => throw new NotImplementedException();

        public GameBoard UpdateAllBoards()
            => throw new NotImplementedException();

        public Status GetPlayOneStatus()
            => throw new NotImplementedException();

        public Status GetPlayerTwoStatus()
            => throw new NotImplementedException();

        public MoveResult MovePlayerPosition(Player player, Endpoint endpoint)
            => throw new NotImplementedException();
    }
}
