using System;
using System.Collections.Generic;

namespace Game.API.Data
{
    public partial class GamesGameTypes
    {
        public long Id { get; set; }
        public long GameId { get; set; }
        public int GameTypesId { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
