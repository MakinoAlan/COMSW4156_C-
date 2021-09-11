using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Server.ApiModel;
using Server.Controller;
using System;

namespace COMSW4156.Controllers
{
    [ApiController]
    [Route("COMSW4156")]
    public class ClientGameController : ControllerBase
    {
        private readonly ServerGameController _serverController;
        private readonly ILogger<ClientGameController> _logger;
        private GameBoard gameBoard;

        public ClientGameController(ILogger<ClientGameController> logger)
        {
            _logger = logger;
            _serverController = new ServerGameController();
        }
        /// <summary>
        /// Method Type: GET
        /// Initial Webpage where gameboard is initialized
        /// </summary>
        /// <returns>template player1_connect.html and status = "Pick a Color."</returns>
        /// TODO: Implement '/' endpoint
        [HttpGet]
        public IActionResult GetInitialStatus()
           => Ok(_serverController.GetInitialStatus());

        // Helper function that sends to all boards don't modify
        [HttpGet]
        [Route("autoUpdate")]
        public IActionResult UpdateAllBoards() 
        {
            try 
            {
                return Ok(new 
                {
                    move = gameBoard.Board,
                    winner = gameBoard.GameResult,
                    color = gameBoard.PlayerOne,
                });
            }
            catch (Exception)
            {
                return NotFound(new 
                {
                    move = "",
                });
            }
        }

        /// <summary>
        /// Method Type: GET
        /// Assign player1 their color
        /// </summary>
        /// <returns>return: template player1_connect.html and status = <Color picked></returns>
        /// TODO: Implement '/p1Color' endpoint
        [HttpGet]
        [Route("p1Color")]
        public IActionResult GetPlayOneStatus()
            => Ok(_serverController.GetPlayOneStatus());

        /// <summary>
        /// Method Type: GET
        /// if P1 didn't pick color first
        /// </summary>
        /// <returns>template p2Join.html and status = <Color picked> or Error</returns>
        /// TODO: Implement '/p2Join' endpoint
        [HttpGet]
        [Route("p2Join")]
        public IActionResult GetPlayerTwoStatus()
            => Ok(_serverController.GetPlayerTwoStatus());

        /// <summary>
        /// Method Type: POST
        /// invalid=True or False, winner = <currWinner>)
        /// If move is valid --> invalid = False else invalid = True
        /// If invalid == True, also return reason= <Why Move is Invalid>
        /// </summary>
        /// <param name="endpoint"></param>
        /// <returns>jsonify (move=<CurrentBoard></returns>
        /// TODO: Implement '/move1' endpoint
        [HttpPost]
        [Route("move1")]
        public IActionResult MovePlayerOnePosition([FromBody] Endpoint endpoint)
            => Ok(_serverController.MovePlayerPosition());

        // Same as '/move1' but instead proccess Player 2
        [HttpPost]
        [Route("move2")]
        public IActionResult MovePlayerTwoPosition()
            => Ok(_serverController.MovePlayerPosition());
    }
}
