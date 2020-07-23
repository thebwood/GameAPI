using System;
using System.Collections.Generic;

namespace Game.API.Data
{
    public partial class Games
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int GameRatingsId { get; set; }
    }
}
