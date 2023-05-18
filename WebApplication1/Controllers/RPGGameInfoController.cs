using API_EVT_FELIPE_CALENZO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/gameinfo")]
    public class RPGGameInfoController : ControllerBase

    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<RPGGameInfo> logger;

        public RPGGameInfoController(ILogger<RPGGameInfo> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<RPGGameInfo> Get()

        {
            var gameInfoList = new List<RPGGameInfo>
{
    new API_EVT_FELIPE_CALENZO.RPGGameInfo
    {
        GameName = " Naruto Shippuden
        GameMode = "Modo RPG/Aventura"
        PlayersOnline = 1,
        MaximumPlayers = 2,
        ServerStatus = "Online",
        AvailableMaps = new[] { "Akatsuki },
        GameEvents = new[] { "Evento 1"},
        Developer = "CALENZO",
        Publisher = "BANDAI",
        ReleaseDate = new DateTime(1997, 5,26)
    },

};

            return gameInfoList;
        } } }