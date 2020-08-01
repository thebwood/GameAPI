using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.API.Domain.Models
{
    public class GameSearchModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int? ReleaseYear { get; set; }
        public int? GameRatingsId { get; set; }
        public List<int> GameTypeIds { get; set; }
    }
}
