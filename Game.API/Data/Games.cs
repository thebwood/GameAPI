using System;
using System.Collections.Generic;

namespace Game.API.Data
{
    public partial class Games
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int GameRatingsId { get; set; }
        public int? GameTypesId { get; set; }
    }
}
