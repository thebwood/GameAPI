using System;
using System.Collections.Generic;

namespace Game.API.Data
{
    public partial class GamesGameFormats
    {
        public long Id { get; set; }
        public long? GameId { get; set; }
        public int? GameFormatId { get; set; }
        public DateTime? ReleaseDate { get; set; }
    }
}
