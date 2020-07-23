using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.API.Domain.Models
{
    public class GameRatingsModel
    {
        public int Id { get; set; }
        public string Rating { get; set; }
        public int Age { get; set; }
    }
}
