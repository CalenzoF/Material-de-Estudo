using System;

namespace API_EVT_FELIPE_CALENZO
{
    public class RPGGameInfo
    {
        public string GameName { get; set; }

        public string GameMode { get; set; }

        public int PlayersOnline { get; set; }

        public int MaximumPlayers { get; set; }

        public string ServerStatus { get; set; }

        public string[] AvailableMaps { get; set; }

        public string[] GameEvents { get; set; }

        public string Developer { get; set; }

        public string Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }

    }
}

