using Game.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Game.API.Domain.Services
{
    public class GameRepository : IGameRepository
    {
        private GamesContext _context;

        public GameRepository(GamesContext context) => _context = context;

        public IEnumerable<Games> GetGames() => _context.Games;
        public IEnumerable<GameRatings> GetGameRatings() => _context.GameRatings;

    }
}
